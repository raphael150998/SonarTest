using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TIendaPalma.Dtos.Product;

namespace TIendaPalma.Queries.Product
{
    /// <summary>
    /// Query to get single product by its id
    /// </summary>
    public class GetProductById : IRequest<ProductOutputDto>
    {
        public string Id { get; set; }
    }
}
