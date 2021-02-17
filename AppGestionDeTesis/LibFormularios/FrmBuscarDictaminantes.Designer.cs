﻿namespace LibFormularios
{
    partial class FrmBuscarDictaminantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.CodTesista2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblCodTesista1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.CodTesista2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.dgvDocentes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(30, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1153, 306);
            this.groupBox1.TabIndex = 179;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Docentes";
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(11, 28);
            this.dgvDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.RowHeadersWidth = 51;
            this.dgvDocentes.Size = new System.Drawing.Size(1133, 253);
            this.dgvDocentes.TabIndex = 0;
            // 
            // CodTesista2
            // 
            this.CodTesista2.Controls.Add(this.label1);
            this.CodTesista2.Controls.Add(this.CboCategoria);
            this.CodTesista2.Controls.Add(this.BtnSeleccionar);
            this.CodTesista2.Controls.Add(this.TxtBuscar);
            this.CodTesista2.Controls.Add(this.LblCodTesista1);
            this.CodTesista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.CodTesista2.Location = new System.Drawing.Point(30, 82);
            this.CodTesista2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodTesista2.Name = "CodTesista2";
            this.CodTesista2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodTesista2.Size = new System.Drawing.Size(1153, 92);
            this.CodTesista2.TabIndex = 178;
            this.CodTesista2.TabStop = false;
            this.CodTesista2.Text = "Buscar Dictaminantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(489, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 162;
            this.label1.Text = "por:";
            // 
            // CboCategoria
            // 
            this.CboCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Items.AddRange(new object[] {
            "Apellidos",
            "Nombres",
            "DNI"});
            this.CboCategoria.Location = new System.Drawing.Point(545, 33);
            this.CboCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(373, 30);
            this.CboCategoria.TabIndex = 161;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnSeleccionar.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Location = new System.Drawing.Point(925, 21);
            this.BtnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(219, 59);
            this.BtnSeleccionar.TabIndex = 176;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtBuscar.Location = new System.Drawing.Point(99, 33);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(384, 30);
            this.TxtBuscar.TabIndex = 139;
            // 
            // LblCodTesista1
            // 
            this.LblCodTesista1.AutoSize = true;
            this.LblCodTesista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.LblCodTesista1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblCodTesista1.Location = new System.Drawing.Point(5, 37);
            this.LblCodTesista1.Name = "LblCodTesista1";
            this.LblCodTesista1.Size = new System.Drawing.Size(78, 24);
            this.LblCodTesista1.TabIndex = 141;
            this.LblCodTesista1.Text = " Buscar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 180;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBuscarDictaminantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CodTesista2);
            this.Name = "FrmBuscarDictaminantes";
            this.Text = "FrmBuscarDictaminantes";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.CodTesista2.ResumeLayout(false);
            this.CodTesista2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.GroupBox CodTesista2;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboCategoria;
        protected System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.TextBox TxtBuscar;
        protected System.Windows.Forms.Label LblCodTesista1;
        private System.Windows.Forms.Button button1;
    }
}