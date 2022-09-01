using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase{

    [HttpGet]
    public string Hello(){
        Person pessoa = new Person();
        return pessoa;
        return "Ola Mundo!!";
    }
}