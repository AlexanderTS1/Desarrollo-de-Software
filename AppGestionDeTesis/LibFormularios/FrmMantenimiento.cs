using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFormularios
{
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            PnlSubMantenimiento.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        
        private Form activeForm = null;
        
        
        private void BtnMantenimiento_Click(object sender, EventArgs e)
        {
            showSubMenu(PnlSubMantenimiento);
        }

        private void BtnDocentes_Click(object sender, EventArgs e)
        {
            // ..
            //your codes
            //..
            hideSubMenu();
        }

        private void BtnTesistas_Click(object sender, EventArgs e)
        {
            // ..
            //your codes
            //..
            hideSubMenu();
        }

        private void BtnTesis_Click(object sender, EventArgs e)
        {
            // ..
            //your codes
            //..
            hideSubMenu();
        }

        private void BtnRequisitos_Click(object sender, EventArgs e)
        {
            // ..
            //your codes
            //..
            hideSubMenu();
        }
        /*private Form activeForm = null;
        private void abrirFormHijoEnPanel(Form formHijo)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PnlContenedor.Controls.Add(formHijo);
            PnlContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }*/
    }
}
