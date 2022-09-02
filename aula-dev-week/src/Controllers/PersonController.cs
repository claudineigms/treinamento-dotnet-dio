using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase{
    
    [HttpGet]
    public Person Get(){
        Person pessoa = new Person();
        Contract contrato = new Contract("abc123",50.10);

        pessoa.ListContracts.Add(contrato);
        /*
        pessoa.ListContracts.Add(contrato);
        pessoa.ListContracts.Add(contrato);
        */
        return pessoa;
    }

    [HttpPost]
    public Person Post(Person pesssoa){
        return pesssoa;
    }

    [HttpPut ("{id}")]
    public string Update(int id, Person pessoa){
        Console.WriteLine(pessoa.Nome);
        Console.WriteLine(id);
        return "Dados do Id" + id + "atualizados";
    }

    [HttpDelete]
    public string Delete(int id){
        return "Deletado pessoa de Id" + id;
    } 
}