using Application.FactoryPatternSample.Enums;
using Application.FactoryPatternSample.InterfaceProduct;

namespace Application.FactoryPatternSample.ConcreteProduct;

public class ItalianPaymentService : IPaymentService
{
    public string EmailToCharge { get; set; } = null!;
    public decimal MoneyToCharge { get; set; }
    public EnumChargingOptions OptionToCharge { get; set; }

    public bool ProcessCharging()
    {
        Console.WriteLine("This payment will be processed by Italian Service.");
        Console.WriteLine($"Person: {EmailToCharge}");
        Console.WriteLine($"Price: $ {MoneyToCharge:0.00}");
        Console.WriteLine($"Option: {OptionToCharge}");
        Console.WriteLine("");
        return true;
    }
}