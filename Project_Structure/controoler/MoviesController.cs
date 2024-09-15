using Microsoft.AspNetCore.Mvc;

namespace Project_Structure.controoler
{
    public class MoviesController : Controller
    {
        public IActionResult GetMovie(int id)
        {
            ContentResult result = new ContentResult();
            result.Content = $"Movies with id {id}";
           // result.ContentType = "object/pdf";
            return result;
            
        }
        public string Index()
        {
            return "Hello From Index";
        }

        
    }
}
