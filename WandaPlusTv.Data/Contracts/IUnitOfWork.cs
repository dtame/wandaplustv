using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WandaPlusTv.Domain;

namespace WandaPlusTv.Data.Contracts
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categories { get; }
        IGenreRepository Genres { get; }
    }
}
