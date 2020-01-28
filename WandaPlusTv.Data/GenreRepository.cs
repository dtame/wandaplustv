using System;
using System.Data;
using System.Linq;
using WandaPlusTv.Domain;
using System.Collections.Generic;
using WandaPlusTv.Data.Contracts;
using Dapper.Contrib.Extensions;

namespace WandaPlusTv.Data
{
    public class GenreRepository : IGenreRepository
    {
        private readonly IDbConnection _connection;
        public GenreRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<Genre> GetAll()
        {
            return _connection.GetAll<Genre>().ToList();
        }
        public Genre Get(int id)
        {
            return _connection.Get<Genre>(id);
        }
        public Genre Create(Genre genre)
        {
            try
            {

                genre.Id = (int)_connection.Insert(genre);
            }
            catch (Exception ex)
            {
                return null;
            }
            return genre;
        }

        public bool Delete(Genre genre)
        {
            try
            {
                return _connection.Delete(genre);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Genre genre)
        {
            try
            {
                return _connection.Update(genre);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }

}
