namespace Quipu.ShoppingPlan.Repository.Model
{
    public class ShoppingListItem
    {
        public Guid UserId { get; set; }
        public int ItemNumber { get; set; }
        public Guid ShoppingListId { get; set; }
        public Guid ArticleId { get; set; }
        public decimal Quantity { get; set; }
        public bool IsPurchased { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
