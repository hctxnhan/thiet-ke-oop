namespace Entity
{
    public class OrderDetail
{
    public int Id { get; set; }
    public Order Order { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
}