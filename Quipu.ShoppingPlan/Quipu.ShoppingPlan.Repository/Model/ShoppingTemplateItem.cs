namespace Quipu.ShoppingPlan.Repository.Model
{
    public class ShoppingTemplateItem
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int ItemNumber { get; set; }
        public Guid ShoppingTemplateId { get; set; }
        public Guid ArticleId { get; set; }
        public decimal DefaultQuantity { get; set; }
    }
}
