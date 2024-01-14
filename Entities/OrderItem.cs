namespace Store.Domain.Entities
{
  public class OrderItem
  {
    public OrderItem(Product product, int quantity)
    {
      Product = product;
      Price = Product != null ? product.Price : 0;
      Quantity = quantity;
    }

    public Product Product { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal Total()
    {
      return Price * Quantity;
    }
  }
}