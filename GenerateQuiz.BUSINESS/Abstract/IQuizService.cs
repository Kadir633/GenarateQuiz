using GenerateQuiz.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GenerateQuiz.BUSINESS.Abstract
{
   public interface IQuizService:IValidatior<Question>
    {
        Question GetById(int id);
        Question GetOne(Expression<Func<Question, bool>> filter);
        List<Question> GetAll(Expression<Func<Question, bool>> filter = null);

        void Create(Question entity);
        void Update(Question entity);
        void Delete(Question entity);
    }
}
