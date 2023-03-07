// See https://aka.ms/new-console-template for more information

class DemoDelegate
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        BankAccount account = new();

        account.ErrorEventHandlerDelegate = print; //pasamos una funcion para el delegado
        account.ErrorEventHandlerDelegate += LocalMethod;
        account.ErrorEventHandlerDelegate += printTwo; //primero se ejecutara uno y despues el otro 
        // guarda la direccion de memoria de ambos metodos como si de un arrays se tratase 
        //[print, LocalMethod, printTwo]

        account.Withdraw(10);

        /*
        * Cuando cremos una instacia le pasamos el delegado o funcion que se ejectara 
        * cuando sierta condicion coincida en este caso el saldo insuficiente 
        */

        void LocalMethod(string msg){
            Console.WriteLine("Metodo local");
            Console.WriteLine(msg);
        }
    }

    static void print(string msg){
        Console.WriteLine(msg);
    }
    static void printTwo(string msg){
        Console.WriteLine(msg);
    }
}