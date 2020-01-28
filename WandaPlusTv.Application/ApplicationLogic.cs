using System;
using System.Collections.Generic;
using WandaPlusTv.Application.Contracts;
using WandaPlusTv.Domain;

namespace WandaPlusTv.Application
{
    public class ApplicationLogic : IApplicationLogic
    {
        public ICollection<Movie> Browse(Genre genre = null, Category category = null)
        {
            throw new NotImplementedException();
        }

        public ICollection<Movie> Search(string  keyWord)
        {
            throw new NotImplementedException();
        }
    }
}
