using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Injection.Models;

namespace MVC_Injection.Implementation
{
    public class RepositoryMSSQL : IRepository
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
            return new City { Id = 3, IsCapital = true, Name = "Singapoure", Population = 11900000 };
        }

        public IEnumerable<City> FindByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}