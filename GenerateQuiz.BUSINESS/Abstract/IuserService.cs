using GenerateQuiz.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GenerateQuiz.BUSINESS.Abstract
{
   public interface IuserService: IValidatior<User>
    {
        User GetById(int id);
        User GetOne(Expression<Func<User, bool>> filter);
        List<User> GetAll(Expression<Func<User, bool>> filter = null);

        void Create(User entity);
        void Update(User entity);
        void Delete(User entity);
    }
}
