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
    class GetAllProductsHandler : BaseProductHandler, IRequestHandler<GetAllProducts, List<ProductOutputDto>>
    {
        public GetAllProductsHandler(IMapper mapper, IProductRepository repo) : base(mapper, repo)
        {
        }

        public async Task<List<ProductOutputDto>> Handle(GetAllProducts request, CancellationToken cancellationToken)
        {
            List<TIendaPalma.Models.Product> products = _repo.GetAll().ToList();

            return _mapper.Map<List<ProductOutputDto>>(products);
        }
    }
}
