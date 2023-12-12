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
    public class InstructorsController : ControllerBase
    {
        IInstructorService _instructorService;
        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateInstructorRequest createInstructorRequest)
        {
            await _instructorService.Add(createInstructorRequest); return Ok();
        }
        [HttpGet("GetList")]
        public async Task<IActionResult> GetList()
        {
            var result = await _instructorService.GetListAsync();
            return Ok(result);
        }
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateInstructorRequest updateInstructorRequest)
        {
            var result = await _instructorService.UpdateAsync(updateInstructorRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteAsync([FromBody] DeleteInstructorRequest deleteInstructorRequest)
        {
            var result = await _instructorService.DeleteAsync(deleteInstructorRequest);
            return Ok(result);
        }
    }
}
