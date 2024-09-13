namespace DesignPatterns.Behavioral.ChainOfResponsibility.Banks;

public abstract class BankBase
{
    protected BankBase _nextBank;

    public void SetNextBank(BankBase bank)
    {
        _nextBank = bank;
    }

    public abstract void Pay(CreditCard creditCard);
}
