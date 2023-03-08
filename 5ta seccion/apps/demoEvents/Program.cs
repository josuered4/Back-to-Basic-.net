class DemoEventos
{
    static void Main(){
        Console.WriteLine("Hello, World!");
        BankAccount account = new();

        account.OnError += BankAccount_OnError;
        // += NameManejador //esa es la sintaxis para pasar el manejador

        account.Withdraw(4);
        
    }

    //Como se trabajara con eventos ahora debemos usar "Manejadores de Eventos", 
    //que es como un delegado especial, su sintaxis es la siguiente:
    // retorno + Name (ClassName_EventName) + (Sender, EventArgs)
    static void BankAccount_OnError(object Sender, ErrorEventArgs e)
    {
        Console.WriteLine(e.Message);
    }
     // debe tener el mismo retorno y los mismo argumentos, por que es un delegado 
    //se recomienda poner ese formato en el nombre 
}
