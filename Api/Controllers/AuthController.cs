using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        #region [Attributes & Constructor]

        private readonly IUnitOfWork _unitOfWork;

        public AuthController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion [Attributes & Constructor]

        #region [Routes]

        [HttpPost]
        public async Task<IActionResult> Post(string username, string password)
        {
            try
            {
                var token = await _unitOfWork.AuthService.Authenticate(username, password);

                if (token == null) return Unauthorized();

                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex });
            }
        }

        #endregion [Routes]
    }
}