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
    public class AboutManager : IAboutService
    {
        private IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About t)
        {
            _aboutDal.Insert(t);
        }

        public void Delete(About t)
        {
            _aboutDal.Delete(t);
        }

        public void Update(About t)
        {
            _aboutDal.Update(t);
        }

        public List<About> GetList()
        {
            return _aboutDal.GetList();
        }

        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
