namespace src.Models;

public class Contract{
    public Contract(){
        this.DataCriacao = DateTime.Now;
        this.Valor = 0;
        this.TokenId = "000000";
        this.Payed = false;
    }

    public Contract(string TokenId,double valor){
        this.DataCriacao = DateTime.Now;
        this.TokenId = TokenId;
        this.Valor = valor;
        this.Payed = false;
    }
    public int Id{ get; set; }
    public DateTime DataCriacao { get; set; }
    public string TokenId { get; set; }
    public double Valor { get; set; }
    public bool Payed{get; set;}
    public int PersonId {get;set;}
}