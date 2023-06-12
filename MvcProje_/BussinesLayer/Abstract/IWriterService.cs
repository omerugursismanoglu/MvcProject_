using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        void WriterAddBL(Writer writer);
        Writer GetByID(int id);

        void WriterDelete(Writer writer);
        void WriterUpdate(Writer writer);
    }
}
