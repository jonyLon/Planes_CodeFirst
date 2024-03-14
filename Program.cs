using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Planes_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PlanesDB())
            {
                //var airplane1 = new Airplane { Model = "Boeing 737", Type = "Commercial", Capacity = 189, Country = "USA" };
                //var airplane2 = new Airplane { Model = "Airbus A320", Type = "Commercial", Capacity = 160, Country = "France" };

                //var account1 = new Account { Login = "john_doe", Password = "johnpassword" };
                //var account2 = new Account { Login = "jane_doe", Password = "janepassword" };
                //var account3 = new Account { Login = "mike_smith", Password = "mikepassword" };
                //var account4 = new Account { Login = "lisa_white", Password = "lisapassword" };

                //var client1 = new Client { Name = "John", Surname = "Doe", Email = "john.doe@example.com", Gender = "M", AccountId = 1, Account = account1 };
                //var client2 = new Client { Name = "Jane", Surname = "Doe", Email = "jane.doe@example.com", Gender = "F", AccountId = 2, Account = account2 };
                //var client3 = new Client { Name = "Mike", Surname = "Smith", Email = "mike.smith@example.com", Gender = "M", AccountId = 3, Account = account3 };
                //var client4 = new Client { Name = "Lisa", Surname = "White", Email = "lisa.white@example.com", Gender = "F", AccountId = 4, Account = account4 };


                //var flight1 = new Flight
                //{
                //    Number = 1001,
                //    Airplane = airplane1,
                //    TakeOffDate = new DateTime(2024, 3, 20, 10, 0, 0),
                //    LandedDate = new DateTime(2024, 3, 20, 14, 0, 0),
                //    Source = "Kyiv, Ukraine",
                //    Destination = "Paris, France",
                //    Clients = new HashSet<Client> { client1, client2 }
                //};

                //var flight2 = new Flight
                //{
                //    Number = 2002,
                //    Airplane = airplane1,
                //    TakeOffDate = new DateTime(2024, 3, 22, 9, 0, 0),
                //    LandedDate = new DateTime(2024, 3, 22, 12, 30, 0),
                //    Source = "New York, USA",
                //    Destination = "London, UK",
                //    Clients = new HashSet<Client> { client3 }
                //};

                //var flight3 = new Flight
                //{
                //    Number = 2001,
                //    Airplane = airplane2,
                //    TakeOffDate = new DateTime(2024, 3, 22, 9, 0, 0),
                //    LandedDate = new DateTime(2024, 3, 22, 12, 30, 0),
                //    Source = "New York, USA",
                //    Destination = "London, UK",
                //    Clients = new HashSet<Client> { client4 }
                //};

                //var flight4 = new Flight
                //{
                //    Number = 2002,
                //    Airplane = airplane2,
                //    TakeOffDate = new DateTime(2024, 3, 23, 20, 0, 0),
                //    LandedDate = new DateTime(2024, 3, 24, 1, 0, 0),
                //    Source = "New York, USA",
                //    Destination = "Paris, France",
                //    Clients = new HashSet<Client>()
                //};

                //airplane1.Flights.Add(flight1);
                //airplane1.Flights.Add(flight2);
                //airplane2.Flights.Add(flight3);
                //airplane2.Flights.Add(flight4);

                //client1.Flight = flight1;
                //client2.Flight = flight1;
                //client3.Flight = flight2;
                //client4.Flight = flight3;

                //context.Clients.Add(client1);
                //context.Clients.Add(client2);
                //context.Clients.Add(client3);
                //context.Clients.Add(client4);
                //context.Accounts.Add(account1);
                //context.Accounts.Add(account2);
                //context.Accounts.Add(account3);
                //context.Accounts.Add(account4);

                //context.Airplanes.Add(airplane1);
                //context.Airplanes.Add(airplane2);
                //context.Flights.Add(flight1);
                //context.Flights.Add(flight2);
                //context.Flights.Add(flight3);
                //context.Flights.Add(flight4);
                //context.SaveChanges();

                void Print<T>(IEnumerable<T> list)
                {
                    foreach (var i in list)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine();
                }

                var flights = context.Flights;
                Print(flights);
                Print(context.Airplanes);
                Print(context.Clients);
                Print(context.Accounts);
                














            }


        }

    }
}
