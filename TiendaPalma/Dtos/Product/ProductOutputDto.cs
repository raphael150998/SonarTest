using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIendaPalma.Dtos.Product
{
    /// <summary>
    /// output DTO for product
    /// </summary>
    public class ProductOutputDto
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Name of product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price of product
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Quantity in stock of the product
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }

    }
}
