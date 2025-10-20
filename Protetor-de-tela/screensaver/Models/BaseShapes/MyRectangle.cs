namespace Models.BaseShapes;

public class MyRectangle : Shape
{
    //Construtores
    public MyRectangle(int x, int y, Color color, int width, int height) : base(x, y, color)
    {
        Width = width;
        Height = height;
    }

    // Sobrecarga que usa o construtor aleatório da classe base
    public MyRectangle(int screenWidth, int screenHeight) : base(screenWidth, screenHeight)
    {
        
    }

    //Métodos
    public void Draw(Graphics g)
    {
        using var brush = new SolidBrush(ShapeColor);
        g.FillRectangle(brush, X, Y, Width, Height);
    }

    public override void Move(Size bounds)
    {
        base.Move(bounds);

        bool colorChanged = false; 

        if (X < 0)
        {
            X = 0;
            SpeedX = -SpeedX;
            colorChanged = true;
        }
        else if (X + Width > bounds.Width)
        {
            X = Math.Max(0, bounds.Width - Width);
            SpeedX = -SpeedX;
            colorChanged = true;
        }

        // Check vertical bounds
        if (Y < 0)
        {
            Y = 0;
            SpeedY = -SpeedY;
            colorChanged = true;
        }
        else if (Y + Height > bounds.Height)
        {
            Y = Math.Max(0, bounds.Height - Height);
            SpeedY = -SpeedY;
            colorChanged = true;
        }

        if (colorChanged)
        {
            ShapeColor = ColorGenerate();
        }
    }
}