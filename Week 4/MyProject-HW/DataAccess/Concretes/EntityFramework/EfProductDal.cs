using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //IDisposable pattern implemantation of C#
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(entity);  //Versionlara göre değişiklik gösterebilir kontrol et
                context.SaveChanges();


            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var existingEntity = context.Products.Find(entity.ProductId);

                if (existingEntity != null)
                {

                    context.Products.Remove(existingEntity);
                    context.SaveChanges();
                }



            }

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);

            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();

            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                context.Entry(entity).State = EntityState.Modified;


                context.SaveChanges();
            }
        }
    }
}
