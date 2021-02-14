
namespace LibFormularios
{
    partial class FrmGenerarExpediente
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
            this.BtnGenerarExpediente = new System.Windows.Forms.Button();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.TxtCodTramite = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNroExpediente = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DgvSolitudesInscripcion = new System.Windows.Forms.DataGridView();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolitudesInscripcion)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.BtnGenerarExpediente);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Size = new System.Drawing.Size(1007, 712);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(1007, 55);
            this.LblTitulo.Text = "SOLICITUDES DE INSCRIPCIÓN DE PLAN DE TESIS";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 654);
            this.panel4.Size = new System.Drawing.Size(1007, 58);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Visible = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Visible = false;
            // 
            // BtnGenerarExpediente
            // 
            this.BtnGenerarExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.BtnGenerarExpediente.FlatAppearance.BorderSize = 0;
            this.BtnGenerarExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnGenerarExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnGenerarExpediente.ForeColor = System.Drawing.Color.Olive;
            this.BtnGenerarExpediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerarExpediente.Location = new System.Drawing.Point(781, 569);
            this.BtnGenerarExpediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGenerarExpediente.Name = "BtnGenerarExpediente";
            this.BtnGenerarExpediente.Size = new System.Drawing.Size(177, 80);
            this.BtnGenerarExpediente.TabIndex = 197;
            this.BtnGenerarExpediente.Text = "Generar Expediente";
            this.BtnGenerarExpediente.UseVisualStyleBackColor = false;
            this.BtnGenerarExpediente.Click += new System.EventHandler(this.BtnGenerarExpediente_Click);
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtCodTesis.Location = new System.Drawing.Point(683, 232);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.ReadOnly = true;
            this.TxtCodTesis.Size = new System.Drawing.Size(122, 22);
            this.TxtCodTesis.TabIndex = 193;
            // 
            // TxtCodTramite
            // 
            this.TxtCodTramite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtCodTramite.Location = new System.Drawing.Point(331, 234);
            this.TxtCodTramite.Name = "TxtCodTramite";
            this.TxtCodTramite.ReadOnly = true;
            this.TxtCodTramite.Size = new System.Drawing.Size(126, 22);
            this.TxtCodTramite.TabIndex = 194;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGenerar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNroExpediente);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(31, 525);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(696, 124);
            this.groupBox1.TabIndex = 196;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expediente";
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.BtnGenerar.FlatAppearance.BorderSize = 0;
            this.BtnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnGenerar.ForeColor = System.Drawing.Color.Olive;
            this.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerar.Location = new System.Drawing.Point(222, 69);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(114, 37);
            this.BtnGenerar.TabIndex = 181;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(412, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 146;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 145;
            this.label1.Text = "NroExpediente:";
            // 
            // TxtNroExpediente
            // 
            this.TxtNroExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtNroExpediente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNroExpediente.Location = new System.Drawing.Point(198, 24);
            this.TxtNroExpediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNroExpediente.Name = "TxtNroExpediente";
            this.TxtNroExpediente.Size = new System.Drawing.Size(194, 30);
            this.TxtNroExpediente.TabIndex = 144;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(506, 27);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 28);
            this.dateTimePicker1.TabIndex = 178;
            // 
            // DgvSolitudesInscripcion
            // 
            this.DgvSolitudesInscripcion.AllowUserToAddRows = false;
            this.DgvSolitudesInscripcion.AllowUserToDeleteRows = false;
            this.DgvSolitudesInscripcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSolitudesInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSolitudesInscripcion.Location = new System.Drawing.Point(19, 20);
            this.DgvSolitudesInscripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvSolitudesInscripcion.Name = "DgvSolitudesInscripcion";
            this.DgvSolitudesInscripcion.ReadOnly = true;
            this.DgvSolitudesInscripcion.RowHeadersWidth = 51;
            this.DgvSolitudesInscripcion.RowTemplate.Height = 24;
            this.DgvSolitudesInscripcion.Size = new System.Drawing.Size(883, 183);
            this.DgvSolitudesInscripcion.TabIndex = 1;
            // 
            // BtnCargar
            // 
            this.BtnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.BtnCargar.FlatAppearance.BorderSize = 0;
            this.BtnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnCargar.ForeColor = System.Drawing.Color.Olive;
            this.BtnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCargar.Location = new System.Drawing.Point(19, 218);
            this.BtnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(149, 54);
            this.BtnCargar.TabIndex = 179;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = false;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.BtnCargar);
            this.groupBox3.Controls.Add(this.DgvSolitudesInscripcion);
            this.groupBox3.Controls.Add(this.TxtCodTesis);
            this.groupBox3.Controls.Add(this.TxtCodTramite);
            this.groupBox3.Location = new System.Drawing.Point(21, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(937, 354);
            this.groupBox3.TabIndex = 192;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Solicitudes de Inscripción de Plan de Tesis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 196;
            this.label4.Text = "Número del Trámite:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 195;
            this.label3.Text = "De la Tesis con Código:";
            // 
            // FrmGenerarExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 712);
            this.Name = "FrmGenerarExpediente";
            this.Text = "FrmGenerarExpediente";
            this.Load += new System.EventHandler(this.FrmGenerarExpediente_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolitudesInscripcion)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button BtnGenerarExpediente;
        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.TextBox TxtCodTramite;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Button BtnGenerar;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNroExpediente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.DataGridView DgvSolitudesInscripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}