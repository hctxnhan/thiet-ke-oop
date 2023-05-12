namespace Entity
{
    public class Cart
{
    public int Id { get; set; }
    public User User { get; set; }
    private List<CartDetail> CartDetails { get; set; }

    public void RemoveProduct(int productId)
    {
        // Remove product logic
    }

    public void AddProduct(int productId, int quantity)
    {
        // Add product logic
    }

    public void UpdateProduct(int productId, int quantity)
    {
        // Update product logic
    }

    public decimal GetTotalPrice()
    {
        // Calculate total price logic
        return 0.0m;
    }

    public int GetTotalQuantity()
    {
        // Calculate total quantity logic
        return 0;
    }

    public void ClearCart()
    {
        // Clear cart logic
    }
}
}