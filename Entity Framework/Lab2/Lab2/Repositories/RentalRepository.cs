using Lab2.Data;
using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Repositories
{
    internal class RentalRepository
    {
        public MovieRentalSystemContext Context;
        public RentalRepository()
        {
            Context = new MovieRentalSystemContext();
        }
        public List<Rental> GetAll()
        {
            return Context.Rentals.ToList();
        }

        public void Add(Rental entity)
        {
            Context.Rentals.Add(entity);
            Context.SaveChanges();
        }
        public void Update()
        {
            Context.SaveChanges();
        }
        public void Delete(Rental entity)
        {
            Context.Rentals.Remove(entity);
            Context.SaveChanges();
        }
    }
}
