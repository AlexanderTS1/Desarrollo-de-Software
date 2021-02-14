
namespace LibFormularios
{
    partial class FrmRequisitos
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
            this.DgvRequisito = new System.Windows.Forms.DataGridView();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodRequsito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisito)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvRequisito);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.TxtCodRequsito);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Text = "REQUISITOS POR TRÁMITE";
            // 
            // DgvRequisito
            // 
            this.DgvRequisito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRequisito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvRequisito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRequisito.Location = new System.Drawing.Point(161, 354);
            this.DgvRequisito.Name = "DgvRequisito";
            this.DgvRequisito.ReadOnly = true;
            this.DgvRequisito.RowHeadersWidth = 51;
            this.DgvRequisito.RowTemplate.Height = 24;
            this.DgvRequisito.Size = new System.Drawing.Size(606, 356);
            this.DgvRequisito.TabIndex = 44;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(305, 157);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(570, 22);
            this.TxtNombre.TabIndex = 39;
            // 
            // TxtCodRequsito
            // 
            this.TxtCodRequsito.Location = new System.Drawing.Point(305, 121);
            this.TxtCodRequsito.Name = "TxtCodRequsito";
            this.TxtCodRequsito.Size = new System.Drawing.Size(136, 22);
            this.TxtCodRequsito.TabIndex = 38;
            this.TxtCodRequsito.Leave += new System.EventHandler(this.TxtCodRequsito_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código de Requisito:";
            // 
            // FrmRequisitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 783);
            this.Name = "FrmRequisitos";
            this.Text = "FrmRequisitos";
            this.Load += new System.EventHandler(this.FrmRequsitos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequisito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRequisito;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodRequsito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}