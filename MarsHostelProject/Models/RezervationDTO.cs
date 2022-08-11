using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarsHostelProject.Models
{
    public class RezervationDTO
    {

        public int RoomId { get; set; }
        [Required(ErrorMessage = "FirstName cannot be empty!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName cannot be empty!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please choise a FirstDate")]
        public DateTime FirstDate { get; set; }
        [Required(ErrorMessage = "Please choise a LastDate")]
        public DateTime LastDate { get; set; }
        [Required(ErrorMessage = "Please enter your PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter your EmailAddress")]
        public string Email { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal
        {
            get
            {
                return Quantity * Price;
            }
        }
    }
}