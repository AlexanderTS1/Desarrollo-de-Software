
namespace LibFormularios
{
    partial class FrmEditarRegistrosXTramite
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboCodTramite = new System.Windows.Forms.ComboBox();
            this.ChlRequisitosXTramite = new System.Windows.Forms.CheckedListBox();
            this.BtnGuardar1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnGuardar1);
            this.panel1.Controls.Add(this.ChlRequisitosXTramite);
            this.panel1.Controls.Add(this.CboCodTramite);
            this.panel1.Controls.Add(this.label1);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Text = "EDITAR REQUSITOS POR TRAMITE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tramite:";
            // 
            // CboCodTramite
            // 
            this.CboCodTramite.FormattingEnabled = true;
            this.CboCodTramite.Location = new System.Drawing.Point(354, 161);
            this.CboCodTramite.Name = "CboCodTramite";
            this.CboCodTramite.Size = new System.Drawing.Size(425, 24);
            this.CboCodTramite.TabIndex = 1;
            this.CboCodTramite.SelectedIndexChanged += new System.EventHandler(this.CboCodTramite_SelectedIndexChanged);
            // 
            // ChlRequisitosXTramite
            // 
            this.ChlRequisitosXTramite.FormattingEnabled = true;
            this.ChlRequisitosXTramite.Location = new System.Drawing.Point(121, 281);
            this.ChlRequisitosXTramite.Name = "ChlRequisitosXTramite";
            this.ChlRequisitosXTramite.Size = new System.Drawing.Size(716, 259);
            this.ChlRequisitosXTramite.TabIndex = 2;
            // 
            // BtnGuardar1
            // 
            this.BtnGuardar1.Location = new System.Drawing.Point(626, 611);
            this.BtnGuardar1.Name = "BtnGuardar1";
            this.BtnGuardar1.Size = new System.Drawing.Size(269, 31);
            this.BtnGuardar1.TabIndex = 3;
            this.BtnGuardar1.Text = "Save";
            this.BtnGuardar1.UseVisualStyleBackColor = true;
            this.BtnGuardar1.Click += new System.EventHandler(this.BtnGuardar1_Click);
            // 
            // FrmEditarRegistrosXTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 783);
            this.Name = "FrmEditarRegistrosXTramite";
            this.Text = "FrmEditarRegistrosXTramite";
            this.Load += new System.EventHandler(this.FrmEditarRegistrosXTramite_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar1;
        private System.Windows.Forms.CheckedListBox ChlRequisitosXTramite;
        private System.Windows.Forms.ComboBox CboCodTramite;
        private System.Windows.Forms.Label label1;
    }
}