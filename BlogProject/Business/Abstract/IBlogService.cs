using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(Blog blog);
        List<Blog> GetListAllBlog();
        Blog GetBlogById(int id);
        List<Blog> GetBlogListWithCategory();  
    }
}
