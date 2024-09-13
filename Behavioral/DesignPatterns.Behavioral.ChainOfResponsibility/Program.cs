using DesignPatterns.Behavioral.ChainOfResponsibility.Banks;

ABank aBank = new();
BBank bBank = new();
CBank cBank = new();

aBank.SetNextBank(bBank);
bBank.SetNextBank(cBank);

aBank.Pay(new CreditCard("Test Test", "2345 1234 1234 1234", 10, 24));