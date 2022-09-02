namespace src.Models;
using System.Collections.Generic;

public class Person
{
    public Person(){
        this.Nome = "";
        this.Idade = 0;
        this.Status = true;
        this.ListContracts = new List<Contract>();
    }
    
    //nome, idade, cpf, status      
    public int Id { get; set; }
    public string Nome  {get; set; }
    public int Idade { get; set; }

    public string? CPF { get; set; }

    public bool Status { get; set; }

    public List<Contract> ListContracts { get; set; } 
}