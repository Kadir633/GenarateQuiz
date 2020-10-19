using GenerateQuiz.BUSINESS.Abstract;
using GenerateQuiz.DAL.Abstract;
using GenerateQuiz.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GenerateQuiz.BUSINESS.Concrete
{
    public class UserManager : IuserService
    {


        private IuserDal _userDal;
        public UserManager(IuserDal userDal)
        {
            _userDal = userDal;
        }
        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create(User entity)
        {
            _userDal.Create(entity);
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _userDal.GetAll();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetOne(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Validate(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
