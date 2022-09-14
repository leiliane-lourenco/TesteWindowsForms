using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TesteSimixSistemas
{
    public partial class FormularioInicial : Form
    {
        public FormularioInicial()
        {
            InitializeComponent();
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            var text = resultado.Text;

            List<int> listaResultado = new List<int>();

            for (int i = 1; i < 201; i++)
            {
                listaResultado.Add(i);
            }

            foreach (var item in listaResultado)
            {
                if (item % 3 == 0 & item % 5 == 0)
                    resultado.Text += " Z\r\n";

                else if (item % 3 == 0)
                    resultado.Text += " X\r\n"; 

                else if (item % 5 == 0)
                    resultado.Text += " Y\r\n";

                else
                    resultado.Text += $" {item}\r\n";

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            resultado.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormularioInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
