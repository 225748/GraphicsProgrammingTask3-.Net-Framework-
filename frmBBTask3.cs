using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsProgrammingTask3_.Net_Framework_
{
    public partial class frmBBTask3 : Form
    {
        Mover mover; //declared outside for global access

        public frmBBTask3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;
            Timer timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            this.Paint += Form1_Paint;
            mover = new Mover(this.Width, this.Height);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            mover.Update();
            mover.Display(e.Graphics);
        }
    }
}