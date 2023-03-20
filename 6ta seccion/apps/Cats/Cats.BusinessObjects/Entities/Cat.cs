namespace Cats.BusinessObjects.Entities
{
    //Si vas a esponer datos utiliza propiedades utiliza propiedades 
    // si es para uso interno usa campos 
    public class Cat 
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public decimal BasePrice {get; set;}
        public string ImageUrl {get; set;}
    }
    //Campos son simples varibales
    //Las propiedades nos ayudan a trabajar y encapsular nuestros campos 
    //no es necesario asignarle un campo a las propiedades ya crean uno por default 

    //public string Name {get; set;} Crea el campo y le implementa las propiedades por default


}