using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TIendaPalma.Commands.Product;
using TIendaPalma.Dtos.Product;
using TIendaPalma.Queries.Product;

namespace TiendaPalma.Api.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllProducts()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _mediator.Send(new GetProductById() { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProduct product)
        {
            return Ok(await _mediator.Send(product));
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateProduct product)
        {
            return Ok(await _mediator.Send(product));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            await _mediator.Send(new RemoveProduct() { Id = id });

            return Ok();
        }

    }
}
