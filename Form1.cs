using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaAlunoV2
{
    public partial class frmCategoriaPorIdadeV2 : Form
    {
        public frmCategoriaPorIdadeV2()
        {
            InitializeComponent();
            lbHoje.Text =  "Hoje é:" + DateTime.Now.ToShortDateString();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BntIdentificarCategoria_Click(object sender, EventArgs e)
        {
            
            
            if ((txtNome.Text == String.Empty))
            {
                MessageBox.Show("Todos os campos solicitados dvem ser preenchidos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtpDataNascimento.Value;
                int idade = (tsQuantidadeDias.Days / 365);
                if (idade > 17)
                {
                    lbCategoria.Text = "Adulto";
                    lbCategoria.BackColor = Color.Red;
                    lbCategoria.ForeColor = Color.Yellow;
                }
                else if ((idade >= 14) && (idade <= 17))
                {
                    lbCategoria.Text = "Juvenil B";
                    lbCategoria.BackColor = Color.Green;
                    lbCategoria.ForeColor = Color.Yellow;
                }
                else if ((idade >= 11) && (idade < 14))
                {
                    lbCategoria.Text = "Juvenil A";
                    lbCategoria.BackColor = Color.Blue;
                    lbCategoria.ForeColor = Color.Yellow;
                }
                else if ((idade >= 8) && (idade < 11))
                {
                    lbCategoria.Text = "Infantil B";
                    lbCategoria.BackColor = Color.Black;
                    lbCategoria.ForeColor = Color.Yellow;
                }
                else if ((idade >= 5) && (idade < 8))
                {
                    lbCategoria.Text = "Infantil A";
                    lbCategoria.BackColor = Color.Pink;
                    lbCategoria.ForeColor = Color.Blue;
                }
                else if ((idade < 5))
                {
                    lbCategoria.Text = "Maternal";
                    lbCategoria.BackColor = Color.Orange;
                    lbCategoria.ForeColor = Color.DarkBlue;
                }
            }
        }
    }
}
