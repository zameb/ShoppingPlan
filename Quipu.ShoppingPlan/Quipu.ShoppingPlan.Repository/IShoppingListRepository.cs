using Quipu.ShoppingPlan.Repository.Model;

namespace Quipu.ShoppingPlan.Repository
{
    public interface IShoppingListRepository
    {
        public Task<ShoppingTemplate?> GetShoppingListByIdAsync(Guid id);
        public Task<IEnumerable<ShoppingTemplate>?> GetShoppingListsByDateAsync(DateTime? startingDate, DateTime? endingDate);
        public Task AddShoppingListAsync(ShoppingTemplate shoppingList);
    }
}
