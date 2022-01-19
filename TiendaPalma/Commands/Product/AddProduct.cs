using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIendaPalma.Dtos.Product;

namespace TIendaPalma.Commands.Product
{
    /// <summary>
    /// Command to add a new product
    /// </summary>
    public class AddProduct : IRequest<ProductOutputDto>
    {
        /// <summary>
        /// Name of product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price per unit of product
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Quantity in stock of product
        /// </summary>
        public int Quantity { get; set; }
    }
}
