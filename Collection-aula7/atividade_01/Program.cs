Product [] products = new Product[5];

products[0]= new Product("Collant",300.90);
products[1]= new Product("Meia-Calça",59.99);
products[2]= new Product("Enfeite Coque",25.00);
products[3] = new Product("Sapatilha de couro", 110.50);
products[4]= new Product("Sapatilha de Ponta", 250.00);

Product maior = products[0];

for (int i=0; i<products.Length;i++)
{
  if (products[i].Price > maior.Price)
  maior = products[i];
}

Product menor = products[0];

for (int i=0;i<products.Length;i++)
{
  if (products[i].Price < menor.Price && !products[i].Name.Equals(maior.Name))
  menor = products[i];
}

Console.WriteLine("Qual o maior e o menor produto em valor?");
Console.WriteLine(maior);
Console.WriteLine(menor);