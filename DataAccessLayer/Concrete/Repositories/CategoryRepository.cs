using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;

        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();   // sil ve kaydet
        
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();  //değişikleri veri tabanına kaydetmek için kullandık
        }

        public List<Category> List()
        {
            return _object.ToList();  //objecten gelen ifadeleri listeleyeceksin:)
        }

        public void Update(Category p)
        {
            c.SaveChanges();  //değişikleri direk kaydettik.
        }
    }
}


/*
 ToList     listeleme için
Add        ekleme için
Remove     silme için
find          bulma için kullanılan metotlar
*/