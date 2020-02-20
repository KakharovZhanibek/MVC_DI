using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Injection.Models;

namespace MVC_Injection.Implementation
{
    public class RepositoryExcel : IRepository
    {
        public void Add(City city)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> AllCities()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public City FindById(int id)
        {
            return new City { Id = 1, IsCapital = true, Name = "Astana", Population = 900000 };
        }

        public IEnumerable<City> FindByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}