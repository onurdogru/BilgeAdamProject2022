using MarsHostelProject.Models;
using MarsHostelProject.Models.Context;
using MarsHostelProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarsHostelProject.Controllers
{
    public class HomeController : Controller
    {
        MarsHostelContext db = new MarsHostelContext();
        // GET: Home
        public ActionResult Index()
        {
            var room1 = db.Rooms.Where(x => x.NumberOfPeople == 1).FirstOrDefault();
            var room2 = db.Rooms.Where(x => x.NumberOfPeople == 2).FirstOrDefault();
            var room3 = db.Rooms.Where(x => x.NumberOfPeople == 3).FirstOrDefault();
            List<Room> rooms = new List<Room>();
            rooms.Add(room1);
            rooms.Add(room2);
            rooms.Add(room3);
            return View(rooms);
        }

        public ActionResult Rezervation(int id)
        {
            var room = db.Rooms.FirstOrDefault(x => x.ID == id);
            if (room!= null)
            {
                return View(room);
            }
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Rezervation(RezervationDTO model)
        {
            if (ModelState.IsValid)
            {
                Room room = db.Rooms.Find(model.RoomId);
                if (room != null)
                {
                    Rezervation rezervation = new Rezervation();
                    rezervation.FirstDate = model.FirstDate;
                    rezervation.LastDate = model.LastDate;
                    rezervation.RoomId = model.RoomId;
                    model.Quantity = (int)(model.LastDate - model.FirstDate).TotalDays;
                    rezervation.Quantity = model.Quantity;
                    rezervation.Price = room.Price;
                    rezervation.SubTotal = model.SubTotal;
                    db.Rezervations.Add(rezervation);
                    db.SaveChanges();

                    Customer customer = new Customer();
                    customer.FirstName = model.FirstName;
                    customer.LastName = model.LastName;
                    customer.PhoneNumber = model.PhoneNumber;
                    customer.Email = model.Email;
                    customer.RezervationId = rezervation.ID;
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    TempData["message"] = "Your rezervation has been created!";
                }
                else
                    TempData["message"] = "An unexpected situation has occurred. Try again later!";
                return RedirectToAction("index");
            }
            else
                return View(model);
        }
    }
}