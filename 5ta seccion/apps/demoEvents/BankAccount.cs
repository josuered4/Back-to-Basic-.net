public delegate void ErrorEventHandler(object sender, ErrorEventArgs e);  
//tenemos el delegado especial para poder aplicar los eventos con dos param
// object : quien publica el evento, por eso es object
// eventArgs o deruvado, para pasar informacion los datos del evento

//Para el delegado del evento se recomienda el subfijo "EventHandler"

class BankAccount
{
    decimal CurrentBalance;

    public event ErrorEventHandler? OnError;
    //ya no se requier de una propiedad de tipo delegate 
    // ahora usaremos eventos con la sig sintaxis.
    // event + tipeEvent + NameEvent

    public decimal Withdraw(decimal amount)
    {
        if(CurrentBalance >= amount)
        {
            CurrentBalance -= amount;
            if(CurrentBalance == 0)
            {
                if(OnError != null)
                {
                    var Sender = this; //En una varible referenciamos el objeto actual 

                    var EventData = new ErrorEventArgs{
                        Message = "El sado actual es de 0",
                        Severity = 0
                        //Creamos una instacia de nuestros EventArgs
                    };
                    OnError(Sender, EventData);
                }
            }
        }else{
            if(OnError != null){
                var Sender = this; //En una varible referenciamos el objeto actual 

                var EventData = new ErrorEventArgs{
                    Message = "Sin saldo disponible",
                    Severity = 10
                    //Creamos una instacia de nuestros EventArgs
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

    public void ThereEvent()
    {
        if(OnError != null)
            Console.WriteLine("Existe un evento...");
        else
            Console.WriteLine("No Existe un evento...");
    }
}