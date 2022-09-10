using Microsoft.EntityFrameworkCore;
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

        public async Task AddArticleAsync(Article article)
        {
            await _context.Articles.AddAsync(article);
            await _context.SaveChangesAsync();
        }

        public async Task<Article?> GetArticleByIdAsync(Guid id)
        {
            return await _context.Articles.SingleOrDefaultAsync(a => a.Id == id);
        }

        public IEnumerable<Article>? GetArticlesByNameAsync(string namePart, int count)
        {
            var articles = _context.Articles
                .Where(a => a.Name.Contains(namePart))
                .OrderBy(a => a.Name)
                .Take(count);
            return articles;
        }
    }
}
