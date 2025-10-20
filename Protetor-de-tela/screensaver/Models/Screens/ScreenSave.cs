namespace Models.Screens;

using Models.BaseShapes;
using System.Drawing;
using System.Windows.Forms;

public class ScreenSaver : Form
{
    // ******* Declare suas formas geométricas aqui (escopo global) *******
    private List<MyRectangle> rectangles = new();
    private const int RECTANGLE_COUNT = 10; // Quantidade de retângulos
    // ********************************************************************
    private Timer ControlTimer;

    public ScreenSaver()
    {
        this.DoubleBuffered = true;                     // evita flickering
        this.WindowState = FormWindowState.Maximized;   // Maximiza a janela
        // Define a cor de background
        this.BackColor = Color.Black;                   
        // Inicializa o temporizador de controle
        ControlTimer = new Timer();
        ControlTimer.Interval = 10;                     // 16 ms = ~60 fps
        // Controle da animação
        ControlTimer.Tick += (s, e) =>
        {
            // ****** Mova suas formas geométricas aqui ******
            foreach (var rect in rectangles)
            {
                rect.Move(this.ClientSize);
            }
            // ***********************************************
                Invalidate(); // Foça a tela a ser redesenhada.
        }; // Função anônima disparada pelo ControlTimer a cada Interval (ms)
        ControlTimer.Start();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // ****** Instancie suas formas geométricas aqui ******
        rectangles = new List<MyRectangle>();
        
        // Cria múltiplos retângulos com posições, tamanhos, velocidades e cores aleatórias
        for (int i = 0; i < RECTANGLE_COUNT; i++)
        {
            rectangles.Add(new MyRectangle(this.ClientSize.Width, this.ClientSize.Height));
        }
        // ****************************************************
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // ****** Desenhe suas formas geométricas aqui *******
        foreach (var rect in rectangles)
        {
            rect.Draw(e.Graphics);
        }
        // ***************************************************

    }
}