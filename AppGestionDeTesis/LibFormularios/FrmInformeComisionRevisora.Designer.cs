
namespace LibFormularios
{
    partial class FrmInformeComisionRevisora
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
            this.label14 = new System.Windows.Forms.Label();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboCodComisionRevisora = new System.Windows.Forms.ComboBox();
            this.GbxRubricaDeEvaluacion = new System.Windows.Forms.GroupBox();
            this.LblCondicion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNotaFinal = new System.Windows.Forms.TextBox();
            this.TxtNotaOrganizacionDocTesis = new System.Windows.Forms.TextBox();
            this.TxtNotaImpacto = new System.Windows.Forms.TextBox();
            this.TxtNotaRecursosPresupuesto = new System.Windows.Forms.TextBox();
            this.TxtNotaRevisionBibliografica = new System.Windows.Forms.TextBox();
            this.TxtNotaMetodologia = new System.Windows.Forms.TextBox();
            this.TxtNotaAlcanceResultados = new System.Windows.Forms.TextBox();
            this.TxtNotaHipotesis = new System.Windows.Forms.TextBox();
            this.TxtNotaIdentificacionProblema = new System.Windows.Forms.TextBox();
            this.LblCodTesista1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.GbxRubricaDeEvaluacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtCodTesis);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.CboCodComisionRevisora);
            this.panel1.Size = new System.Drawing.Size(1057, 775);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(1057, 55);
            this.LblTitulo.Text = "INFORME DE LA COMISIÓN REVISORA";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(0, 717);
            this.panel4.Size = new System.Drawing.Size(1057, 58);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(678, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 24);
            this.label14.TabIndex = 226;
            this.label14.Text = "Codigo de la Tesis:";
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Location = new System.Drawing.Point(860, 77);
            this.TxtCodTesis.Multiline = true;
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(176, 30);
            this.TxtCodTesis.TabIndex = 225;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 20);
            this.label8.TabIndex = 223;
            this.label8.Text = "Codigo De Comision Revisora:";
            // 
            // CboCodComisionRevisora
            // 
            this.CboCodComisionRevisora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodComisionRevisora.FormattingEnabled = true;
            this.CboCodComisionRevisora.Location = new System.Drawing.Point(283, 77);
            this.CboCodComisionRevisora.Name = "CboCodComisionRevisora";
            this.CboCodComisionRevisora.Size = new System.Drawing.Size(360, 30);
            this.CboCodComisionRevisora.TabIndex = 222;
            // 
            // GbxRubricaDeEvaluacion
            // 
            this.GbxRubricaDeEvaluacion.Controls.Add(this.LblCondicion);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.groupBox1);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.TxtNotaOrganizacionDocTesis);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.TxtNotaImpacto);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.TxtNotaRecursosPresupuesto);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.TxtNotaRevisionBibliografica);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.TxtNotaMetodologia);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.TxtNotaAlcanceResultados);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.TxtNotaHipotesis);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.TxtNotaIdentificacionProblema);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.LblCodTesista1);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.label1);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.label2);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.label3);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.label4);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.label5);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.label6);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.label7);
            this.GbxRubricaDeEvaluacion.Location = new System.Drawing.Point(230, 300);
            this.GbxRubricaDeEvaluacion.Name = "GbxRubricaDeEvaluacion";
            this.GbxRubricaDeEvaluacion.Size = new System.Drawing.Size(687, 402);
            this.GbxRubricaDeEvaluacion.TabIndex = 224;
            this.GbxRubricaDeEvaluacion.TabStop = false;
            this.GbxRubricaDeEvaluacion.Text = "Rubrica de evaluacion";
            // 
            // LblCondicion
            // 
            this.LblCondicion.AutoSize = true;
            this.LblCondicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.LblCondicion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblCondicion.Location = new System.Drawing.Point(132, 368);
            this.LblCondicion.Name = "LblCondicion";
            this.LblCondicion.Size = new System.Drawing.Size(94, 24);
            this.LblCondicion.TabIndex = 171;
            this.LblCondicion.Text = "Resultado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtNotaFinal);
            this.groupBox1.Location = new System.Drawing.Point(124, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 70);
            this.groupBox1.TabIndex = 170;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 168;
            this.label9.Text = "Nota Final:";
            // 
            // TxtNotaFinal
            // 
            this.TxtNotaFinal.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotaFinal.Location = new System.Drawing.Point(383, 34);
            this.TxtNotaFinal.Name = "TxtNotaFinal";
            this.TxtNotaFinal.ReadOnly = true;
            this.TxtNotaFinal.Size = new System.Drawing.Size(100, 30);
            this.TxtNotaFinal.TabIndex = 169;
            // 
            // TxtNotaOrganizacionDocTesis
            // 
            this.TxtNotaOrganizacionDocTesis.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotaOrganizacionDocTesis.Location = new System.Drawing.Point(509, 246);
            this.TxtNotaOrganizacionDocTesis.Name = "TxtNotaOrganizacionDocTesis";
            this.TxtNotaOrganizacionDocTesis.ReadOnly = true;
            this.TxtNotaOrganizacionDocTesis.Size = new System.Drawing.Size(100, 26);
            this.TxtNotaOrganizacionDocTesis.TabIndex = 167;
            // 
            // TxtNotaImpacto
            // 
            this.TxtNotaImpacto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotaImpacto.Location = new System.Drawing.Point(509, 214);
            this.TxtNotaImpacto.Name = "TxtNotaImpacto";
            this.TxtNotaImpacto.ReadOnly = true;
            this.TxtNotaImpacto.Size = new System.Drawing.Size(100, 26);
            this.TxtNotaImpacto.TabIndex = 166;
            // 
            // TxtNotaRecursosPresupuesto
            // 
            this.TxtNotaRecursosPresupuesto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotaRecursosPresupuesto.Location = new System.Drawing.Point(509, 182);
            this.TxtNotaRecursosPresupuesto.Name = "TxtNotaRecursosPresupuesto";
            this.TxtNotaRecursosPresupuesto.ReadOnly = true;
            this.TxtNotaRecursosPresupuesto.Size = new System.Drawing.Size(100, 26);
            this.TxtNotaRecursosPresupuesto.TabIndex = 165;
            // 
            // TxtNotaRevisionBibliografica
            // 
            this.TxtNotaRevisionBibliografica.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotaRevisionBibliografica.Location = new System.Drawing.Point(509, 150);
            this.TxtNotaRevisionBibliografica.Name = "TxtNotaRevisionBibliografica";
            this.TxtNotaRevisionBibliografica.ReadOnly = true;
            this.TxtNotaRevisionBibliografica.Size = new System.Drawing.Size(100, 26);
            this.TxtNotaRevisionBibliografica.TabIndex = 164;
            // 
            // TxtNotaMetodologia
            // 
            this.TxtNotaMetodologia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotaMetodologia.Location = new System.Drawing.Point(509, 118);
            this.TxtNotaMetodologia.Name = "TxtNotaMetodologia";
            this.TxtNotaMetodologia.ReadOnly = true;
            this.TxtNotaMetodologia.Size = new System.Drawing.Size(100, 26);
            this.TxtNotaMetodologia.TabIndex = 163;
            // 
            // TxtNotaAlcanceResultados
            // 
            this.TxtNotaAlcanceResultados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotaAlcanceResultados.Location = new System.Drawing.Point(509, 86);
            this.TxtNotaAlcanceResultados.Name = "TxtNotaAlcanceResultados";
            this.TxtNotaAlcanceResultados.ReadOnly = true;
            this.TxtNotaAlcanceResultados.Size = new System.Drawing.Size(100, 26);
            this.TxtNotaAlcanceResultados.TabIndex = 162;
            // 
            // TxtNotaHipotesis
            // 
            this.TxtNotaHipotesis.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotaHipotesis.Location = new System.Drawing.Point(509, 54);
            this.TxtNotaHipotesis.Name = "TxtNotaHipotesis";
            this.TxtNotaHipotesis.ReadOnly = true;
            this.TxtNotaHipotesis.Size = new System.Drawing.Size(100, 26);
            this.TxtNotaHipotesis.TabIndex = 161;
            // 
            // TxtNotaIdentificacionProblema
            // 
            this.TxtNotaIdentificacionProblema.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotaIdentificacionProblema.Location = new System.Drawing.Point(509, 22);
            this.TxtNotaIdentificacionProblema.Name = "TxtNotaIdentificacionProblema";
            this.TxtNotaIdentificacionProblema.ReadOnly = true;
            this.TxtNotaIdentificacionProblema.Size = new System.Drawing.Size(100, 26);
            this.TxtNotaIdentificacionProblema.TabIndex = 160;
            // 
            // LblCodTesista1
            // 
            this.LblCodTesista1.AutoSize = true;
            this.LblCodTesista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblCodTesista1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblCodTesista1.Location = new System.Drawing.Point(132, 33);
            this.LblCodTesista1.Name = "LblCodTesista1";
            this.LblCodTesista1.Size = new System.Drawing.Size(188, 18);
            this.LblCodTesista1.TabIndex = 143;
            this.LblCodTesista1.Text = "Identificacion del Problema:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(132, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 145;
            this.label1.Text = "Hipotesis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(130, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 146;
            this.label2.Text = "Alcance y Resultados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(132, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 147;
            this.label3.Text = "Revision Bibliografica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(132, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 148;
            this.label4.Text = "Metodologia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(132, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 18);
            this.label5.TabIndex = 149;
            this.label5.Text = "Recursos y Presupuesto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(132, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 150;
            this.label6.Text = "Impacto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(132, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 18);
            this.label7.TabIndex = 151;
            this.label7.Text = "Organizacion del Documento:";
            // 
            // DgvTesis
            // 
            this.DgvTesis.AllowUserToAddRows = false;
            this.DgvTesis.AllowUserToDeleteRows = false;
            this.DgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTesis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(30, 31);
            this.DgvTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.ReadOnly = true;
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.RowTemplate.Height = 24;
            this.DgvTesis.Size = new System.Drawing.Size(962, 108);
            this.DgvTesis.TabIndex = 210;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvTesis);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(8, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1044, 163);
            this.groupBox2.TabIndex = 227;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Tesis:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(646, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 34);
            this.button1.TabIndex = 224;
            this.button1.Text = "Emitir Resolucion";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmInformeComisionRevisora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 775);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GbxRubricaDeEvaluacion);
            this.Name = "FrmInformeComisionRevisora";
            this.Text = "FrmInformeComisionRevisora";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.GbxRubricaDeEvaluacion, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.GbxRubricaDeEvaluacion.ResumeLayout(false);
            this.GbxRubricaDeEvaluacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboCodComisionRevisora;
        private System.Windows.Forms.GroupBox GbxRubricaDeEvaluacion;
        protected System.Windows.Forms.Label LblCondicion;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNotaFinal;
        private System.Windows.Forms.TextBox TxtNotaOrganizacionDocTesis;
        private System.Windows.Forms.TextBox TxtNotaImpacto;
        private System.Windows.Forms.TextBox TxtNotaRecursosPresupuesto;
        private System.Windows.Forms.TextBox TxtNotaRevisionBibliografica;
        private System.Windows.Forms.TextBox TxtNotaMetodologia;
        private System.Windows.Forms.TextBox TxtNotaAlcanceResultados;
        private System.Windows.Forms.TextBox TxtNotaHipotesis;
        private System.Windows.Forms.TextBox TxtNotaIdentificacionProblema;
        protected System.Windows.Forms.Label LblCodTesista1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvTesis;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Button button1;
    }
}