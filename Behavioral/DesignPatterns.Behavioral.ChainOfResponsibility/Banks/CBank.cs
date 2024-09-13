namespace DesignPatterns.Behavioral.ChainOfResponsibility.Banks;

public class CBank : BankBase
{
    private readonly HashSet<string> _bins = ["3456", "3457", "3458"];

    public override void Pay(CreditCard creditCard)
    {
        if (_bins.Any(creditCard.Number.StartsWith))
        {
            Console.WriteLine("Payment was withdrawn from bank c.");
        }
        else
        {
            _nextBank?.Pay(creditCard);
        }
    }
}
