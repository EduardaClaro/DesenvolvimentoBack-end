public class ContaBancaria
{
  // Atributos
  public int Numero;
  public string Titular;
  private double Saldo;

  // Construtor
  public ContaBancaria(int numero, string titular)
  {
    Numero = numero;
    Titular = titular;
    Saldo = 0.0; // 0.0 só está forçando ser double (poderia ser só 0)
  }

  // Metodos
  public bool Depositar(int numero, double valor)
  {
    if (Numero != numero || valor <= 0)
      return false;

    Saldo += valor;
    return true;
  }

  public bool Sacar(int numero, double valor)
  {
    if (Numero != numero || Saldo < valor || valor <= 0) // Aqui está estipulando 3 "regras" para o sistema
      return false;

    Saldo -= valor;
    return true;
  }

  // ToString - é uma representação textual do meus atributos
  public override string ToString()
  {
    return $"Numero: {Numero}\nTitular: {Titular}\nSaldo: {Saldo}";
  }

}