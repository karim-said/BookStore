using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastucture.Context;

namespace BookStore.Infrastucture.Repositories
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(BookStoreDbContext context):base(context) { }
    }
}
