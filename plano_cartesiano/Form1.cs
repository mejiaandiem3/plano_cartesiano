using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plano_cartesiano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //inicializar mi grafico
            Graphics papel = this.CreateGraphics();

            //inicializamos la pluma
            Pen lapiz = new Pen(Color.Blue, 3);
            Pen lapizRojo = new Pen(Color.Red,2);

            int X = Width / 2;  //400
            int y = Height / 2;   //300

            //trazar los ejes (dibujar)

            papel.DrawLine(lapiz, X, 0, X, 600);
            papel.DrawLine(lapiz, 0, y, 800, y);

            //eje

            papel.DrawLine(lapizRojo,X,y,600,150);
        
        
        }
    }
}
