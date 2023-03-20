namespace Clases;

class Clases
{
    static void Main(string[] args){
        Hello? Hello = new();
        Hello.ExampleMethod();

        Hello = null; //matamos la instancia y le quitamos la meria o con el metodo "dispose";
        //pero no es necesario;
    }

    /*
        el metodos Main puede recibir parametros y esto es por 
        medio de "string[] args", por eso se pone mas no es necesario 
        si no va a mandar parametros 

        podemos hacer que nuestro proyecto retorne un codigo de estado 
        para eso debemos cambiar el void por un int en el Main
    */
}

class Hello
{
    //Atributos, Miembros 
    //Campos (Fields, Variables)
    string Example = "Hello Words";

    //Propiedades 
    //Permiten encapsular campos 

    //Metodos 
    //Difinen el compaoramiento que un objeto
    //¿Que es lo que la clase puede hacer?
    public void ExampleMethod(){
        Console.WriteLine(Example);
    }

    //Eventos
    //Acciones que pueden notidicar un objeto

    //Elementos Staticos 
    //ELementos que pueden ser utilizardos sin requir una instancia 
    //Viven en la clase y no en el objeto

}