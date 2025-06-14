﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        ICommentDal __CommentDal;
        public CommentManager(ICommentDal commentDal)
        {
            __CommentDal = commentDal;
        }
        public void TAdd(Comment t)
        {
            __CommentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            throw new NotImplementedException();
        }
        public List<Comment> TGetDestinationByID(int id)
        {
            return __CommentDal.GetListByFilter(x => x.DestinationID == id);
        }
        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
