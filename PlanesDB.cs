using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Xml.Linq;

namespace Planes_CodeFirst
{
    public class PlanesDB : DbContext
    {
        public PlanesDB()
            : base("name=PlanesDB")
        {
        }
        public virtual DbSet<Airplane> Airplanes { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
    }

    public class Airplane
    {
        public Airplane()
        {
            Flights = new HashSet<Flight>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Model { get; set; }
        [Required]
        [MaxLength(100)]
        public string Type { get; set; }
        public int Capacity { get; set; }
        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return $"Model: {Model,-10} Type: {Type,-10} Capacity: {Capacity,-5} Country: {Country,-10}";
        }
    }
    public class Flight
    {
        public Flight()
        {
            Clients = new HashSet<Client>();
        }
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        public int AirplaneId { get; set; }

        public DateTime? TakeOffDate { get; set; }
        public DateTime? LandedDate { get; set; }
        [Required]
        [MaxLength(100)]
        public string Source { get; set; }
        [Required]
        [MaxLength(100)]
        public string Destination { get; set; }

        public virtual Airplane Airplane { get; set; }
        public virtual ICollection<Client> Clients { get; set; }

        public override string ToString()
        {
            return $"Number: {Number,-10} TakeOffDate: {TakeOffDate,-20} LandedDate: {LandedDate,-20} Source: {Source,-15} Destination: {Destination,-15}";
        }
    }

    public class Client { 
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Surname { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(10)]
        public string Gender { get; set; }
        public int AccountId { get; set; }
        public virtual Flight Flight { get; set; }

        public virtual Account Account { get; set; }

        public override string ToString()
        {
            return $"Name: {Name,-10} Surname: {Surname,-15} Email: {Email,-20} Gender: {Gender,-5}";
        }
    }
    public class Account
    {
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }

        public override string ToString() => $"Login: {Login,-15} Password: {Password,-15}";
    }
}