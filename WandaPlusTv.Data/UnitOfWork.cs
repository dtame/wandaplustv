using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using WandaPlusTv.Data.Contracts;
using Dapper.Contrib.Extensions;

namespace WandaPlusTv.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IGenreRepository _genreRepository;
        private readonly ICategoryRepository _categoryRepository;
        public UnitOfWork(ICategoryRepository categoryRepository, IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
            _categoryRepository = categoryRepository;
        }

        public ICategoryRepository Categories { get { return _categoryRepository; } }
        public IGenreRepository Genres { get { return _genreRepository; } }
    }

}
