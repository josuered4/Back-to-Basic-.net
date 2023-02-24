namespace Clases;

class Clases
{
    static void Main(string[] args){
        if(args.Count()>0)
            Console.WriteLine(args[0]);
        else
            Console.WriteLine("Sin Parametros");
    }
}

//dotnet run "HEllo World"
//Asi de pasa con parametros 