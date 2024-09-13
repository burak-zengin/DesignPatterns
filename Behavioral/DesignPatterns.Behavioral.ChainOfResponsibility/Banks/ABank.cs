namespace DesignPatterns.Behavioral.ChainOfResponsibility.Banks;

public class ABank : BankBase
{
    private readonly HashSet<string> _bins = ["1234", "1235", "1236"];

    public override void Pay(CreditCard creditCard)
    {
        if (_bins.Any(creditCard.Number.StartsWith))
        {
            Console.WriteLine("Payment was withdrawn from bank a.");
        }
        else
        {
            _nextBank?.Pay(creditCard);
        }
    }
}
