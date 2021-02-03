﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFormularios;
using LibClases;
namespace AppGestionDeTesis
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtnInscribirPlanDeTesis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInscripcion aInscripción = new FrmInscripcion();
            aInscripción.Show();
        }

        private void BtnDocentes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMantenimiento oMantenimiento = new FrmMantenimiento();
            oMantenimiento.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTesista oTesistas= new FrmTesista();
            oTesistas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDocente oTesis = new FrmDocente();
            oTesis.Show();
        }

        private void PbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PxbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
