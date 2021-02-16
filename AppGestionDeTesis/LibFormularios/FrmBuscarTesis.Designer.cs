
namespace LibFormularios
{
    partial class FrmBuscarTesis
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
            this.dgvTesis = new System.Windows.Forms.DataGridView();
            this.CodTesista2 = new System.Windows.Forms.GroupBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CboTesis = new System.Windows.Forms.ComboBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblCodTesista1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesis)).BeginInit();
            this.CodTesista2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Size = new System.Drawing.Size(1144, 491);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(1144, 55);
            this.LblTitulo.Text = "BUSCAR TESIS";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 488);
            this.panel4.Size = new System.Drawing.Size(1144, 58);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Visible = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.dgvTesis);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(-4, 184);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1153, 302);
            this.groupBox1.TabIndex = 181;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tesis";
            // 
            // dgvTesis
            // 
            this.dgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTesis.Location = new System.Drawing.Point(11, 28);
            this.dgvTesis.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTesis.Name = "dgvTesis";
            this.dgvTesis.RowHeadersWidth = 51;
            this.dgvTesis.Size = new System.Drawing.Size(1133, 254);
            this.dgvTesis.TabIndex = 0;
            // 
            // CodTesista2
            // 
            this.CodTesista2.Controls.Add(this.BtnSeleccionar);
            this.CodTesista2.Controls.Add(this.label1);
            this.CodTesista2.Controls.Add(this.CboTesis);
            this.CodTesista2.Controls.Add(this.TxtBuscar);
            this.CodTesista2.Controls.Add(this.LblCodTesista1);
            this.CodTesista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.CodTesista2.Location = new System.Drawing.Point(-4, 69);
            this.CodTesista2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodTesista2.Name = "CodTesista2";
            this.CodTesista2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodTesista2.Size = new System.Drawing.Size(1153, 92);
            this.CodTesista2.TabIndex = 180;
            this.CodTesista2.TabStop = false;
            this.CodTesista2.Text = "Buscar Tesis";
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnSeleccionar.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
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
            // CboTesis
            // 
            this.CboTesis.BackColor = System.Drawing.SystemColors.Control;
            this.CboTesis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTesis.FormattingEnabled = true;
            this.CboTesis.Items.AddRange(new object[] {
            "CodTesis",
            "Titulo",
            "especialidad"});
            this.CboTesis.Location = new System.Drawing.Point(545, 33);
            this.CboTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboTesis.Name = "CboTesis";
            this.CboTesis.Size = new System.Drawing.Size(373, 30);
            this.CboTesis.TabIndex = 161;
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
            // FrmBuscarTesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CodTesista2);
            this.Name = "FrmBuscarTesis";
            this.Text = "FrmBuscarTesis";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.CodTesista2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesis)).EndInit();
            this.CodTesista2.ResumeLayout(false);
            this.CodTesista2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTesis;
        private System.Windows.Forms.GroupBox CodTesista2;
        protected System.Windows.Forms.Button BtnSeleccionar;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboTesis;
        private System.Windows.Forms.TextBox TxtBuscar;
        protected System.Windows.Forms.Label LblCodTesista1;
    }
}