namespace DemoEventos; //=>agrupamiento logico o emsamblado logico 

delegate void ErrorEventHandler(object sender, ErrorEventArgs e); 
//A los eventos se les manda dos objetos de parametros
//  - sender hace referencia a quien es el publicador, osea el obejto mismo
//  - un tipo donde se puedan pasar los datos el evento que generalmente es de tipo EventArgs 
//      en este caso crearemos una clase que derive de esta para meter los datos el evento como el mensaje

class BankAccountDelegateEvent
{
    decimal CurrentBalance;

    public event ErrorEventHandler OnError; //Creamos un evento de tipo ErrorEventHandler de nomber
                                            // OnError

    public decimal Withdraw(decimal amount)
    {
        if(CurrentBalance >= amount)
        {
            CurrentBalance -= amount;
            if(CurrentBalance == 0)
            {
                if(OnError != null){
                    var Sender = this; //Hacemos referencial al objeto
                    var EventData = new ErrorEventArgs
                    {
                        Message = "EL sado es 0", 
                        Severity = 0
                    };
                    OnError(Sender, EventData);
                }
                    
            }
        }else{
            if(OnError != null){
                    var Sender = this; //Hacemos referencial al objeto
                    var EventData = new ErrorEventArgs
                    {
                        Message = "NO tienes saldo", 
                        Severity = 10
                    };
                    OnError(Sender, EventData);
                }
        }

        return CurrentBalance;
    }

    public decimal Deposit(decimal amount)
    {
        CurrentBalance += amount;
        return CurrentBalance;
    }
}
