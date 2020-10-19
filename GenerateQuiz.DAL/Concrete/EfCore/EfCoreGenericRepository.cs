using GenerateQuiz.DAL.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GenerateQuiz.DAL.Concrete.EfCore
{
    public class EfCoreGenericRepository<T, QuizContext> : IRepository<T>
     where T : class
     where QuizContext : DbContext, new()
    {
        public void Create(T entity)
        {
            using (var context = new QuizContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }


        public void Delete(T entity)
        {
            using (var context = new QuizContext())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

 

        public virtual List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new QuizContext())
            {
                return filter == null
                         ? context.Set<T>().ToList()
                         : context.Set<T>().Where(filter).ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context = new QuizContext())
            {
                return context.Set<T>().Find(id);
                ;
            }
        }

        public T GetOne(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            using (var context = new QuizContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
