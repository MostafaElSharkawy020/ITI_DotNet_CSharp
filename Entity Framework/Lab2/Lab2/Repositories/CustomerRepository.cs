using Lab2.Data;
using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Repositories
{
    internal class CustomerRepository
    {
        public MovieRentalSystemContext Context;
        public CustomerRepository()
        {
            Context = new MovieRentalSystemContext();
        }
        public List<Customer> GetAll()
        {
            return Context.Customers.ToList();
        }

        public void Add(Customer entity)
        {
            Context.Customers.Add(entity);
            Context.SaveChanges();
        }
        public void Update()
        {
            Context.SaveChanges();
        }
        public void Delete(Customer entity)
        {
            Context.Customers.Remove(entity);
            Context.SaveChanges();
        }

        public static bool ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidatePhone(string phone)
        {
            return phone.All(char.IsDigit);
        }
    }
}
