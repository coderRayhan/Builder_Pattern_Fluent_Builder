namespace FluentBuilder;

public class Order
{
    public int Number { get; set; }
    public DateTime CreatedOn { get; set; }
    public Address ShippingAddress { get; set; }
}