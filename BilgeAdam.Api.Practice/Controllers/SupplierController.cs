using BilgeAdam.Common.Dtos;
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
        public IActionResult GetPagedSuppliers([FromQuery]int count, [FromQuery]int page)
        {
            var result = service.GetPagedSuppliers(count,page);
            return Ok(result);
        }
        [HttpGet("get/{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            var result = service.GetSupplierById(id);
            if (result is null)
            {
                return BadRequest("Bu id de bir veri bulunamadı!");
            }
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Create([FromBody] SupplierAddDto dto)
        {
            var result = service.AddNewSupplier(dto);
            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Remove([FromRoute]int id)
        {
            var result = service.RemoveSupplier(id);
            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}

// https://localhost:7000/api/supplier/list?count=10&page=1
// https://localhost:7000/api/supplier/get/3
// https://localhost:7000/api/supplier/add