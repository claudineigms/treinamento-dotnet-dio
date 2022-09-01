namespace src.Models;

public class Person
{
    public Person(){
        this.nome = "";
        this.idade = 0;
        this.status = true;
    }
    
    //nome, idade, cpf, status
    public string nome  {get; set; }
    public int idade { get; set; }

    public string? cpf { get; set; }

    public bool status { get; set; }
}