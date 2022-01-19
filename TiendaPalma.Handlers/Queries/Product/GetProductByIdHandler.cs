using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TIendaPalma.Data;
using TIendaPalma.Dtos.Product;
using TIendaPalma.Queries.Product;

namespace TiendaPalma.Handlers.Queries.Product
{
    class GetProductByIdHandler : BaseProductHandler, IRequestHandler<GetProductById, ProductOutputDto>
    {
        public GetProductByIdHandler(IMapper mapper, IProductRepository repo) : base(mapper, repo)
        {
        }

        public async Task<ProductOutputDto> Handle(GetProductById request, CancellationToken cancellationToken)
        {
            return GetProductOutput(_repo.Get(request.Id));        }
    }
}
