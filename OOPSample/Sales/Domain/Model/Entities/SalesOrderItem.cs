namespace OOPSample.Sales.Domain.Model.Entities;

public class SalesOrderItem
{
    public SalesOrderItem(int salesOrderId, int productId, int quantity)
    {
        SalesOrderId = salesOrderId;
        ProductId = productId;
        Quantity = quantity;
        Id = 0;
    }

    public int Id { get; set; }
    public int SalesOrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    
    
}