
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
            this.button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtFundamento = new System.Windows.Forms.TextBox();
            this.GboRubrica = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.DgvInteresados = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtApellidosDocente = new System.Windows.Forms.TextBox();
            this.TxtNombresDocente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CboCodDictaminantes = new System.Windows.Forms.ComboBox();
            this.LblNotificacion = new System.Windows.Forms.Label();
            this.CboCodDocente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodDocente = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.GboRubrica.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtCodDocente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CboCodDocente);
            this.panel1.Controls.Add(this.LblNotificacion);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TxtCodTesis);
            this.panel1.Controls.Add(this.TxtNombresDocente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CboCodDictaminantes);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.TxtApellidosDocente);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Size = new System.Drawing.Size(1104, 725);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(1104, 55);
            this.LblTitulo.Text = "DICTAMEN DE TESIS";
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
            // GboRubrica
            // 
            this.GboRubrica.Controls.Add(this.radioButton2);
            this.GboRubrica.Controls.Add(this.radioButton1);
            this.GboRubrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GboRubrica.Location = new System.Drawing.Point(46, 486);
            this.GboRubrica.Name = "GboRubrica";
            this.GboRubrica.Size = new System.Drawing.Size(419, 148);
            this.GboRubrica.TabIndex = 283;
            this.GboRubrica.TabStop = false;
            this.GboRubrica.Text = "Resultados";
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
            this.groupBox2.Controls.Add(this.DgvTesis);
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
            // DgvTesis
            // 
            this.DgvTesis.AllowUserToAddRows = false;
            this.DgvTesis.AllowUserToDeleteRows = false;
            this.DgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTesis.BackgroundColor = System.Drawing.Color.White;
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(12, 112);
            this.DgvTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.ReadOnly = true;
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.RowTemplate.Height = 24;
            this.DgvTesis.Size = new System.Drawing.Size(966, 52);
            this.DgvTesis.TabIndex = 210;
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
            this.DgvInteresados.Size = new System.Drawing.Size(966, 52);
            this.DgvInteresados.TabIndex = 208;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(528, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 24);
            this.label12.TabIndex = 273;
            this.label12.Text = "Apellidos:";
            // 
            // TxtApellidosDocente
            // 
            this.TxtApellidosDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtApellidosDocente.Location = new System.Drawing.Point(658, 140);
            this.TxtApellidosDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApellidosDocente.Name = "TxtApellidosDocente";
            this.TxtApellidosDocente.Size = new System.Drawing.Size(224, 30);
            this.TxtApellidosDocente.TabIndex = 276;
            // 
            // TxtNombresDocente
            // 
            this.TxtNombresDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNombresDocente.Location = new System.Drawing.Point(267, 134);
            this.TxtNombresDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombresDocente.Name = "TxtNombresDocente";
            this.TxtNombresDocente.Size = new System.Drawing.Size(246, 30);
            this.TxtNombresDocente.TabIndex = 277;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(730, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 24);
            this.label14.TabIndex = 288;
            this.label14.Text = "Codigo de la Tesis:";
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Location = new System.Drawing.Point(947, 32);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(100, 22);
            this.TxtCodTesis.TabIndex = 287;
            this.TxtCodTesis.TextChanged += new System.EventHandler(this.TxtCodTesis_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(48, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 286;
            this.label1.Text = "Codigo del Docente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(48, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 25);
            this.label8.TabIndex = 284;
            this.label8.Text = "Codigo De Dictaminantes:";
            // 
            // CboCodDictaminantes
            // 
            this.CboCodDictaminantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodDictaminantes.FormattingEnabled = true;
            this.CboCodDictaminantes.Location = new System.Drawing.Point(341, 24);
            this.CboCodDictaminantes.Name = "CboCodDictaminantes";
            this.CboCodDictaminantes.Size = new System.Drawing.Size(344, 30);
            this.CboCodDictaminantes.TabIndex = 283;
            this.CboCodDictaminantes.SelectedIndexChanged += new System.EventHandler(this.CboCodDictaminantes_SelectedIndexChanged);
            // 
            // LblNotificacion
            // 
            this.LblNotificacion.AutoSize = true;
            this.LblNotificacion.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.LblNotificacion.ForeColor = System.Drawing.Color.Red;
            this.LblNotificacion.Location = new System.Drawing.Point(463, 98);
            this.LblNotificacion.Name = "LblNotificacion";
            this.LblNotificacion.Size = new System.Drawing.Size(119, 22);
            this.LblNotificacion.TabIndex = 289;
            this.LblNotificacion.Text = "Notificacion";
            // 
            // CboCodDocente
            // 
            this.CboCodDocente.FormattingEnabled = true;
            this.CboCodDocente.Location = new System.Drawing.Point(344, 60);
            this.CboCodDocente.Name = "CboCodDocente";
            this.CboCodDocente.Size = new System.Drawing.Size(341, 24);
            this.CboCodDocente.TabIndex = 290;
            this.CboCodDocente.SelectedIndexChanged += new System.EventHandler(this.CboCodDocente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(100, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 291;
            this.label2.Text = "Nombres:";
            // 
            // TxtCodDocente
            // 
            this.TxtCodDocente.Location = new System.Drawing.Point(948, 140);
            this.TxtCodDocente.Name = "TxtCodDocente";
            this.TxtCodDocente.Size = new System.Drawing.Size(100, 22);
            this.TxtCodDocente.TabIndex = 292;
            // 
            // FrmDictamenTesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 780);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.TxtFundamento);
            this.Controls.Add(this.GboRubrica);
            this.Name = "FrmDictamenTesis";
            this.Text = "FrmDictamenTesis";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.GboRubrica, 0);
            this.Controls.SetChildIndex(this.TxtFundamento, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.GboRubrica.ResumeLayout(false);
            this.GboRubrica.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtFundamento;
        private System.Windows.Forms.GroupBox GboRubrica;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtApellidosDocente;
        private System.Windows.Forms.TextBox TxtNombresDocente;
        private System.Windows.Forms.DataGridView DgvInteresados;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboCodDictaminantes;
        private System.Windows.Forms.Label LblNotificacion;
        private System.Windows.Forms.DataGridView DgvTesis;
        private System.Windows.Forms.ComboBox CboCodDocente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodDocente;
    }
}