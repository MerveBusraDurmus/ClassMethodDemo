using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli müşteri eklendi.");
        }

        public void Delete (Customer customer)
        {
            Console.WriteLine("Id numarası {0} olan ürün silindi",customer.Id);
        }

        public void GetAll(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Identity +" " + customer.Name +" " + customer.Surname);
            }
            
        }
    }
}
