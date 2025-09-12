Console.WriteLine("Digite um número inteiro:"); // console é uma classe estática 

try
{
  int number = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Você digitou " + number);
}
catch (Exception e) //catch - pegar o erro para ver o que está acontecendo
{
  Console.WriteLine(e.Message);
}

Console.WriteLine("Comandos após o erro");