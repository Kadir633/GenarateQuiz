using GenerateQuiz.DAL.Abstract;
using GenerateQuiz.ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenerateQuiz.DAL.Concrete.EfCore
{
   public class EfCoreQuizDal:EfCoreGenericRepository<Question, QuizContext>, IQuizDal
    {

    }
}
