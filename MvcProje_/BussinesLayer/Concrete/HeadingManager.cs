using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class HeadingManager : IHeadingService 
    {
        IHeadingDal _headingDal;
        ICategoryDal _categoryDal;

        public HeadingManager(IHeadingDal heading)
        {
            _headingDal = heading;
            

        }

        public Heading GetByID(int id)
        {
            return _headingDal.Get(x => x.HeadingID == id);
        }
      

        public List<Heading> GetList()
        {

           //var ca = _headingDal.List(x => x.CategoryID == x.CategoryID);

            return _headingDal.List(x => x.CategoryID == 2);

           
        }

        public void HeadingAddBL(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void HeadingDelete(Heading heading)
        {
            _headingDal.Delete(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
