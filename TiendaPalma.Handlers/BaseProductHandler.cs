using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIendaPalma.Data;
using TIendaPalma.Dtos.Product;
using TIendaPalma.Models;

namespace TiendaPalma.Handlers
{
    internal abstract class BaseProductHandler
    {
        protected readonly IMapper _mapper;
        protected readonly IProductRepository _repo;

        protected BaseProductHandler(IMapper mapper, IProductRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        protected ProductOutputDto GetProductOutput(Product product)
        {
            return _mapper.Map<ProductOutputDto>(product);
        }
    }
}
