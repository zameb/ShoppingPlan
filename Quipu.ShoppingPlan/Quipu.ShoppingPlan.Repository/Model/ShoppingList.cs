namespace Quipu.ShoppingPlan.Repository.Model
{
    public class ShoppingList
    {
        public Guid Id { get; set; }
        public bool IsPurchased { get; set; }

        public virtual IEnumerable<Article> Articles { get; set; } = default!;
    }
}
