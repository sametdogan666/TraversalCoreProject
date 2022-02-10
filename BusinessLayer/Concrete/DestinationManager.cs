using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void Add(Destination t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Destination t)
        {
            throw new NotImplementedException();
        }

        public void Update(Destination t)
        {
            throw new NotImplementedException();
        }

        public List<Destination> GetList()
        {
            return _destinationDal.GetList();
        }

        public Destination GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
