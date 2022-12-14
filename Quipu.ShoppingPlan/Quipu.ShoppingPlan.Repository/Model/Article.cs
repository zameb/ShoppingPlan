namespace Quipu.ShoppingPlan.Repository.Model
{
    public class Article
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Unit { get; set; } = default!;

        public virtual IEnumerable<Category> Categories { get; set; } = default!;
    }
}
