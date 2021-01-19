using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.name = "Furkan";
            customer1.surname = "Simsek";
            customer1.age = 26;
            customer1.ID = "12485785649";

            Customer customer2 = new Customer();
            customer2.name = "Caner";
            customer2.surname = "Jannisary";
            customer2.age = 23;
            customer2.ID = "98598654211";

            Customer customer3 = new Customer();
            customer3.name = "Kani";
            customer3.surname = "Mardinli";
            customer3.age = 22;
            customer3.ID = "12312314581";

            Customer customer4 = new Customer();
            customer4.name = "Baran";
            customer4.surname = "Ozan";
            customer4.age = 16;
            customer4.ID = "10060728475";

            Customer[] customers = new Customer[] { customer1,customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Delete(customer3);
            customerManager.Delete(customer4);
            customerManager.List(customers);


            //Console.WriteLine("----------------silme işleminden sonra kalan müşteriler----------------");

 
        }
    }
}
