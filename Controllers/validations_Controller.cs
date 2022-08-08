using Microsoft.AspNetCore.Mvc;
using validation_model.Models;

public class validation_Controller : Controller{
    [HttpGet("")]
    public IActionResult index(){
        return View("index");
    }

    [HttpPost("/result")]
    public IActionResult result(validation userInfo){
        if(ModelState.IsValid){ //*in the ModelState.IsValid we are saying that  if the   the model stat is valid the render the result page  else render the index page
            return View("result",userInfo);
        }
        return index();

    }
}