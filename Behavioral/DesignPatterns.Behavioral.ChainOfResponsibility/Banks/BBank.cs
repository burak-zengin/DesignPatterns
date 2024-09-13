namespace DesignPatterns.Behavioral.ChainOfResponsibility.Banks;

public class BBank : BankBase
{
    private readonly HashSet<string> _bins = ["2345", "2346", "2347"];

    public override void Pay(CreditCard creditCard)
    {
        if (_bins.Any(creditCard.Number.StartsWith))
        {
            Console.WriteLine("Payment was withdrawn from bank b.");
        }
        else
        {
            _nextBank?.Pay(creditCard);
        }
    }
}
