using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIendaPalma.Models;

namespace TIendaPalma.Data
{
    public interface IProductRepository : IBaseRepository<string, Product>
    {
    }
}
