namespace _28_Mart_2018__çikolata_uygulaması_
{
    partial class Form4
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
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünTürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriİşlemleriToolStripMenuItem,
            this.ürünİşlemleriToolStripMenuItem,
            this.ürünTürToolStripMenuItem,
            this.siparişlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(113, 21);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteriİşlemleri";
            this.müşteriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.müşteriİşlemleriToolStripMenuItem_Click);
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürünİşlemleri";
            this.ürünİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.ürünİşlemleriToolStripMenuItem_Click);
            // 
            // ürünTürToolStripMenuItem
            // 
            this.ürünTürToolStripMenuItem.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünTürToolStripMenuItem.Name = "ürünTürToolStripMenuItem";
            this.ürünTürToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.ürünTürToolStripMenuItem.Text = "ÜrünTür";
            this.ürünTürToolStripMenuItem.Click += new System.EventHandler(this.ürünTürToolStripMenuItem_Click);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            this.siparişlerToolStripMenuItem.Click += new System.EventHandler(this.siparişlerToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(687, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::_28_Mart_2018__çikolata_uygulaması_.Properties.Resources.How_2BTo_2BForce_2BA_2BProgram_2BTo_2BRun_2BAs_2BAdministrator;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünTürToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
    }
}