namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get; set; } // set the variables to a property
        public int ProductId { get; set; }     // set the variables to a property
        public int Amount { get; set; }        // set the variables to a property

        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            // assigning values to their corrosponding properties
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;
        }
        public Product Product { get; set; } = new(0, "None", 0);
    }
}