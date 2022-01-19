using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIendaPalma.Data
{
    /// <summary>
    /// This interface base repo makes easy other repo's creation
    /// </summary>
    public interface IBaseRepository<TKey, TEntity>
    {
        /// <summary>
        /// Add a record
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Add(TEntity entity);

        /// <summary>
        /// Update a record
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Update(TEntity entity);

        /// <summary>
        /// remove a record by its key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        void Remove(TKey key);

        /// <summary>
        /// Get a record by its key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        TEntity Get(TKey key);

        /// <summary>
        /// Get all records from entity
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();
    }
}
