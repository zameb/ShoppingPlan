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
        public ActionResult<IEnumerable<ArticleResponse>> GetArticlesByName(string name)
        {
            var articles = _articlesRepository.GetArticlesByNameAsync(name, 10);
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
                return new OkObjectResult(articlesResponseList);
            }
            return new EmptyResult();
        }
    }
}
