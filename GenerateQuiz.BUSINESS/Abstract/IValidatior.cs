using System;
using System.Collections.Generic;
using System.Text;

namespace GenerateQuiz.BUSINESS.Abstract
{
   public interface IValidatior<T>
    {
         string ErrorMessage { get; set; }

        bool Validate(T entity);
    }
}
