namespace Cats.BusinessObjects.Interfaces.GetCats;

public interface IGetCatsController
{
    Task<List<Cat>> GetCatsAsync();
}