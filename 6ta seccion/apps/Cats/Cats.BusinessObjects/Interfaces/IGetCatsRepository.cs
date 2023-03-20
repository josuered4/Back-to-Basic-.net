namespace Cats.BusinessObjects.Interfaces.GetCats;

public interface IGetCatsRepository
{

    Task<List<Cat>> GetCatsAsync();
    //Caundo se trabaja con metodos asyncronos se debe de 
    //retornar una tarea y dentro de ella el dato a retornar 
    //Task es una clase para identificar metodos asyncronos 
    //Agregar el subfijo "Async" en el nombre de la funcion 

    //Los repositorios dan datos y no validan datos, se 
    //recomienda no retornar lo que el repositorio nos de 
    //debemos usar otra herramienta que nos ayude a implementar 
    //algun tipo de logica, example "user autenticate"
    //hacemos referencia al interactor que es otra interfaz

}

/*
* En la programacion de hoy en dia se programa 
* de forma asincrona, es decir trae los datos 
* y cuando los tengas me avisas.
*
* Programacion SIncrona es cuando esperas a 
* que te den los datos 
*/

//ACTION => ES UN DELEGADO 