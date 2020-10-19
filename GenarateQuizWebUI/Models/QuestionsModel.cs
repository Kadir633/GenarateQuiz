using GenerateQuiz.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenarateQuizWebUI.Models
{
    public class QuestionsModel
    {
        public ICollection<Question> Questions { get; set; }
    }
}
