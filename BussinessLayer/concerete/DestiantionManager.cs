using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.concerete
{
    public class DestiantionManager : IDestinationService
    {
        IDestinationDal _destinationDal;
        private EfDestinationsDal efDestinationsDal;

        public DestiantionManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public DestiantionManager(EfDestinationsDal efDestinationsDal)
        {
            this.efDestinationsDal = efDestinationsDal;
        }

        public void TAdd(Destination t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destination t)
        {
            throw new NotImplementedException();
        }

        public Destination TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();
        }

        public void TUpdate(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}
