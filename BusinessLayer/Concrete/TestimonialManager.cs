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
    public class TestimonialManager : ITestimonialService
    {
        private ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public Testimonial GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.GetList();
        }

        public void Update(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
