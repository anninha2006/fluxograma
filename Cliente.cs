namespace charles;

public class Cliente
{
string Nome;
Int64 Id;
Int64 Telefone;
string CPF;
public void SetNome(string Nome)

{
    this.Nome = Nome;
}
public string GetNome()
{
    return Nome;
}
public void SetCPF(string CPF)

{
    this.CPF = CPF;
}
public string GetCPF()
{
    return CPF;
}


}