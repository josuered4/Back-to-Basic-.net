namespace DemoEventos; 

class Program
{
    static void Main()
    {
        /*BankAccount Account = new  BankAccount(); //creo una variable BankAccount y guardo la direccion
        decimal CurrentBalance = Account.Deposit(1000);
        CurrentBalance = Account.Withdraw(200);
        Console.WriteLine($"Saldo {CurrentBalance}");*/


        /*
        BankAccountDelegate Account = new  BankAccountDelegate(); //creo una variable BankAccount y guardo la direccion
        
        //Implementacion de Delegate 
        Account.ErrorEventHandlerDelegate = NotifyBalance; 
        Account.ErrorEventHandlerDelegate += NotifyBalance2; //se concatena la segunda funcion 
        Account.ErrorEventHandlerDelegate += LocalMethod;

        decimal CurrentBalance = Account.Deposit(1000);
        CurrentBalance = Account.Withdraw(1000);
        Console.WriteLine($"Saldo {CurrentBalance}");*/

        void LocalMethod(string message){
            Console.WriteLine("Es un metodo local");
        }


        BankAccountDelegateEvent Account = new  BankAccountDelegateEvent(); //creo una variable BankAccount y guardo la direccion
        
        //Implementacion de Delegate para el evento, "FOmra de suscripcion"
        Account.OnError += new BankAccount_OnEror;

        decimal CurrentBalance = Account.Deposit(1000);
        CurrentBalance = Account.Withdraw(1000);
        Console.WriteLine($"Saldo {CurrentBalance}");
    }

    //Se recomienda poner el nombre del objeto_nombre de evnto 
    static void BankAccount_OnEror(Object sender, ErrorEventArgs e){
        Console.WriteLine($"Error: {e.Message}, SEveridad {e.Severity}");
    }
}

//Cuando se compila un proyecto se crea un emsamblado 
