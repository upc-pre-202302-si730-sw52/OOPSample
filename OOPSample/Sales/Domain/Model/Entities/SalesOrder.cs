namespace OOPSample.Sales.Domain.Model.Entities;

public class SalesOrder
{
    private List<SalesOrderItem> _items;
    public SalesOrder(int id)
    {
        Id = id;
        _items = new List<SalesOrderItem>();
    }

    private int Id { get; }
    
    public void AddItem(int productId, int quantity)
    {
        _items.Add(new SalesOrderItem(Id, productId, quantity));
    }
}