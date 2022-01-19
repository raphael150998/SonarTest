using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TIendaPalma.Commands.Product;
using TIendaPalma.Data;
using TIendaPalma.Dtos.Product;

namespace TiendaPalma.Handlers.Commands.Product
{
    class AddProductHandler : BaseProductHandler, IRequestHandler<AddProduct, ProductOutputDto>
    {
        public AddProductHandler(IMapper mapper, IProductRepository repo) : base(mapper, repo)
        {
        }

        public async Task<ProductOutputDto> Handle(AddProduct request, CancellationToken cancellationToken)
        {
            TIendaPalma.Models.Product product = new()
            {
                Quantity = request.Quantity,
                Name = request.Name,
                Price = request.Price
            };

            _repo.Add(product);

            return GetProductOutput(product);
        }
    }
}
