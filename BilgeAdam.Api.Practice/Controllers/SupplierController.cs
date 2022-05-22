using BilgeAdam.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.Api.Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService service;

        public SupplierController(ISupplierService service)
        {
            this.service = service;
        }

        [HttpGet("list")]
        public IActionResult GetAllSuppliers()
        {
            var result = service.GetAllSuppliers();
            return Ok(result);
        }
    }
}

// https://localhost:7000/api/supplier/list