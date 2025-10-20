namespace Models.BaseShapes;

using System.Drawing;

public abstract class Shape
{
  // ATRIBUTOS
  public int X;
  public int Y;

  public int Width;
  public int Height;

  public int SpeedX;
  public int SpeedY;
  public Color ShapeColor;

  private Random Rand;

  // CONSTRUTORES
  public Shape(int x, int y, Color color)
  {
    X = x;
    Y = y;
    Rand = new Random();
    SpeedX = Rand.Next(-1, 10);
    SpeedY = Rand.Next(-1, 10);
    ShapeColor = color;
  }

  // Sobrecarga do construtor com inicialização aleatória completa
  public Shape(int screenWidth, int screenHeight)
  {
    Rand = new Random();

    // 1. Inicializa Width e Height com valores aleatórios entre 50 e 200
    Width = Rand.Next(50, 201);  
    Height = Rand.Next(50, 201); 

    // 2. Inicializa X e Y de forma aleatória (objeto totalmente dentro da tela)
    X = Rand.Next(0, screenWidth - Width + 1);   
    Y = Rand.Next(0, screenHeight - Height + 1); 

    // 3. Inicializa SpeedX e SpeedY com valores aleatórios entre 1 e 10
    SpeedX = Rand.Next(1, 11) * (Rand.Next(0, 2) == 0 ? -1 : 1); 
    SpeedY = Rand.Next(1, 11) * (Rand.Next(0, 2) == 0 ? -1 : 1); 

    // 4. Inicializa com cor aleatória
    ShapeColor = ColorGenerate();
  }

  // MÉTODOS
  // Move altera a posição com base na velocidade. Recebe os limites disponíveis (tamanho da tela)
  // Implementações específicas (ex: retângulo) podem sobrescrever e aplicar colisão/rebate.
  
  public virtual void Move(Size bounds)
  {
    X += SpeedX;
    Y += SpeedY;
  }

  protected Color ColorGenerate()
  {
    int r = Rand.Next(0, 255);
    int g = Rand.Next(0, 255);
    int b = Rand.Next(0, 255);
    return Color.FromArgb(r, g, b);
  }

}