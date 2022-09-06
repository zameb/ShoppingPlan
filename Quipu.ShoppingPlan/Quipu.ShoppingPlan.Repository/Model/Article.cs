namespace Quipu.ShoppingPlan.Repository.Model
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;

        public virtual IEnumerable<Tag> Tags { get; set; } = default!;
    }
}
