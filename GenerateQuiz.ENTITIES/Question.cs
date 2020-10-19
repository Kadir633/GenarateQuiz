using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GenerateQuiz.ENTITIES
{
    [Display(Name ="Question")]
   public  class Question
    {
        public int Id { get; set; }

        public string Link { get; set; }
        public string Baslik { get; set; }

        public string Selection1 { get; set; }
        public string A1 { get; set; }
        public string B1 { get; set; }
        public string C1 { get; set; }
        public string D1 { get; set; }
        public string CorrectAnswer1 { get; set; }
        /// <summary>
        /// ///////
        /// </summary>
        public string Selection2 { get; set; }
        public string A2 { get; set; }
        public string B2 { get; set; }
        public string C2 { get; set; }
        public string D2 { get; set; }
        public string CorrectAnswer2 { get; set; }
        /// <summary>
        /// //////
        /// </summary>
        public string Selection3 { get; set; }
        public string A3 { get; set; }
        public string B3 { get; set; }
        public string C3 { get; set; }
        public string D3 { get; set; }
        public string CorrectAnswer3 { get; set; }
        /// <summary>
        /// //////////////
        /// </summary>
        public string Selection4 { get; set; }
        public string A4 { get; set; }
        public string B4 { get; set; }
        public string C4 { get; set; }
        public string D4 { get; set; }
        public string CorrectAnswer4 { get; set; }
    }
}
