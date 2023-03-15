using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testiMonialDal;

        public TestimonialManager(ITestimonialDal testiMonialDal)
        {
            _testiMonialDal = testiMonialDal;
        }

        public void TAdd(Testimonial t)
        {
            _testiMonialDal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testiMonialDal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _testiMonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testiMonialDal.GetList();
        }

        public List<Testimonial> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial t)
        {
            _testiMonialDal.Update(t);
        }
    }
}
