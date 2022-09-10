using Quipu.ShoppingPlan.Repository.Model;

namespace Quipu.ShoppingPlan.Repository
{
    public interface IArticlesRepository
    {
        public Task<Article?> GetArticleByIdAsync(Guid id);
        public Task<IEnumerable<Article>?> GetArticlesByNameAsync(string namePart, int count);
        public Task AddArticleAsync(Article article);
    }
}
