using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIendaPalma.Commands.Product
{
    /// <summary>
    /// Command to remove a product
    /// </summary>
    public class RemoveProduct : IRequest
    {
        /// <summary>
        /// Id of product to be removed
        /// </summary>
        public string Id { get; set; }
    }
}
