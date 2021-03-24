using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Identity = "1000000000000";
            customer1.Name = "Metin";
            customer1.Surname = "Çiçek";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Identity = "1000000000001";
            customer2.Name = "Sinem";
            customer2.Surname = "Tahta";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Identity = "1000000000002";
            customer3.Name = "Selin";
            customer3.Surname = "Kiraz";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Identity = "1000000000003";
            customer4.Name = "Yiğit";
            customer4.Surname = "Duru";

            Customer customer5 = new Customer();
            customer5.Id = 5;
            customer5.Identity = "1000000000004";
            customer5.Name = "Mutlu";
            customer5.Surname = "Tan";


            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
            customerManager.Delete(customer4);
            customerManager.GetAll(customers);


        }
    }
}
