namespace Cats.BusinessObjects.Interfaces.GetCats;

public interface IGetCatsInteractor
{
    Task<List<Cat>> GetCatsInteractorAsync();
}
//Es similar al repositorio solo que aca se manipularan 
//los datos del repository

//Rository
    //Codigo de acceso a datos 
    //Codigo para regresar datos 

//Interactor
    //Codigo de logica de negocios 
    //Codigo para solucionar un problema o necesidad 
    //Example: poner la autenticacion de un usuario
    