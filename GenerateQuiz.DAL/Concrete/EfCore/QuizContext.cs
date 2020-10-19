using GenerateQuiz.ENTITIES;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenerateQuiz.DAL.Concrete.EfCore
{
   public class QuizContext:DbContext
    {
        public DbSet<Question> Question { get; set; }
        public DbSet<User> Admin { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=QDb");
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2A1NM9C;Initial Catalog=ShopDb;Integrated Security=True");
        //}
    }
}
