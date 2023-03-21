namespace Cats.Repository;
public class GetCatsRepositoryFake : IGetCatsRepository
{
    //async => especifica una operacion asincrona
    public async Task<List<Cat>> GetCatsAsync()
    {
        List<Cat> Cats = new List<Cat>
        {
            new Cat
            {
                Id = 1,
                Name = "Bengala", 
                Description = "Es un gato", 
                BasePrice = 1000, 
                ImageUrl = "hola"
            },
            new Cat
            {
                Id = 2,
                Name = "Bengalas", 
                Description = "Es un gatos", 
                BasePrice = 2000, 
                ImageUrl = "hola"
            }
        };
        return await Task.FromResult(Cats);
        //await => lanza un nuevo hilo para que ejecute este proceso 
        //cuando termina, notifica al hilo principal para seguir con el 
        //funcionamiento 
    }
}

// Se debe hacer una referencia a la otra liberia de clases 
//que tiene las interfaces 

//Recordar: Repository solo es para traer datos
//aca va el codigo para traer datos.