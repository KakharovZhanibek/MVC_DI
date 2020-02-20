using MVC_Injection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Injection
{
    public interface IRepository
    {
        void Add(City city);
        IEnumerable<City> FindByName(string name);
        IEnumerable<City> AllCities();
        City FindById(int id);
        void Delete(int id);
    }
}
