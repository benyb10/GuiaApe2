using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoAPE2;

namespace proyectoAPE2
{
    public partial class Ayuda2 : Form
    {
        public Ayuda2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matriz matriz = new Matriz();
            matriz.Show();
        }

        private void Ayuda2_Load(object sender, EventArgs e)
        {

        }
    }
}
