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

namespace TiendaPalma.Handlers.Commands.Product
{
    class RemoveProductHandler : BaseProductHandler, IRequestHandler<RemoveProduct>
    {
        public RemoveProductHandler(IMapper mapper, IProductRepository repo) : base(mapper, repo)
        {
        }

        public async Task<Unit> Handle(RemoveProduct request, CancellationToken cancellationToken)
        {
            _repo.Remove(request.Id);
            return new Unit();
        }
    }
}
