using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GenerateQuiz.ENTITIES
{
    [Display(Name = "User")]
    public class User
    {
        public int Id { get; set; }

        public string userName { get; set; }
        public string Password { get; set; }
    }
}
