using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo
{
    public class Customer
    {
        private int Id { get; set; }
        public string ?Name { get; set; }
        public string ?Surname { get; set; }
        public string ?OpenDate { get; set; }
        public string ?Email { get; set; }
        public long ?Wealth { get; set; }

        
        public void SetId(int ID)
        {
          Id = ID;
        }

        public void GetId()
        {
            Console.WriteLine("Customer ID: " + Id);
        }

        public void ShowCustomer()
        {
            Console.WriteLine("Name: " + Name +"\nSurname: " + Surname+ "\nCustemer Email: " + Email + "\nWealth: " + Wealth + " $\nOpen Date: " + OpenDate +"\n--------------------------" );
        }

        public void AddCustomer(Customer cus)
        {
            Console.WriteLine(cus.Name + " is added succesfully");
        }

        public void DeleteCustomer(Customer cus)
        {
            Console.WriteLine(cus.Name + " is deleted!");
        }
    }
}
