using System;

// Classe simples que representa um produto
internal class Product
{
    // Nome do produto
    public string Name { get; set; }

    // Preço do produto
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    // Retorna uma string amigável para exibir o produto
    public override string ToString()
    {
        return $"{Name} - R$ {Price:F2}";
    }
}
