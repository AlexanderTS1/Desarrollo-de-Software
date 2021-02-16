
namespace LibFormularios
{
    partial class FrmDictamenTesis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDictamenTesis));
            this.BtnBusquedaTesis = new System.Windows.Forms.PictureBox();
            this.TxtCodDocente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtFundamento = new System.Windows.Forms.TextBox();
            this.GbxRubrica = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DgvInteresados = new System.Windows.Forms.DataGridView();
            this.BtnBusquedaDocente = new System.Windows.Forms.PictureBox();
            this.TxtNombreTesis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDNIDocente = new System.Windows.Forms.TextBox();
            this.TxtApellidosDocente = new System.Windows.Forms.TextBox();
            this.TxtNombresDocente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CboCodDictaminantes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBusquedaTesis)).BeginInit();
            this.GbxRubrica.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBusquedaDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Size = new System.Drawing.Size(1104, 725);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(1104, 55);
            this.LblTitulo.Text = "INFORME DE  DICTAMEN DE TESIS";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(0, 722);
            this.panel4.Size = new System.Drawing.Size(1104, 58);
            this.panel4.Controls.SetChildIndex(this.BtnNuevo, 0);
            this.panel4.Controls.SetChildIndex(this.BtnGuardar, 0);
            this.panel4.Controls.SetChildIndex(this.button1, 0);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Visible = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Visible = false;
            // 
            // BtnBusquedaTesis
            // 
            this.BtnBusquedaTesis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnBusquedaTesis.Image = ((System.Drawing.Image)(resources.GetObject("BtnBusquedaTesis.Image")));
            this.BtnBusquedaTesis.Location = new System.Drawing.Point(405, 111);
            this.BtnBusquedaTesis.Name = "BtnBusquedaTesis";
            this.BtnBusquedaTesis.Size = new System.Drawing.Size(50, 50);
            this.BtnBusquedaTesis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBusquedaTesis.TabIndex = 288;
            this.BtnBusquedaTesis.TabStop = false;
            this.BtnBusquedaTesis.Click += new System.EventHandler(this.BtnBusquedaTesis_Click);
            // 
            // TxtCodDocente
            // 
            this.TxtCodDocente.Location = new System.Drawing.Point(260, 180);
            this.TxtCodDocente.Name = "TxtCodDocente";
            this.TxtCodDocente.Size = new System.Drawing.Size(139, 22);
            this.TxtCodDocente.TabIndex = 287;
            this.TxtCodDocente.Click += new System.EventHandler(this.TxtCodDocente_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(658, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 31);
            this.button1.TabIndex = 286;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label20.Location = new System.Drawing.Point(528, 476);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(142, 24);
            this.label20.TabIndex = 284;
            this.label20.Text = "Observaciones:";
            // 
            // TxtFundamento
            // 
            this.TxtFundamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFundamento.Location = new System.Drawing.Point(521, 500);
            this.TxtFundamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFundamento.Multiline = true;
            this.TxtFundamento.Name = "TxtFundamento";
            this.TxtFundamento.Size = new System.Drawing.Size(542, 134);
            this.TxtFundamento.TabIndex = 285;
            // 
            // GbxRubrica
            // 
            this.GbxRubrica.Controls.Add(this.radioButton2);
            this.GbxRubrica.Controls.Add(this.radioButton1);
            this.GbxRubrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GbxRubrica.Location = new System.Drawing.Point(46, 486);
            this.GbxRubrica.Name = "GbxRubrica";
            this.GbxRubrica.Size = new System.Drawing.Size(419, 148);
            this.GbxRubrica.TabIndex = 283;
            this.GbxRubrica.TabStop = false;
            this.GbxRubrica.Text = "Resultados";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(110, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Insuficiencia";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(110, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Suficiencia";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.DgvInteresados);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(47, 235);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1001, 182);
            this.groupBox2.TabIndex = 282;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Tesis:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(7, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 209;
            // 
            // DgvInteresados
            // 
            this.DgvInteresados.AllowUserToAddRows = false;
            this.DgvInteresados.AllowUserToDeleteRows = false;
            this.DgvInteresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInteresados.BackgroundColor = System.Drawing.Color.White;
            this.DgvInteresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInteresados.Location = new System.Drawing.Point(13, 31);
            this.DgvInteresados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvInteresados.Name = "DgvInteresados";
            this.DgvInteresados.ReadOnly = true;
            this.DgvInteresados.RowHeadersWidth = 51;
            this.DgvInteresados.RowTemplate.Height = 24;
            this.DgvInteresados.Size = new System.Drawing.Size(966, 130);
            this.DgvInteresados.TabIndex = 208;
            // 
            // BtnBusquedaDocente
            // 
            this.BtnBusquedaDocente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnBusquedaDocente.Image = ((System.Drawing.Image)(resources.GetObject("BtnBusquedaDocente.Image")));
            this.BtnBusquedaDocente.Location = new System.Drawing.Point(405, 173);
            this.BtnBusquedaDocente.Name = "BtnBusquedaDocente";
            this.BtnBusquedaDocente.Size = new System.Drawing.Size(50, 50);
            this.BtnBusquedaDocente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBusquedaDocente.TabIndex = 281;
            this.BtnBusquedaDocente.TabStop = false;
            this.BtnBusquedaDocente.Click += new System.EventHandler(this.BtnBusquedaDocente_Click);
            // 
            // TxtNombreTesis
            // 
            this.TxtNombreTesis.Location = new System.Drawing.Point(674, 129);
            this.TxtNombreTesis.Name = "TxtNombreTesis";
            this.TxtNombreTesis.Size = new System.Drawing.Size(373, 22);
            this.TxtNombreTesis.TabIndex = 280;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(486, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 279;
            this.label1.Text = "Nombre de la Tesis:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(538, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 24);
            this.label10.TabIndex = 274;
            this.label10.Text = "Nombres:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(200, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 24);
            this.label12.TabIndex = 273;
            this.label12.Text = "Apellidos:";
            // 
            // TxtDNIDocente
            // 
            this.TxtDNIDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtDNIDocente.Location = new System.Drawing.Point(676, 225);
            this.TxtDNIDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDNIDocente.Name = "TxtDNIDocente";
            this.TxtDNIDocente.Size = new System.Drawing.Size(371, 30);
            this.TxtDNIDocente.TabIndex = 278;
            // 
            // TxtApellidosDocente
            // 
            this.TxtApellidosDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtApellidosDocente.Location = new System.Drawing.Point(341, 228);
            this.TxtApellidosDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApellidosDocente.Name = "TxtApellidosDocente";
            this.TxtApellidosDocente.Size = new System.Drawing.Size(224, 30);
            this.TxtApellidosDocente.TabIndex = 276;
            // 
            // TxtNombresDocente
            // 
            this.TxtNombresDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNombresDocente.Location = new System.Drawing.Point(674, 173);
            this.TxtNombresDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombresDocente.Name = "TxtNombresDocente";
            this.TxtNombresDocente.Size = new System.Drawing.Size(373, 30);
            this.TxtNombresDocente.TabIndex = 277;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(594, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 24);
            this.label11.TabIndex = 275;
            this.label11.Text = "DNI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(42, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 25);
            this.label9.TabIndex = 272;
            this.label9.Text = "Codigo del Docente:";
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Location = new System.Drawing.Point(260, 130);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(139, 22);
            this.TxtCodTesis.TabIndex = 271;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(42, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 24);
            this.label14.TabIndex = 270;
            this.label14.Text = "Codigo de la Tesis:";
            // 
            // CboCodDictaminantes
            // 
            this.CboCodDictaminantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodDictaminantes.FormattingEnabled = true;
            this.CboCodDictaminantes.Location = new System.Drawing.Point(341, 75);
            this.CboCodDictaminantes.Name = "CboCodDictaminantes";
            this.CboCodDictaminantes.Size = new System.Drawing.Size(174, 30);
            this.CboCodDictaminantes.TabIndex = 269;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(42, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 25);
            this.label8.TabIndex = 268;
            this.label8.Text = "Codigo De Dictaminantes:";
            // 
            // FrmDictamenTesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 780);
            this.Controls.Add(this.BtnBusquedaTesis);
            this.Controls.Add(this.TxtCodDocente);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.TxtFundamento);
            this.Controls.Add(this.GbxRubrica);
            this.Controls.Add(this.BtnBusquedaDocente);
            this.Controls.Add(this.TxtNombreTesis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtDNIDocente);
            this.Controls.Add(this.TxtApellidosDocente);
            this.Controls.Add(this.TxtNombresDocente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtCodTesis);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CboCodDictaminantes);
            this.Controls.Add(this.label8);
            this.Name = "FrmDictamenTesis";
            this.Text = "FrmDictamenTesis";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.CboCodDictaminantes, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.TxtCodTesis, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.TxtNombresDocente, 0);
            this.Controls.SetChildIndex(this.TxtApellidosDocente, 0);
            this.Controls.SetChildIndex(this.TxtDNIDocente, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtNombreTesis, 0);
            this.Controls.SetChildIndex(this.BtnBusquedaDocente, 0);
            this.Controls.SetChildIndex(this.GbxRubrica, 0);
            this.Controls.SetChildIndex(this.TxtFundamento, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.TxtCodDocente, 0);
            this.Controls.SetChildIndex(this.BtnBusquedaTesis, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnBusquedaTesis)).EndInit();
            this.GbxRubrica.ResumeLayout(false);
            this.GbxRubrica.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBusquedaDocente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnBusquedaTesis;
        private System.Windows.Forms.TextBox TxtCodDocente;
        protected System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtFundamento;
        private System.Windows.Forms.GroupBox GbxRubrica;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox BtnBusquedaDocente;
        private System.Windows.Forms.TextBox TxtNombreTesis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtDNIDocente;
        private System.Windows.Forms.TextBox TxtApellidosDocente;
        private System.Windows.Forms.TextBox TxtNombresDocente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CboCodDictaminantes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DgvInteresados;
    }
}