namespace Cadastro;

public class Cliente
{
    public int id { get; set; }
    public string nome { get; set; }
    public DateOnly dataNascimento { get; set; }
    public DateTime cadastradoEm { get; set; }
    public decimal desconto { get; set; }


}