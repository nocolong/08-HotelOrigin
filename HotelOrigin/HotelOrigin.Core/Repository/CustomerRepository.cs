using HotelOrigin.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrigin.Core.Repository
{
    public class CustomerRepository
    {
        private static ObservableCollection<Customer> customers = new ObservableCollection<Customer>();

        //Create
        public static Customer Create()
        {
            Customer customer = new Customer();

            customers.Add(customer);

            return customer;
            
        }
        public static void Add(Customer customer)
        {
            customers.Add(customer);
        }
        //Read
        public static Customer GetById(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }
        public static ObservableCollection<Customer> GetAll()
        {
            return customers;
            
        }

        //Update

        //Delete
        public static void Delete(int id)
        {
            var customer = GetById(id);

            customers.Remove(customer);
        }
        public static void Delete(Customer customer)
        {
            customers.Remove(customer);
        }
    }
}
