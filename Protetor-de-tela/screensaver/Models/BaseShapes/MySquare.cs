namespace Models.BaseShapes;

public class MySquare : Shape
{
    // Construtor que usa o construtor aleatório da classe base
    public MySquare(int screenWidth, int screenHeight) : base(screenWidth, screenHeight)
    {
        Width = Height;
    }
}
