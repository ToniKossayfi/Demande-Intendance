namespace Warehouse.Models; 

public class HomeItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Category { get; set; }
    public bool IsEditing { get; set; } = false;
}