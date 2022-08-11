namespace MarsHostelProject.Migrations
{
    using MarsHostelProject.Models.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MarsHostelProject.Models.Context.MarsHostelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MarsHostelProject.Models.Context.MarsHostelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            if (!context.Rooms.Any())
            {
                List<Room> rooms = new List<Room>()
                {
                    new Room{ID = 1, NumberOfPeople=1, Price = 10, ImagePath="/Content/images/rooms/singlerooms.jpg", Description = "Daily housekeeping, paid breakfast, all-day reception,air conditioning,laundry,luggage locker, single bed"},
                    new Room{ID = 2, NumberOfPeople=1, Price = 10, ImagePath="/Content/images/rooms/singlerooms.jpg", Description = "Daily housekeeping, paid breakfast, all-day reception,air conditioning,laundry,luggage locker, single bed"},
                    new Room{ID = 3, NumberOfPeople=1, Price = 10, ImagePath="/Content/images/rooms/singlerooms.jpg", Description = "Daily housekeeping, paid breakfast, all-day reception,air conditioning,laundry,luggage locker, single bed"},
                    new Room{ID = 4, NumberOfPeople=2, Price = 30, ImagePath="/Content/images/rooms/doublerooms.jpg", Description = "Daily housekeeping, paid breakfast, all-day reception,air conditioning,laundry,luggage locker, double bed"},
                    new Room{ID = 5, NumberOfPeople=2, Price = 30, ImagePath="/Content/images/rooms/doublerooms.jpg", Description = "Daily housekeeping, paid breakfast, all-day reception,air conditioning,laundry,luggage locker, double bed"},
                    new Room{ID = 6, NumberOfPeople=2, Price = 30, ImagePath="/Content/images/rooms/doublerooms.jpg", Description = "Daily housekeeping, paid breakfast, all-day reception,air conditioning,laundry,luggage locker, double bed"},
                    new Room{ID = 7, NumberOfPeople=3, Price = 50, ImagePath="/Content/images/rooms/tripplerooms.jpg", Description = "Daily housekeeping, paid breakfast, all-day reception,air conditioning,laundry,luggage locker, double bed + single bed"},
                    new Room{ID = 8, NumberOfPeople=3, Price = 50, ImagePath="/Content/images/rooms/tripplerooms.jpg", Description = "Daily housekeeping, paid breakfast, all-day reception,air conditioning,laundry,luggage locker, double bed + single bed"},
                    new Room{ID = 9, NumberOfPeople=3, Price = 50, ImagePath="/Content/images/rooms/tripplerooms.jpg", Description = "Daily housekeeping, paid breakfast, all-day reception,air conditioning,laundry,luggage locker, double bed + single bed"}
                };

                foreach (var item in rooms)
                {
                    context.Rooms.Add(item);
                    context.SaveChanges();
                }
            }
        }
    }
}
