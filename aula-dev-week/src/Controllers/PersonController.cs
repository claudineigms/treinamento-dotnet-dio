using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Persistence;
using Microsoft.EntityFrameworkCore;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase{
    
    private DataBaseContext _context  { get; set; }

    public PersonController(DataBaseContext context){
        this._context = context;
    }

    [HttpGet]
    public ActionResult<List<Person>> GetPerson(){
        //OK - 200, NotContent 204
        /*Person pessoa = new Person();
        Contract contrato = new Contract("abc123",50.10);

        pessoa.ListContracts.Add(contrato);
        */
        
        var result =  _context.Pessoas.Include( p => p.ListContracts ).ToList();
        if (!result.Any()){
            return NoContent();
        }
        return Ok(result);
        
    }


    [HttpPost]
    public Person Post(Person pesssoa){
        _context.Pessoas.Add(pesssoa);
        _context.SaveChanges();
        return pesssoa;
    }

    [HttpPut ("{id}")]
    public string Update(int id, Person pessoa){
        _context.Pessoas.Update(pessoa);
        _context.SaveChanges();
        return "Dados do Id" + id + "atualizados";
    }

    [HttpDelete ("{id}")]
    public ActionResult<Object> Delete(int id){
        var result = _context.Pessoas.SingleOrDefault(e => e.Id == id);
       
       if (result is null){
        return BadRequest(new{
            msg = "Coneúdo inexistente, solicitação Inválida",
            staus = "400"
        }); 
       }
        
        _context.Pessoas.Remove(result);
        _context.SaveChanges();
        return Ok(new{
            status = "200",
            msg = "Id deletado com Sucesso" + id
        });
    } 

}

