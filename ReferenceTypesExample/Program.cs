using System;

namespace ReferenceTypesExample
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Id = 11;
            person1.FirstName = "Şeyma";
            person1.LastName = "Taşdelen";

            Person person2 = new Person();
            person2.Id = 22;
            person2.FirstName = "Şevval";
            person2.LastName = "Taşdelen";




            Customer customer1 = new Customer();
            customer1.Id = 33;
            customer1.CustomerId = 10;
            customer1.FirstName = "Ceren";
            customer1.LastName = "Turan";

            Customer customer2 = new Customer();
            customer2.Id = 44;
            customer2.CustomerId = 20;
            customer2.FirstName = "Özlem";
            customer2.LastName = "Ünlütürk";




            Employee employee1 = new Employee();
            employee1.Id = 55;
            employee1.EmployeeId = 30;
            employee1.FirstName = "Elmas";
            employee1.LastName = "Başkaya";

            Employee employee2 = new Employee();
            employee2.Id = 66;
            employee2.EmployeeId = 40;
            employee2.FirstName = "Samet";
            employee2.LastName = "Tarcan";


            Person person3 = employee2;

            Console.WriteLine(((Employee)person3).EmployeeId);



            Console.WriteLine(" ");
            Console.WriteLine("FINISHED");
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person
    {
        public int CustomerId { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeId { get; set; }
    }

}
