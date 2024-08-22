namespace OOPSample.Sales.Domain.Model.Aggregates;

public enum ESalesOrderStatus
{
    Cancelled,
    PendingForPayment,
    ReadyForShipping,
    Shipped,
    Completed
}