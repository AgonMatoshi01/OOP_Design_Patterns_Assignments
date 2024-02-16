class Program
{
    static void Main(string[] args)
    {
        IPaymentGatewayFactory paypalFactory = new PayPalGatewayFactory();
        IPaymentGateway paypalGateway = paypalFactory.CreateGateway();
        paypalGateway.ProcessPayment(100.50);

        IPaymentGatewayFactory stripeFactory = new StripeGatewayFactory();
        IPaymentGateway stripeGateway = stripeFactory.CreateGateway();
        stripeGateway.ProcessPayment(75.25);
    }
}
