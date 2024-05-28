namespace WindowsFormsApp3
{
    partial class Home
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
            this.моиАкцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросНаПокупкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моиАкцииToolStripMenuItem,
            this.запросНаПокупкуToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // моиАкцииToolStripMenuItem
            // 
            this.моиАкцииToolStripMenuItem.Name = "моиАкцииToolStripMenuItem";
            this.моиАкцииToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.моиАкцииToolStripMenuItem.Text = "Мои акции";
            this.моиАкцииToolStripMenuItem.Click += new System.EventHandler(this.моиАкцииToolStripMenuItem_Click);
            // 
            // запросНаПокупкуToolStripMenuItem
            // 
            this.запросНаПокупкуToolStripMenuItem.Name = "запросНаПокупкуToolStripMenuItem";
            this.запросНаПокупкуToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.запросНаПокупкуToolStripMenuItem.Text = "Запрос на покупку";
            this.запросНаПокупкуToolStripMenuItem.Click += new System.EventHandler(this.запросНаПокупкуToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._2022_10_09_12_37_07;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem моиАкцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросНаПокупкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}