namespace DemoEventos; //=>agrupamiento logico o emsamblado logico 
class BankAccount
{
    decimal CurrentBalance;

    public decimal Withdraw(decimal amount)
    {
        if(CurrentBalance >= amount)
        {
            CurrentBalance -= amount;
        }

        return CurrentBalance;
    }

    public decimal Deposit(decimal amount)
    {
        CurrentBalance += amount;
        return CurrentBalance;
    }
}
  