using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaFormularios
{
    public partial class pr : Form
    {
        public pr()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inscribir_plan_de_tesis atesis = new Inscribir_plan_de_tesis();
            this.Hide();
            atesis.Show();
        }
    }
}
