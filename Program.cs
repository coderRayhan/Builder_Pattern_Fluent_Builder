// See https://aka.ms/new-console-template for more information

using FluentBuilder;

Console.WriteLine("Hello, World!");

var order = OrderBuilder.Empty()
    .WithNumber(10)
    .CreatedOn(DateTime.Now)
    .ShipTo(a => a
        .Street("Street")
        .City("City")
        .Zip("Zip")
        .Country("Country"))
    .Build();
    
    Console.WriteLine(order);
    
    