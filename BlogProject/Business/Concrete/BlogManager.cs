using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Blog GetBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListWithCategory()
        {
           return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetListAllBlog()
        {
            return _blogDal.GetListAll();

        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
