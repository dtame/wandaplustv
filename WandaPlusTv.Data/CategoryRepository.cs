using System;
using System.Data;
using System.Linq;
using WandaPlusTv.Domain;
using System.Collections.Generic;
using WandaPlusTv.Data.Contracts;
using Dapper.Contrib.Extensions;
using Dapper;

namespace WandaPlusTv.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDbConnection _connection;

        public CategoryRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        
        public List<Category> GetAll()
        {
            return _connection.GetAll<Category>().ToList();  
        }
        public Category Get(int id)
        {
            return _connection.Get<Category>(id);
        }
        public Category Create(Category category)
        {
            try
            {
                category.Id = _connection.Query<int>($"INSERT INTO [Category] ([Name])VALUES ({category.Name});SELECT CAST(SCOPE_IDENTITY() as int)").First();
            }
            catch(Exception ex)
            {
                return null;
            }
            return category;
        }

        public bool Delete(Category category)
        {
            try
            {
                return _connection.Delete(category);
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool Update(Category category)
        {
            try
            {
                return _connection.Update(category);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
