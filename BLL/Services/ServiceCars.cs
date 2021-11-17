using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ServiceCars : IServiceCars
    {
        public ServiceCars(
            //IDataContext dataContext
            )
        {

        }

        public IEnumerable<Car> GetSomeThing()
        {
            return null;
        }
    }
}
