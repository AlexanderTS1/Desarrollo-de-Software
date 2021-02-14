
namespace LibFormularios
{
    partial class FrmTesis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTesis));
            this.TxtEstado = new System.Windows.Forms.ComboBox();
            this.TxtEspecialidad = new System.Windows.Forms.TextBox();
            this.TxtTituloT = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBusquedaTesis = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBusquedaTesis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DgvTesis);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Text = "TESIS";
            // 
            // TxtEstado
            // 
            this.TxtEstado.Items.AddRange(new object[] {
            "Inscripcion",
            "En Evaluación",
            "En dictamen",
            "Finalizado"});
            this.TxtEstado.Location = new System.Drawing.Point(271, 144);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(187, 24);
            this.TxtEstado.TabIndex = 27;
            // 
            // TxtEspecialidad
            // 
            this.TxtEspecialidad.Location = new System.Drawing.Point(271, 107);
            this.TxtEspecialidad.Name = "TxtEspecialidad";
            this.TxtEspecialidad.Size = new System.Drawing.Size(610, 22);
            this.TxtEspecialidad.TabIndex = 34;
            // 
            // TxtTituloT
            // 
            this.TxtTituloT.Location = new System.Drawing.Point(271, 70);
            this.TxtTituloT.Name = "TxtTituloT";
            this.TxtTituloT.Size = new System.Drawing.Size(610, 22);
            this.TxtTituloT.TabIndex = 33;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(156, 143);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(66, 20);
            this.Estado.TabIndex = 32;
            this.Estado.Text = "Estado:";
            this.Estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Titulo de la tesis:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(113, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 20);
            this.label19.TabIndex = 30;
            this.label19.Text = "Especialidad:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Location = new System.Drawing.Point(271, 33);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(131, 22);
            this.TxtCodTesis.TabIndex = 29;
            this.TxtCodTesis.Leave += new System.EventHandler(this.TxtCodTesis_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(69, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 20);
            this.label20.TabIndex = 28;
            this.label20.Text = "Código  de la tesis:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvTesis
            // 
            this.DgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTesis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(12, 351);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.ReadOnly = true;
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.RowTemplate.Height = 24;
            this.DgvTesis.Size = new System.Drawing.Size(938, 355);
            this.DgvTesis.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBusquedaTesis);
            this.groupBox1.Controls.Add(this.TxtTituloT);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.TxtEstado);
            this.groupBox1.Controls.Add(this.TxtCodTesis);
            this.groupBox1.Controls.Add(this.TxtEspecialidad);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Estado);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 189);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la tesis";
            // 
            // BtnBusquedaTesis
            // 
            this.BtnBusquedaTesis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnBusquedaTesis.Image = ((System.Drawing.Image)(resources.GetObject("BtnBusquedaTesis.Image")));
            this.BtnBusquedaTesis.Location = new System.Drawing.Point(410, 5);
            this.BtnBusquedaTesis.Name = "BtnBusquedaTesis";
            this.BtnBusquedaTesis.Size = new System.Drawing.Size(50, 50);
            this.BtnBusquedaTesis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBusquedaTesis.TabIndex = 35;
            this.BtnBusquedaTesis.TabStop = false;
            this.BtnBusquedaTesis.Click += new System.EventHandler(this.BtnBusquedaTesis_Click);
            // 
            // FrmTesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 783);
            this.Name = "FrmTesis";
            this.Text = "FrmTesis";
            this.Load += new System.EventHandler(this.FrmTesis_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBusquedaTesis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TxtEstado;
        private System.Windows.Forms.TextBox TxtEspecialidad;
        private System.Windows.Forms.TextBox TxtTituloT;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView DgvTesis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox BtnBusquedaTesis;
    }
}