using Cats.BusinessObjects.Entities;
using Cats.BusinessObjects.Interfaces.GetCats;

namespace Cats.Repository;
public class GetCatsRepositoryFake : IGetCatsRepository
{
    public Task<List<Cat>> GetCatsAsync()
    {
        return Task.FromResult(new List<Cat>());
    }
}

// Se debe hacer una referencia a la otra liberia de clases 
//que tiene las interfaces 