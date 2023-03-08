public delegate void ErrorHandler(string info);  //=> tenemos el delegado 

class BankAccount
{
    decimal CurrentBalance;

    //Declaramaos una propiedad de tipo ErrorHandler 
    //La accesibilidad dependeran del programador 
    public ErrorHandler ErrorEventHandlerDelegate{get; set;}
    //Podemos invicar las dirrecciones de memoria por medio de esta propiedad

    public decimal Withdraw(decimal amount)
    {
        if(CurrentBalance >= amount)
        {
            CurrentBalance -= amount;
            if(CurrentBalance == 0)
            {
                if(ErrorEventHandlerDelegate != null)
                    ErrorEventHandlerDelegate("El sado actual es de 0"); 
                    // Llamamos la dirreccion de memoria y lo ejecutamos pasando los parametros
            }
        }else{
            if(ErrorEventHandlerDelegate != null)
                ErrorEventHandlerDelegate("Sin saldo disponible"); 
        }

        return CurrentBalance;
    }

    public decimal Deposit(decimal amount)
    {
        CurrentBalance += amount;
        return CurrentBalance;
    }
}