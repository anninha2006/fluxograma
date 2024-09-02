namespace Quinquim;

public class Lavagem
{
  string Nome;
  Int64 Id;
  Int64 Qt;
  string TipoTecido;
  int Modelo;
  int Capacidade;
  public void SetNome(string Nome)

{
    this.Nome = Nome;
}
public string GetNome()
{
    return Nome;
}
public void SetId(Int64 Id)

{
    this.Id = Id;
}
public Int64 GetId()
{
    return Id;
}
public void SetQt(Int64 Qt)

{
    this.Qt = Qt;
}
public Int64 GetQt()
{
    return Qt;
}
public void SetTecido(string Tecido)

{
    this.Tecido = Tecido;
}
public string GetTecido()
{
    return Tecido;
}
}