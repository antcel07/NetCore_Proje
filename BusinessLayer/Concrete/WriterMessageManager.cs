using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager:IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public void Delete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> GetbyFilter(Expression<Func<WriterMessage, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public WriterMessage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public WriterMessage GetByID(int id)
        {
          return _writerMessageDal.GetById(id);
        }

        public List<WriterMessage> GetList()
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writerMessageDal.GetbyFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writerMessageDal.GetbyFilter(x => x.Sender == p);
        }

        public void Insert(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public void TAdd(WriterMessage t)
        {
            _writerMessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writerMessageDal.Delete(t);
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

      
        public List<WriterMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public void Update(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
