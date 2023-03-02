namespace RateMyFood.MVC.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly RateMyFoodDbContext _rateMyFoodDbContext;

        public CategoryRepository(RateMyFoodDbContext rateMyFoodDbContext) 
        {
            _rateMyFoodDbContext = rateMyFoodDbContext;
        }

        public IEnumerable<Category> AllCategories => _rateMyFoodDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
