using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Mikdat";

            person2 = person1;

            person1.FirstName = "Deniz";

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Beril";
            customer.CreditCardNumber = "45645612313";

            Employee employee = new Employee();
            employee.FirstName = "Kaan";

            Person person3 = customer;
            customer.FirstName = "Ahmet";

            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);


            Console.ReadLine();
        }
    }

    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber  { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
