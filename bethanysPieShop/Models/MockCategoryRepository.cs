namespace bethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => 
            new List<Category> 
            {
                new Category {CategoryId =1, CategoryName = "Fruit pies", Description = "All-fruit pies" },
                new Category {CategoryId =2, CategoryName = "Cheese cakes", Description = "Cheese all the way" },
                new Category {CategoryId =3, CategoryName = "Seasonal pies", Description = "Get on the moodfor a seasonal pie" }
            };
    }
}
