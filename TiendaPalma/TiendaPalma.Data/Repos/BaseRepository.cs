using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TIendaPalma.Data;
using Dapper;
using DapperExtensions;

namespace TiendaPalma.Data.Repos
{
    public class BaseRepository<TKey, TEntity> : IBaseRepository<TKey, TEntity> where TEntity : class
    {
        private SqlConnection _db;

        public BaseRepository(IConfiguration configuration)
        {
            _db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public void Add(TEntity entity)
        {
            _db.Open();
            _db.Insert(entity);
            _db.Close();
        }

        public IEnumerable<TEntity> GetAll()
        {
            _db.Open();
            IEnumerable<TEntity> entities = _db.GetList<TEntity>();
            _db.Close();
            return entities;
        }

        public TEntity Get(TKey key)
        {
            _db.Open();
            TEntity entity = _db.Get<TEntity>(key);
            _db.Close();
            return entity;
        }

        public void Remove(TKey key)
        {
            _db.Open();
            var entity = _db.Get<TEntity>(key);
            _db.Delete(entity);
            _db.Close();
        }

        public void Update(TEntity entity)
        {
            _db.Open();
            _db.Update(entity);
            _db.Close();
        }
    }
}
