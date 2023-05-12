namespace Entity
{
    public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }
    public int PaymentId { get; set; }
    private List<OrderDetail> OrderDetails { get; set; }

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

    public void CheckOut()
    {
        // Checkout logic
    }

    public void CancelOrder()
    {
        // Cancel order logic
    }
}
}