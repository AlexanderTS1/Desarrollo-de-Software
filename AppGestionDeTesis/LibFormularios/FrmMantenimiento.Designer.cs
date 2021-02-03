
namespace LibFormularios
{
    partial class FrmMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimiento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMantenimiento = new System.Windows.Forms.Button();
            this.PnlSubMantenimiento = new System.Windows.Forms.Panel();
            this.BtnDocentes = new System.Windows.Forms.Button();
            this.BtnTesistas = new System.Windows.Forms.Button();
            this.BtnTesis = new System.Windows.Forms.Button();
            this.BtnRequisitos = new System.Windows.Forms.Button();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.PnlSubMantenimiento.SuspendLayout();
            this.PnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.PnlSubMantenimiento);
            this.panel1.Controls.Add(this.BtnMantenimiento);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 759);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 100);
            this.panel2.TabIndex = 0;
            // 
            // BtnMantenimiento
            // 
            this.BtnMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.BtnMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMantenimiento.FlatAppearance.BorderSize = 0;
            this.BtnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMantenimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMantenimiento.Location = new System.Drawing.Point(0, 100);
            this.BtnMantenimiento.Name = "BtnMantenimiento";
            this.BtnMantenimiento.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnMantenimiento.Size = new System.Drawing.Size(250, 45);
            this.BtnMantenimiento.TabIndex = 1;
            this.BtnMantenimiento.Text = "MANTENIMIENTO";
            this.BtnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMantenimiento.UseVisualStyleBackColor = false;
            this.BtnMantenimiento.Click += new System.EventHandler(this.BtnMantenimiento_Click);
            // 
            // PnlSubMantenimiento
            // 
            this.PnlSubMantenimiento.Controls.Add(this.BtnRequisitos);
            this.PnlSubMantenimiento.Controls.Add(this.BtnTesis);
            this.PnlSubMantenimiento.Controls.Add(this.BtnTesistas);
            this.PnlSubMantenimiento.Controls.Add(this.BtnDocentes);
            this.PnlSubMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSubMantenimiento.Location = new System.Drawing.Point(0, 145);
            this.PnlSubMantenimiento.Name = "PnlSubMantenimiento";
            this.PnlSubMantenimiento.Size = new System.Drawing.Size(250, 183);
            this.PnlSubMantenimiento.TabIndex = 2;
            // 
            // BtnDocentes
            // 
            this.BtnDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.BtnDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDocentes.FlatAppearance.BorderSize = 0;
            this.BtnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDocentes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDocentes.Location = new System.Drawing.Point(0, 0);
            this.BtnDocentes.Name = "BtnDocentes";
            this.BtnDocentes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnDocentes.Size = new System.Drawing.Size(250, 45);
            this.BtnDocentes.TabIndex = 0;
            this.BtnDocentes.Text = "DOCENTES";
            this.BtnDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDocentes.UseVisualStyleBackColor = false;
            this.BtnDocentes.Click += new System.EventHandler(this.BtnDocentes_Click);
            // 
            // BtnTesistas
            // 
            this.BtnTesistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.BtnTesistas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTesistas.FlatAppearance.BorderSize = 0;
            this.BtnTesistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTesistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTesistas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnTesistas.Location = new System.Drawing.Point(0, 45);
            this.BtnTesistas.Name = "BtnTesistas";
            this.BtnTesistas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnTesistas.Size = new System.Drawing.Size(250, 45);
            this.BtnTesistas.TabIndex = 1;
            this.BtnTesistas.Text = "TESISTA";
            this.BtnTesistas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTesistas.UseVisualStyleBackColor = false;
            this.BtnTesistas.Click += new System.EventHandler(this.BtnTesistas_Click);
            // 
            // BtnTesis
            // 
            this.BtnTesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.BtnTesis.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTesis.FlatAppearance.BorderSize = 0;
            this.BtnTesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTesis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnTesis.Location = new System.Drawing.Point(0, 90);
            this.BtnTesis.Name = "BtnTesis";
            this.BtnTesis.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnTesis.Size = new System.Drawing.Size(250, 45);
            this.BtnTesis.TabIndex = 2;
            this.BtnTesis.Text = "TESIS";
            this.BtnTesis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTesis.UseVisualStyleBackColor = false;
            this.BtnTesis.Click += new System.EventHandler(this.BtnTesis_Click);
            // 
            // BtnRequisitos
            // 
            this.BtnRequisitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.BtnRequisitos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRequisitos.FlatAppearance.BorderSize = 0;
            this.BtnRequisitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRequisitos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRequisitos.Location = new System.Drawing.Point(0, 135);
            this.BtnRequisitos.Name = "BtnRequisitos";
            this.BtnRequisitos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnRequisitos.Size = new System.Drawing.Size(250, 45);
            this.BtnRequisitos.TabIndex = 3;
            this.BtnRequisitos.Text = "REQUISITOS";
            this.BtnRequisitos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRequisitos.UseVisualStyleBackColor = false;
            this.BtnRequisitos.Click += new System.EventHandler(this.BtnRequisitos_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.pictureBox1);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(250, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(745, 759);
            this.PnlContenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(995, 759);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMantenimiento";
            this.Text = "FrmMantenimiento";
            this.panel1.ResumeLayout(false);
            this.PnlSubMantenimiento.ResumeLayout(false);
            this.PnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlSubMantenimiento;
        private System.Windows.Forms.Button BtnTesis;
        private System.Windows.Forms.Button BtnTesistas;
        private System.Windows.Forms.Button BtnDocentes;
        private System.Windows.Forms.Button BtnMantenimiento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnRequisitos;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}