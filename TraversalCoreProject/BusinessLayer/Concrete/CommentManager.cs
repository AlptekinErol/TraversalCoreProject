using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentdal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentdal = commentdal;
        }

        
        public List<Comment> GetCommentsWithDestination()
        {
           return  _commentdal.GetCommentsWithDestination();
        }

        public void TAdd(Comment entity)
        {
           _commentdal.Create(entity);
        }

        public void TDelete(Comment entity)
        {
           _commentdal.Delete(entity);
        }

        public Comment TGetById(int id)
        {
           return _commentdal.GetListId(id);
        }

        public List<Comment> TGetCommentListWithDestinationAndUser(int id)
        {
           return _commentdal.GetCommentListWithDestinationAndUser(id);
        }

        public List<Comment> TGetDestinationById(int id)
        {
          
            return _commentdal.GetListByFilter(x => x.DestinationID == id);
            
        }

        public List<Comment> TGetList()
        {
            return _commentdal.GetList();
        }

        public void TUpdate(Comment entity)
        {
            _commentdal.Update(entity);
        }
    }
}
