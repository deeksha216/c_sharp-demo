using System;


namespace PaymentSystem
{

    interface IPayment
    {
        void MakePayment(double amount);
    }


    class CreditCardPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine(amount);

        }
    }


    class PayPalPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine(amount);

        }
    }


    class UPIPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine( amount);

        }
    }


    class program
    {
        static void Main(string[] args)
        {
            IPayment creaditcard = new CreditCardPayment();
            IPayment paypal = new PayPalPayment();
            IPayment upi = new UPIPayment();


            double amount = 2500.00;
          Console.WriteLine("using creid card");
            creaditcard.MakePayment(amount);
            Console.WriteLine("using paypal");
            creaditcard.MakePayment(amount);
            Console.WriteLine("using upi");
            upi.MakePayment(amount);
        }
    }
}
