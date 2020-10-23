using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCoreMovieApp.Models
{
    public class CategoryRepository
    {
        private static List<Category> _category = null;
        static CategoryRepository()
        {
            _category = new List<Category>()
            {
                new Category(){Id=1,Name = "Bilim Kurgu"},
                new Category(){Id=2,Name = "Macera"},
                new Category(){Id=3,Name = "Komedi"},
                new Category(){Id=4,Name = "Gerilim"},
                new Category(){Id=5,Name = "Korku"},

            };
        }

        public static List<Category> Categories {
            get {
                return _category;
            }
        }

        public static void AddCategory(Category entity)
        {
            _category.Add(entity);
        }

        public static Category GetById(int id)
        {
            return _category.FirstOrDefault(x => x.Id == id);
        }
    }
}
