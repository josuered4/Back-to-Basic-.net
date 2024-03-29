class BankAccount
{
    decimal CurrentBalance;

    //Declaramaos una propiedad de tipo ErrorHandler 
    //La accesibilidad dependeran del programador 
    public ErrorHandler? ErrorEventHandlerDelegate{get; set;}
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


// se define un nuevo tipo de datos "ErrorHandler" de tipo delegate, es como crear una clase 
// solo podra almacenar la direccion de memoria que los metodos que retornen el mismo tipo de 
// dato y reciva la misma cantidad y tipo de parametro que el delegate
//aca no aplica la forma 
public delegate void ErrorHandler(string info); // solo almacenara funciones "void funtions(string)"
//nosotros definimos el delegado 


//Clase Cuenta de banco donde te tienen dos metodos para depositar y retirar 
//Si se trata de retirar mas de lo que se tiene se activa el delegado 