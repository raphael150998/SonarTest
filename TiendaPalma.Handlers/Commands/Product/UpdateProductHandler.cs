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
    class UpdateProductHandler : BaseProductHandler, IRequestHandler<UpdateProduct, ProductOutputDto>
    {
        public UpdateProductHandler(IMapper mapper, IProductRepository repo) : base(mapper, repo)
        {
        }

        public async Task<ProductOutputDto> Handle(UpdateProduct request, CancellationToken cancellationToken)
        {
            TIendaPalma.Models.Product productDb = _repo.Get(request.Id);

            productDb.Name = request.Name;
            productDb.Price = request.Price;
            productDb.Quantity = request.Quantity;

            _repo.Update(productDb);

            return GetProductOutput(productDb);
        }
    }
}
