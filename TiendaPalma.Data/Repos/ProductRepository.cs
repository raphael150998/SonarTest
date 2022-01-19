using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIendaPalma.Data;
using TIendaPalma.Models;

namespace TiendaPalma.Data.Repos
{
    public class ProductRepository : BaseRepository<string, Product>, IProductRepository
    {
        public ProductRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
