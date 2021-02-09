
namespace LibFormularios
{
    partial class FrmDocente
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
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtGradoAcademico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DgvDocente = new System.Windows.Forms.DataGridView();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.TxtCodDocente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxCargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Size = new System.Drawing.Size(962, 728);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(962, 55);
            this.LblTitulo.Text = "DOCENTE";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 725);
            this.panel4.Size = new System.Drawing.Size(962, 58);
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(430, 249);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(401, 22);
            this.TxtCategoria.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Categoria:";
            // 
            // TxtGradoAcademico
            // 
            this.TxtGradoAcademico.Location = new System.Drawing.Point(430, 221);
            this.TxtGradoAcademico.Name = "TxtGradoAcademico";
            this.TxtGradoAcademico.Size = new System.Drawing.Size(401, 22);
            this.TxtGradoAcademico.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Grado Academico:";
            // 
            // DgvDocente
            // 
            this.DgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDocente.Location = new System.Drawing.Point(12, 400);
            this.DgvDocente.Name = "DgvDocente";
            this.DgvDocente.ReadOnly = true;
            this.DgvDocente.RowHeadersWidth = 51;
            this.DgvDocente.RowTemplate.Height = 24;
            this.DgvDocente.Size = new System.Drawing.Size(938, 302);
            this.DgvDocente.TabIndex = 33;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(430, 327);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(136, 22);
            this.TxtTelefono.TabIndex = 32;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(430, 291);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(401, 22);
            this.TxtCorreo.TabIndex = 31;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(430, 190);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(401, 22);
            this.TxtNombres.TabIndex = 30;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(430, 154);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(401, 22);
            this.TxtApellidos.TabIndex = 29;
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(430, 118);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(136, 22);
            this.TxtDNI.TabIndex = 28;
            // 
            // TxtCodDocente
            // 
            this.TxtCodDocente.Location = new System.Drawing.Point(430, 82);
            this.TxtCodDocente.Name = "TxtCodDocente";
            this.TxtCodDocente.Size = new System.Drawing.Size(136, 22);
            this.TxtCodDocente.TabIndex = 27;
            this.TxtCodDocente.Leave += new System.EventHandler(this.TxtCodDocente_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cargo:";
            // 
            // CbxCargo
            // 
            this.CbxCargo.FormattingEnabled = true;
            this.CbxCargo.Items.AddRange(new object[] {
            "Director",
            "Evaluador",
            "Dictaminante",
            "Jurado"});
            this.CbxCargo.Location = new System.Drawing.Point(430, 363);
            this.CbxCargo.Name = "CbxCargo";
            this.CbxCargo.Size = new System.Drawing.Size(136, 24);
            this.CbxCargo.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Número de celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Código del docente:";
            // 
            // FrmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 783);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtGradoAcademico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DgvDocente);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtDNI);
            this.Controls.Add(this.TxtCodDocente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbxCargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDocente";
            this.Text = "FrmDocente";
            this.Load += new System.EventHandler(this.FrmInscripcion_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.CbxCargo, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.TxtCodDocente, 0);
            this.Controls.SetChildIndex(this.TxtDNI, 0);
            this.Controls.SetChildIndex(this.TxtApellidos, 0);
            this.Controls.SetChildIndex(this.TxtNombres, 0);
            this.Controls.SetChildIndex(this.TxtCorreo, 0);
            this.Controls.SetChildIndex(this.TxtTelefono, 0);
            this.Controls.SetChildIndex(this.DgvDocente, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.TxtGradoAcademico, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.TxtCategoria, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtGradoAcademico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DgvDocente;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.TextBox TxtCodDocente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}