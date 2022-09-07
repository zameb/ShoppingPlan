namespace Quipu.ShoppingPlan.Repository.Model
{
    public class ShoppingList
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public Guid ShoppingTemplateId { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual IEnumerable<ShoppingListItem> Details { get; set; } = default!;
    }
}
