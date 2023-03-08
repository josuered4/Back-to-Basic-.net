//Para crear nuestro propio tipo de
//EvenArgs, como hereda de este 
//ya solo es de poner lo que necesitamos
public class ErrorEventArgs : EventArgs
{
    public string Message { get; set;}
    public byte Severity {get; set;}
}