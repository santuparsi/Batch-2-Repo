using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //controller actions
        [HttpGet,Route("GetStudents")]
        public IActionResult GetStudents()
        {
            try
            {
                string[] s = { "Rohan", "Nihal", "Manoj" };
                return StatusCode(200, s);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
                
            }
        }
        [HttpGet,Route("GetStudent/{id}")]
        public IActionResult GetStudent(int id)
        {
            try
            {
               
                return StatusCode(200, "Monish");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }
        [HttpPost,Route("AddStudent")]
        public IActionResult Add(object student)
        {
            try
            {

                return StatusCode(200, "Added Monsih");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }
    }
}
