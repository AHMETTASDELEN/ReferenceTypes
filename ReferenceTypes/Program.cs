using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int, decimal, floot, enum, boolean = value types(değer tipler) 
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("sayi1 : " + sayi1);


            ////arrays, class, interface.. = reference types(referans tipler)

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("sayilar1[0] : " + sayilar1[0]);


            Person person1 = new Person();
            person1.Id = 111;
            person1.FirstName = "Berkay";
            person1.LastName = "Bilgin";
            

            Person person2 = new Person();
            person2.Id = 222;
            person2.FirstName = "Engin";
            person2.LastName = "Demiroğ";


            //person2 = person1;
            //Console.WriteLine(person2.FirstName);
            

            

            Customer customer1 = new Customer();
            customer1.Id = 333;
            customer1.FirstName = "Kerem";
            customer1.LastName = "Varış";
            customer1.CreditCardNumber = 001;

            
            
            Employee employee1 = new Employee();
            employee1.Id = 444;
            employee1.FirstName = "Veli";
            employee1.LastName = "Durmuş";
            employee1.EmployeeNumber = 100;



            Person person3 = customer1;
            
            Console.WriteLine(person3.Id);
            
            Console.WriteLine(((Customer)person3).CreditCardNumber);   //boxing 


            PersonManager personManager = new PersonManager();
            personManager.Add(customer1);

           



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
        public int CreditCardNumber { get; set; }
    }
    
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager 
    {
        public void Add(Person person) 
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
