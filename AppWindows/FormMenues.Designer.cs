
namespace AppWindows
{
    partial class FormMenues
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bandaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.integranteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aBMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumToolStripMenuItem1,
            this.bandaToolStripMenuItem1,
            this.cancionToolStripMenuItem1,
            this.integranteToolStripMenuItem1});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // albumToolStripMenuItem1
            // 
            this.albumToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albumToolStripMenuItem1.Image = global::AppWindows.Properties.Resources._2c8cd9dd_7c6a_4903_bc7b_1ea9d83c988b;
            this.albumToolStripMenuItem1.Name = "albumToolStripMenuItem1";
            this.albumToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.albumToolStripMenuItem1.Text = "Album";
            this.albumToolStripMenuItem1.Click += new System.EventHandler(this.albumToolStripMenuItem1_Click);
            // 
            // bandaToolStripMenuItem1
            // 
            this.bandaToolStripMenuItem1.Image = global::AppWindows.Properties.Resources.a10dee19_5d78_4d9f_afb8_42d72fc015dd1;
            this.bandaToolStripMenuItem1.Name = "bandaToolStripMenuItem1";
            this.bandaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bandaToolStripMenuItem1.Text = "Banda";
            this.bandaToolStripMenuItem1.Click += new System.EventHandler(this.bandaToolStripMenuItem1_Click);
            // 
            // cancionToolStripMenuItem1
            // 
            this.cancionToolStripMenuItem1.Image = global::AppWindows.Properties.Resources.d0b2cb20_a3ee_4fc2_92a4_2a792bbeaea41;
            this.cancionToolStripMenuItem1.Name = "cancionToolStripMenuItem1";
            this.cancionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cancionToolStripMenuItem1.Text = "Cancion";
            this.cancionToolStripMenuItem1.Click += new System.EventHandler(this.cancionToolStripMenuItem1_Click);
            // 
            // integranteToolStripMenuItem1
            // 
            this.integranteToolStripMenuItem1.Image = global::AppWindows.Properties.Resources.d892c47b_392c_4b52_bd59_a9ed9c96c7fd1;
            this.integranteToolStripMenuItem1.Name = "integranteToolStripMenuItem1";
            this.integranteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.integranteToolStripMenuItem1.Text = "Integrante";
            this.integranteToolStripMenuItem1.Click += new System.EventHandler(this.integranteToolStripMenuItem1_Click);
            // 
            // FormMenues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenues";
            this.Text = "FormMenues";
            this.Load += new System.EventHandler(this.FormMenues_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bandaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem integranteToolStripMenuItem1;
    }
}