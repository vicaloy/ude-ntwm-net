
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
            this.integranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integranteToolStripMenuItem,
            this.bandaToolStripMenuItem,
            this.cancionToolStripMenuItem,
            this.albumToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // integranteToolStripMenuItem
            // 
            this.integranteToolStripMenuItem.Name = "integranteToolStripMenuItem";
            this.integranteToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.integranteToolStripMenuItem.Text = "Integrante";
            this.integranteToolStripMenuItem.Click += new System.EventHandler(this.integranteToolStripMenuItem_Click);
            // 
            // bandaToolStripMenuItem
            // 
            this.bandaToolStripMenuItem.Name = "bandaToolStripMenuItem";
            this.bandaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.bandaToolStripMenuItem.Text = "Banda";
            this.bandaToolStripMenuItem.Click += new System.EventHandler(this.bandaToolStripMenuItem_Click);
            // 
            // cancionToolStripMenuItem
            // 
            this.cancionToolStripMenuItem.Name = "cancionToolStripMenuItem";
            this.cancionToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cancionToolStripMenuItem.Text = "Cancion";
            this.cancionToolStripMenuItem.Click += new System.EventHandler(this.cancionToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.albumToolStripMenuItem_Click);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem integranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
    }
}