using Application.FactoryPatternSample.Enums;
using Application.FactoryPatternSample.InterfaceProduct;

namespace Application.FactoryPatternSample.ConcreteProduct;

public class BrazilianPaymentService : IPaymentService
{
    public string EmailToCharge { get; set; } = null!;
    public decimal MoneyToCharge { get; set; }
    public EnumChargingOptions OptionToCharge { get; set; }

    public bool ProcessCharging()
    {
        Console.WriteLine("This payment will be processed by Brazilian Service.");
        Console.WriteLine($"Person: {EmailToCharge}");
        Console.WriteLine($"Price: R$ {MoneyToCharge:0.00}");
        Console.WriteLine($"Option: {OptionToCharge}");
        Console.WriteLine("");
        return true;
    }
}
