namespace Models.BaseShapes;

using System.Drawing;

public abstract class Shape
{
  // ATRIBUTOS
  public int X;
  public int Y;

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

  // MÉTODOS
  // Move altera a posição com base na velocidade. Recebe os limites disponíveis (tamanho da tela)
  // Implementações específicas (ex: retângulo) podem sobrescrever e aplicar colisão/rebate.
  
  public virtual void Move(Size bounds)
  {
    X += SpeedX;
    Y += SpeedY;
  }

}