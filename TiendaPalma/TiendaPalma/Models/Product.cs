using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIendaPalma.Models
{
    /// <summary>
    /// Product model for db
    /// </summary>
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTimeOffset.Now;
        }

        /// <summary>
        /// Identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// unit price of product
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// Quantity in stock of product
        /// </summary>
        public int Quantity { get; set; }
    }
}
