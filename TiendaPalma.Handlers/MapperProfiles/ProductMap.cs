using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIendaPalma.Dtos.Product;
using TIendaPalma.Models;

namespace TiendaPalma.Handlers.MapperProfiles
{
    public class ProductMap : Profile
    {
        public ProductMap()
        {
            CreateMap<Product, ProductOutputDto>();
        }
    }
}
