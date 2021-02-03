
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
            this.TxtEstado = new System.Windows.Forms.ComboBox();
            this.TxtEspecialidad = new System.Windows.Forms.TextBox();
            this.TxtTituloT = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvTesis);
            this.panel1.Controls.Add(this.TxtEstado);
            this.panel1.Controls.Add(this.TxtEspecialidad);
            this.panel1.Controls.Add(this.TxtTituloT);
            this.panel1.Controls.Add(this.Estado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.TxtCodTesis);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Size = new System.Drawing.Size(962, 783);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(962, 55);
            this.LblTitulo.Text = "TESIS";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 725);
            this.panel4.Size = new System.Drawing.Size(962, 58);
            // 
            // TxtEstado
            // 
            this.TxtEstado.Items.AddRange(new object[] {
            "Inscripcion",
            "En Evaluación",
            "En dictamen",
            "Finalizado"});
            this.TxtEstado.Location = new System.Drawing.Point(296, 190);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(187, 24);
            this.TxtEstado.TabIndex = 27;
            // 
            // TxtEspecialidad
            // 
            this.TxtEspecialidad.Location = new System.Drawing.Point(296, 149);
            this.TxtEspecialidad.Name = "TxtEspecialidad";
            this.TxtEspecialidad.Size = new System.Drawing.Size(568, 22);
            this.TxtEspecialidad.TabIndex = 34;
            // 
            // TxtTituloT
            // 
            this.TxtTituloT.Location = new System.Drawing.Point(296, 110);
            this.TxtTituloT.Name = "TxtTituloT";
            this.TxtTituloT.Size = new System.Drawing.Size(568, 22);
            this.TxtTituloT.TabIndex = 33;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(211, 190);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(73, 20);
            this.Estado.TabIndex = 32;
            this.Estado.Text = "Estado:";
            this.Estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Titulo de la tesis:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(162, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 20);
            this.label19.TabIndex = 30;
            this.label19.Text = "Especialidad:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Location = new System.Drawing.Point(296, 78);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(131, 22);
            this.TxtCodTesis.TabIndex = 29;
            this.TxtCodTesis.Leave += new System.EventHandler(this.TxtCodTesis_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(111, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(173, 20);
            this.label20.TabIndex = 28;
            this.label20.Text = "Código  de la tesis:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvTesis
            // 
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(12, 248);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.ReadOnly = true;
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.RowTemplate.Height = 24;
            this.DgvTesis.Size = new System.Drawing.Size(938, 458);
            this.DgvTesis.TabIndex = 35;
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
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).EndInit();
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
    }
}