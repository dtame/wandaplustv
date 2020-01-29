using WandaPlusTv.Domain;
using System.Collections.Generic;

namespace WandaPlusTv.Data.Contracts
{
    public interface IGenreRepository
    {
        List<Genre> GetAll();
        Genre Get(int id);
        Genre Create(Genre genre);
        bool Delete(Genre genre);
        bool Update(Genre genre);
    }

}
