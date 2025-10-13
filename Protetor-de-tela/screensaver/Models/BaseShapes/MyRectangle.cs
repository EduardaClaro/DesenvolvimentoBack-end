namespace Models.BaseShapes;

public class MyRectangle : Shape
{
    //Atributos
    public int Width;
    public int Height;


    //Construtores
    public MyRectangle(int x, int y, Color color, int width, int height) : base(x, y, color)
    {
        Width = width;
        Height = height;
    }

    //Métodos
    public void Draw(Graphics g)
    {
        using var brush = new SolidBrush(ShapeColor);
        g.FillRectangle(brush, X, Y, Width, Height);
    }

    // Override Move to apply bounce against the given bounds (window client size)
    public override void Move(Size bounds)
    {
        // Update position
        base.Move(bounds);

        // Check horizontal bounds
        if (X < 0)
        {
            X = 0;
            SpeedX = -SpeedX;
        }
        else if (X + Width > bounds.Width)
        {
            X = Math.Max(0, bounds.Width - Width);
            SpeedX = -SpeedX;
        }

        // Check vertical bounds
        if (Y < 0)
        {
            Y = 0;
            SpeedY = -SpeedY;
        }
        else if (Y + Height > bounds.Height)
        {
            Y = Math.Max(0, bounds.Height - Height);
            SpeedY = -SpeedY;
        }
    }
}