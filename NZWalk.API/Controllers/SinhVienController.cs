using Microsoft.AspNetCore.Mvc;


namespace NZWalk.API.Controllers
{
    //https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        //https://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[]
            {
                "John", "Jane", "June"
            };
            return Ok(studentNames);
        }
    }
}
