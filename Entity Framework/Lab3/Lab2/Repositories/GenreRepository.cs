using Lab2.Data;
using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Repositories
{
    class GenreRepository
    {
        public MovieRentalSystemContext Context;
        public GenreRepository()
        {
            Context = new MovieRentalSystemContext();
        }
        public List<Genre> GetAll()
        {
            return Context.Genres.ToList();
        }

        public void Add(Genre entity)
        {
            Context.Genres.Add(entity);
            Context.SaveChanges();
        }
        public void Update()
        {
            Context.SaveChanges();
        }
        public void Delete(Genre entity)
        {
            Context.Genres.Remove(entity);
            Context.SaveChanges();
        }
    }
}
