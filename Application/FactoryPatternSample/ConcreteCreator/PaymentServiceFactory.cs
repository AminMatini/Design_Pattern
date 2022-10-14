using Application.FactoryPatternSample.ConcreteProduct;
using Application.FactoryPatternSample.InterfaceProduct;

namespace Application.FactoryPatternSample.ConcreteCreator;

public class PaymentServiceFactory
{
    public enum ServicesAvailable
    {
        Italian = 0,
        Brazilian
    }

    public IPaymentService Create(ServicesAvailable operation)
    {
        IPaymentService result;
        if (operation == ServicesAvailable.Italian)
            result = new ItalianPaymentService();
        else
            result = new BrazilianPaymentService();
        return result;
    }
}