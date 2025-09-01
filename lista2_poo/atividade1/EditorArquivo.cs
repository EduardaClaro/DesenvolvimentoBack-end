using System.Diagnostics.Contracts;

public class EditorArquivo
{
    // Atributos
    private string Nome; 
    private string Conteudo;
    private int Tamanho;

    // Construtor
    public EditorArquivo(string nome)
    {
        this.Nome = nome ?? throw new ArgumentNullException(nameof(nome)); // Usa 'this' e verifica null
        Conteudo = "";
        Tamanho = 0;
    }

    // Métodos
    public void Open() // Alterado para void
    {
        Console.WriteLine(Nome);
        Console.WriteLine(Conteudo);
        Console.WriteLine(Tamanho);
    }

    public void Edit(string newContent) // Alterado para void
    {
        Conteudo += newContent;
        Tamanho = Conteudo.Length * 8;
    }

    public bool Rename(string newName)
    {
        if (newName == null)
            return false;

        Nome = newName;
        return true;
    }

    public void Clear()
    {
        Conteudo = "";
        Tamanho = 0;
    }
}