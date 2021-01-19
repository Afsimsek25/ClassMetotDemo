using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi  --->   " + customer.name + " " + customer.surname);
            Console.WriteLine("Eklenen ID   --->   " + customer.ID);
            Console.WriteLine("-------------------------------------------------");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi   --->   " + customer.name + " " + customer.surname);
            Console.WriteLine("Silinen ID   --->   " + customer.ID);
            Console.WriteLine("-------------------------------------------------");
        }
        public void List(Customer[] customers)
        {
            Console.WriteLine("Müşteriler:");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.name + " " + customer.surname);
            }
            Console.WriteLine("-------------------------------------------------");
        }
    }

}
