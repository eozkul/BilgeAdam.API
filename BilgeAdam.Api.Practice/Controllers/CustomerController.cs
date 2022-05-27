using BilgeAdam.Common.Dtos;
using BilgeAdam.Data.Context;
using BilgeAdam.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.Api.Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;

        public CustomerController(ICustomerService service)
        {
            this.service = service;
        }
        [HttpGet("list")]
        public IActionResult GetPagedCustomer([FromQuery]int count,[FromQuery] int page)
        {
            var result=service.GetPagedCustomer(count, page);
            return Ok(result);
        }
        [HttpGet("get/{id}")]
        public IActionResult GetById([FromRoute] string id)
        {
            var result = service.GetById(id);
            if (result is null)
            {
                return BadRequest("Bu id de bir ürün bulunamadı.");
            }
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Create([FromBody]CustomerAddDto dto)
        {
            var result=service.CustomerAddNew(dto);
            if (!result)
            {
                return BadRequest();
            }
            return Ok("Eklendi.");
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete([FromRoute]string id)
        {
            var result = service.DeleteCustomer(id);
            if (!result)
            {
                return BadRequest("Bu id de bir ürün bulunamadı.");
            }
            return Ok("Silindi.");
        }
    }
}
