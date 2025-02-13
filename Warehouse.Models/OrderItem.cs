namespace Warehouse.Models;

public class OrderItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Category { get; set; }
    public bool IsSelected { get; set; } = false;
    public int OrderQuantity { get; set; } = 0;
}