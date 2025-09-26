using Lab2.Data;
using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Repositories
{
    class MovieRepository
    {
        public MovieRentalSystemContext Context;
        public MovieRepository()
        {
            Context = new MovieRentalSystemContext();
        }
        public List<Movie> GetAll()
        {
            return Context.Movies.ToList();
        }

        public void Add(Movie entity)
        {
            Context.Movies.Add(entity);
            Context.SaveChanges();
        }
        public void Update()
        {
            Context.SaveChanges();
        }
        public void Delete(Movie entity)
        {
            Context.Movies.Remove(entity);
            Context.SaveChanges();
        }
    }
}
