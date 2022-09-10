using Quipu.ShoppingPlan.Repository.Model;

namespace Quipu.ShoppingPlan.Repository.EfRepository
{
    public class ArticlesRepository : IArticlesRepository
    {
        private readonly ShoppingPlanContext _context;

        public ArticlesRepository(ShoppingPlanContext context)
        {
            _context = context;
        }

        public Task AddArticleAsync(Article article)
        {
            throw new NotImplementedException();
        }

        public Task<Article?> GetArticleByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Article>?> GetArticlesByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
