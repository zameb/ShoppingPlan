namespace Quipu.ShoppingPlan.Repository.Model
{
    public class ShoppingTemplate
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;

        public virtual IEnumerable<Article> Articles { get; set; } = default!;
    }
}
