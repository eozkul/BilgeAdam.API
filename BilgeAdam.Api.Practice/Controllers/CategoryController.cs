using BilgeAdam.Common.Dtos;
using BilgeAdam.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.Api.Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService service;

        public CategoryController(ICategoryService service)
        {
            this.service = service;                
        }
        [HttpGet("list")]
        public IActionResult GetPagedCategories([FromQuery]int count, [FromQuery] int page)
        {
            var result = service.GetPagedCategories(count,page);
            return Ok(result);
        }
        [HttpGet("get/{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            var result = service.GetCategoryById(id);
            if (result is null)
            {
                return BadRequest("Bu id de bir veri bulunamadı");
            }
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Create([FromBody]CategoryAddDto dto)
        {
            var result = service.AddNewCategory(dto);
            if (!result)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Remove([FromRoute] int id)
        {
            var result = service.RemoveCategory(id);
            if (!result)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
