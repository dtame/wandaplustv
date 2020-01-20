using System;
using System.Collections.Generic;
using System.Text;
using WandaPlusTv.Domain;

namespace WandaPlusTv.Application.Contracts
{
    public interface IApplicationLogic
    {
        ICollection<Movie> Browse(Genre genre = null, Category category = null);
        ICollection<Movie> Search(string keyWord);
    }
}
