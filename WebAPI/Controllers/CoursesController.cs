using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Dtos.Requests;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest createCourseRequest)
        {
            await _courseService.Add(createCourseRequest);
            return Ok();
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseService.GetListAsync();
            return Ok(result);
        }
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateCourseRequest updateCourseRequest)
        {
            var result = await _courseService.UpdateAsync(updateCourseRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteAsync([FromBody] DeleteCourseRequest deleteCourseRequest)
        {
            var result = await _courseService.DeleteAsync(deleteCourseRequest);
            return Ok(result);
        }
    }
}
