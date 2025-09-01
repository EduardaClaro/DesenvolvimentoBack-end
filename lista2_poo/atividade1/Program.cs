using System;
class Program
{
    static void Main(string[] args)
    {
        EditorArquivo arquivo = new EditorArquivo("arquivo_1.txt");

        arquivo.Open();

        arquivo.Edit("hello world");

        bool renomeado = arquivo.Rename("ArquivoInicial.txt");
        Console.WriteLine("Arquivo renomeado? " + renomeado);

        arquivo.Clear();

        arquivo.Open();
    }
}