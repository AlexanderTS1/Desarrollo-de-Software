﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            PnlSubMantenimiento.Visible = false;
            PnlSubprocesos.Visible = false;
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
        
        
        
        private void BtnMantenimiento_Click(object sender, EventArgs e)
        {
            showSubMenu(PnlSubMantenimiento);
        }

        private void BtnDocentes_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmDocente());

            // ..
            //your codes
            //..
            hideSubMenu();
        }

        private void BtnTesistas_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmTesista());

            // ..
            //your codes
            //..
            hideSubMenu();
        }

        private void BtnTesis_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmTesis());
            // ..
            //your codes
            //..
            hideSubMenu();
        }

        private void BtnRequisitos_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmRequisitos());
            // ..
            //your codes
            //..
            hideSubMenu();
        }
        private Form activeForm1 = null;
        private void abrirFormHijoEnPanel(Form formHijo)
        {
            if (activeForm1 != null)
                activeForm1.Close();
            activeForm1 = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PnlContenedor.Controls.Add(formHijo);
            PnlContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void PbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PxbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnInscripcion_Click(object sender, EventArgs e)
        {
            showSubMenu(PnlSubprocesos);
        }

        private void BtnInscribirPlanDeTesis_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmInscripcion());
            // ..
            //your codes
            //..
            hideSubMenu();
        }

        private void BtnRequisitosPorTramite_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmEditarRegistrosXTramite());
            // ..
            //your codes
            //..
            hideSubMenu();
        }
    }
}
