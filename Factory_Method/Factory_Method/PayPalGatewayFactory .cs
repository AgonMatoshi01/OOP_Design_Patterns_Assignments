using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PayPalGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreateGateway()
    {
        return new PayPalGateway();
    }
}

public class StripeGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreateGateway()
    {
        return new StripeGateway();
    }
}
