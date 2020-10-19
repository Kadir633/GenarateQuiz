using GenerateQuiz.BUSINESS.Abstract;
using GenerateQuiz.DAL.Abstract;
using GenerateQuiz.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GenerateQuiz.BUSINESS.Concrete
{
    public class QuizManager : IQuizService
    {
        private IQuizDal _QuizDal;
        public QuizManager(IQuizDal QuizDal)
        {
           _QuizDal  = QuizDal;
        }

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create(Question entity)
        {
            _QuizDal.Create(entity);
        }

        public void Delete(Question entity)
        {
              _QuizDal.Delete(entity);
        }

        public List<Question> GetAll(Expression<Func<Question, bool>> filter = null)
        {
            return _QuizDal.GetAll();
        }

        public Question GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Question GetOne(Expression<Func<Question, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Question entity)
        {
            throw new NotImplementedException();
        }

        public bool Validate(Question entity)
        {
            throw new NotImplementedException();
        }
    }
}
