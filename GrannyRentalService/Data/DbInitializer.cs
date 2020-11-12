using GrannyRentalService.Models;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace GrannyRentalService.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GrannyRentalContext context) //För att få detta att fungera när vi lämnar in den bör vi faktiskt sätta upp en testdatabas... Läs om varför 
        {                                                           //det inte är lämpligt att ladda upp mdf till github.

            context.Database.EnsureCreated();

            if (context.Grannies.Any())
            {
                return;
            }

            Granny[] grannies = new Granny[]
            {
                new Granny{ID = Guid.NewGuid(), FirstName = "Agda", LastName = "Nilsson", Age = 82, HourlyRate = 9},
                new Granny{ID = Guid.NewGuid(), FirstName = "Stella", LastName = "Gustavsson", Age = 73, HourlyRate = 8},
                new Granny{ID = Guid.NewGuid(), FirstName = "Alfhild", LastName = "Stålnacke", Age = 65, HourlyRate = 9},
                new Granny{ID = Guid.NewGuid(), FirstName = "Tekla", LastName = "Rosenström", Age = 69, HourlyRate = 10},
                new Granny{ID = Guid.NewGuid(), FirstName = "Solveig", LastName = "Lindquist", Age = 77, HourlyRate = 11},
                new Granny{ID = Guid.NewGuid(), FirstName = "Asta", LastName = "Ahl", Age = 82, HourlyRate = 9},
                new Granny{ID = Guid.NewGuid(), FirstName = "Maud", LastName = "Persson", Age = 75, HourlyRate = 8},
                new Granny{ID = Guid.NewGuid(), FirstName = "Margareta", LastName = "Bigum", Age = 72, HourlyRate = 10}
            };
            foreach (Granny g in grannies)
            {
                context.Grannies.Add(g);
            }
            context.SaveChanges();

            User[] users = new User[]
            {
                new User{ID = Guid.NewGuid().ToString(), FirstName="Svante", LastName = "Svensson", Password = "abc123"},
                new User{ID = Guid.NewGuid().ToString(), FirstName="Anders", LastName = "Lindh", Password = "123abc"},
                new User{ID = Guid.NewGuid().ToString(), FirstName="Thomas", LastName = "Axelsson", Password = "a1b2c3"},
                new User{ID = Guid.NewGuid().ToString(), FirstName="Johan", LastName = "Sparrman", Password = "1a2b3c"},
                new User{ID = Guid.NewGuid().ToString(), FirstName="Jonathan", LastName = "skarp", Password = "cba321"},
                new User{ID = Guid.NewGuid().ToString(), FirstName="Nils", LastName = "Ohlsson", Password = "321cba"},
                new User{ID = Guid.NewGuid().ToString(), FirstName="Per", LastName = "Andersson", Password = "3c2b1a"},
                new User{ID = Guid.NewGuid().ToString(), FirstName="Åke", LastName = "Johansson", Password = "xxxxxx"}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
            Booking[] bookings = new Booking[]
            {
                new Booking{ID = Guid.NewGuid(), GrannyID = grannies[3].ID, UserID = users[3].ID, From = DateTime.Parse("19/11/2020 15:00:00"), To = DateTime.Parse("19/11/2020 19:00:00"), TotalCost = grannies[3].HourlyRate*4} //DateTime-fel!
            };
            foreach (Booking b in bookings)
            {
                context.Bookings.Add(b);
            }
            context.SaveChanges();
        }
    }
}
