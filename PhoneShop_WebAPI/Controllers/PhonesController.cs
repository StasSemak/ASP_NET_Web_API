using BussinesLogic.DTOs;
using BussinesLogic.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders.Physical;

namespace PhoneShop_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhonesController : Controller
    {
        private readonly IPhoneService phoneService;

        public PhonesController(IPhoneService phoneService)
        {
            this.phoneService = phoneService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await phoneService.GetAllAsync());
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            var phone = await phoneService.GetByIdAsync(id);

            if (phone == null) return BadRequest();

            return Ok(phone);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PhoneDto phone)
        {
            if (!ModelState.IsValid) return BadRequest();

            await phoneService.CreateAsync(phone);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] PhoneDto phone)
        {
            if (!ModelState.IsValid) return BadRequest();

            await phoneService.EditAsync(phone);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await phoneService.DeleteAsync(id);
            return Ok();
        }
    }
}
