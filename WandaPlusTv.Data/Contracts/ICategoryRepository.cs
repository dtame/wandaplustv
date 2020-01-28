using WandaPlusTv.Domain;
using System.Collections.Generic;

namespace WandaPlusTv.Data.Contracts
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category Get(int id);
        Category Create(Category genre);
        bool Delete(Category genre);
        bool Update(Category genre);
    }

}
