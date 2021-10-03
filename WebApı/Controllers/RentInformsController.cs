using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentInformsController : ControllerBase
    {
        IRentInformService _rentInformService;

        public RentInformsController(IRentInformService rentInformService)
        {
            _rentInformService = rentInformService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentInformService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getrentinformid")]
        public IActionResult GetRentInformId(int rentInformId)
        {
            var result = _rentInformService.GetRentInformById(rentInformId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(RentInform rentInform)
        {
            var result = _rentInformService.Add(rentInform);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(RentInform rentInform)
        {
            var result = _rentInformService.Delete(rentInform);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Update(RentInform rentInform)
        {
            var result = _rentInformService.Update(rentInform);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
