using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;


namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
         }

        public Category GetCategoryById(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> GetListAllCategory()
        {
            return _categoryDal.GetListAll();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);  
        }
    }
}
