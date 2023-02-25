class Program
{
    static void Main()
    {
        Console.WriteLine("Hello Word");
        var Cuadrado = new Square();
        Cuadrado.Side = 23;
        Console.WriteLine(Cuadrado.Side);

        Cuadrado.Num = 10;
        Console.WriteLine(Cuadrado.Num);
    }
}

class Square
{
    //Aqui van los Campos, Métodos, Propiedades y Eventos.
    //Campos(Fields)
    private decimal Side_BackingField; //=> las clases deben ser privados por defaul

    //Propiedades 
        //MEtodos especiales que no ayudan a proteger nuestros campos de las clases
        //que consumen de esta clase.
    public decimal Side //=> la definicion es similar a la declaracion de una variable
    {
        set{ Side_BackingField = value; }//Asigna valor al BackingField
        get{ return Side_BackingField; }
    }

    //propiedades 
    //Aun se requiere el BackingField, aunque no lo pongamos
    //el compilador implementa un campo para esta propiedad e implementa 
    //esta propiedad
    public decimal Side2{get; private set;}
    //get publico y get provado
    public void SetSide2Value(decimal d){
        Side2 = d; //asi se le pasaria el salor al set
    }

    public decimal Side3{get;} //=> Solo en el contructor puede y debe ser inicializado 

    //Campo
    private decimal Area_BF;
    //propiedad de solo lectura 
    public decimal Area
    {
        get{return Area_BF;}
    }


    //Campo 
    private int Num_BF;
    public int Num
    {
        set{
            if(value < 5)
                Num_BF = value;
            else
                Num = 0;
        }
        get{return Num_BF;}
    }
}