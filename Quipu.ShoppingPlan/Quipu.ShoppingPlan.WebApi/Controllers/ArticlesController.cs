using Microsoft.AspNetCore.Mvc;
using Quipu.ShoppingPlan.Repository;
using Quipu.ShoppingPlan.WebApi.Model;

namespace Quipu.ShoppingPlan.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticlesRepository _articlesRepository;

        public ArticlesController(IArticlesRepository articlesRepository)
        {
            _articlesRepository = articlesRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticleResponse>>> GetArticlesByName(string name)
        {
            var articles = await _articlesRepository.GetArticlesByNameAsync(name);
            if (articles != null)
            {
                var articlesResponseList = new List<ArticleResponse>();
                foreach (var article in articles)
                {
                    articlesResponseList.Add(
                        new ArticleResponse
                        {
                            Id = article.Id,
                            Name = article.Name
                        });
                }
                return articlesResponseList;
            }
            return new EmptyResult();
        }
    }
}
