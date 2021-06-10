using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Lab4_1
{
    public partial class Form1 : Form
    {
        delegate void DrawSomething(Graphics graphics);
        List<System.Timers.Timer> timers;
        Graphics graphics;
        List<Figure> figures;
        DrawSomething draw;
        Timer invalidateTimer;
        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            this.DoubleBuffered = true;
            timers = new List<System.Timers.Timer>();
            figures = new List<Figure>();
            invalidateTimer = new Timer();
            invalidateTimer.Interval = 100;
            invalidateTimer.Tick += InvalidateTimer_Tick;
            invalidateTimer.Start();
            this.Paint += Form1_Paint;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            figures.ForEach((x) => x.DrawBlack(graphics));
        }

        private void InvalidateTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            Random random = new Random();
            figures.Add(new Circle(0, 0, 50));
            figures.Add(new Square(70, 50, 90));
            figures.Add(new Rhomb(0, 400, 60, 40));
            for (i = 0; i < figures.Count; i++)
            {
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = random.Next(100, 200);
                timer.Elapsed += Timer_Elapsed;
                timers.Add(timer);
            }

            void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
            {
                figures.ForEach((x) => x.MoveRight());

            }
            timers.ForEach((x) => x.Start());
        }

        
    }
}
