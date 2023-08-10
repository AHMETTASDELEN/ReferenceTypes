using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(); //burada customer sınıfı ile new yaptığımızda alttaki blok çalışır
            customer1.Id = 1;
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.City = "Ankara";

            Customer customer2 = new Customer {Id=2, FirstName="Ahmet", LastName="Taşdelen", City="Sakarya" };

            Customer customer3 = new Customer(3, "Berkay", "Bilgin", "İstanbul");

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer3.FirstName);
        }
    }
    class Customer 
    {
        public Customer()
        {

        }

        //default constructor - bu blok yazılsada yazılmasada arka planda çalışır, 
        //varsa bizim yazdığımız yoksa arka planda çalışır  
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
