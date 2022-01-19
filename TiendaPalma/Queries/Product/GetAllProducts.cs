using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIendaPalma.Dtos.Product;

namespace TIendaPalma.Queries.Product
{
    /// <summary>
    /// Query to get all products
    /// </summary>
    public class GetAllProducts : IRequest<List<ProductOutputDto>>
    {
    }
}
