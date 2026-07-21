namespace FluentBuilder;

public class OrderBuilder
{
    private int _number;
    private DateTime _createdOn;
    private readonly AddressBuilder _addressBuilder = AddressBuilder.Empty();

    private OrderBuilder()
    {
    }

    public static OrderBuilder Empty() => new();

    public OrderBuilder WithNumber(int number)
    {
        _number = number;
        return this;
    }

    public OrderBuilder CreatedOn(DateTime createdOn)
    {
        _createdOn = createdOn;
        return this;
    }

    public OrderBuilder ShipTo(Action<AddressBuilder> builder)
    {
        builder(_addressBuilder);
        return this;
    }

    public Order Build()
    {
        return new Order()
        {
            Number = _number,
            CreatedOn = _createdOn,
            ShippingAddress =  _addressBuilder.Build()
        };
    }
}