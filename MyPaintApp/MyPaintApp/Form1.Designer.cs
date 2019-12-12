namespace MyPaintApp
{
    partial class form_Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Paint));
            this.menuStrip_Paint = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Paint = new System.Windows.Forms.ToolStrip();
            this.btn_Red = new System.Windows.Forms.ToolStripButton();
            this.btn_Blue = new System.Windows.Forms.ToolStripButton();
            this.btn_Green = new System.Windows.Forms.ToolStripButton();
            this.btn_Purp = new System.Windows.Forms.ToolStripButton();
            this.btn_Black = new System.Windows.Forms.ToolStripButton();
            this.pictureBox_Paint = new System.Windows.Forms.PictureBox();
            this.saveFileDialog_Paint = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip_Paint.SuspendLayout();
            this.toolStrip_Paint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Paint)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_Paint
            // 
            this.menuStrip_Paint.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip_Paint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_Paint.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Paint.Name = "menuStrip_Paint";
            this.menuStrip_Paint.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip_Paint.Size = new System.Drawing.Size(300, 24);
            this.menuStrip_Paint.TabIndex = 0;
            this.menuStrip_Paint.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.saveImageAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveImageAsToolStripMenuItem.Text = "Save Image As";
            // 
            // toolStrip_Paint
            // 
            this.toolStrip_Paint.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip_Paint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Red,
            this.btn_Blue,
            this.btn_Green,
            this.btn_Purp,
            this.btn_Black});
            this.toolStrip_Paint.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_Paint.Name = "toolStrip_Paint";
            this.toolStrip_Paint.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip_Paint.Size = new System.Drawing.Size(300, 25);
            this.toolStrip_Paint.TabIndex = 1;
            this.toolStrip_Paint.Text = "toolStrip1";
            // 
            // btn_Red
            // 
            this.btn_Red.BackColor = System.Drawing.Color.Red;
            this.btn_Red.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Red.Image = ((System.Drawing.Image)(resources.GetObject("btn_Red.Image")));
            this.btn_Red.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(32, 22);
            this.btn_Red.Text = "RED";
            this.btn_Red.Click += new System.EventHandler(this.btn_Red_Click);
            // 
            // btn_Blue
            // 
            this.btn_Blue.BackColor = System.Drawing.Color.Blue;
            this.btn_Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Blue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Blue.Image = ((System.Drawing.Image)(resources.GetObject("btn_Blue.Image")));
            this.btn_Blue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Blue.Name = "btn_Blue";
            this.btn_Blue.Size = new System.Drawing.Size(38, 22);
            this.btn_Blue.Text = "BLUE";
            this.btn_Blue.Click += new System.EventHandler(this.btn_Blue_Click);
            // 
            // btn_Green
            // 
            this.btn_Green.BackColor = System.Drawing.Color.Green;
            this.btn_Green.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Green.Image = ((System.Drawing.Image)(resources.GetObject("btn_Green.Image")));
            this.btn_Green.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Green.Name = "btn_Green";
            this.btn_Green.Size = new System.Drawing.Size(47, 22);
            this.btn_Green.Text = "GREEN";
            this.btn_Green.Click += new System.EventHandler(this.btn_Green_Click);
            // 
            // btn_Purp
            // 
            this.btn_Purp.BackColor = System.Drawing.Color.Purple;
            this.btn_Purp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Purp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Purp.Image = ((System.Drawing.Image)(resources.GetObject("btn_Purp.Image")));
            this.btn_Purp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Purp.Name = "btn_Purp";
            this.btn_Purp.Size = new System.Drawing.Size(40, 22);
            this.btn_Purp.Text = "PURP";
            this.btn_Purp.Click += new System.EventHandler(this.btn_Purp_Click);
            // 
            // btn_Black
            // 
            this.btn_Black.BackColor = System.Drawing.Color.Black;
            this.btn_Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Black.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Black.Image = ((System.Drawing.Image)(resources.GetObject("btn_Black.Image")));
            this.btn_Black.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Black.Name = "btn_Black";
            this.btn_Black.Size = new System.Drawing.Size(47, 22);
            this.btn_Black.Text = "BLACK";
            this.btn_Black.Click += new System.EventHandler(this.btn_Black_Click);
            // 
            // pictureBox_Paint
            // 
            this.pictureBox_Paint.BackColor = System.Drawing.Color.White;
            this.pictureBox_Paint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Paint.Location = new System.Drawing.Point(0, 49);
            this.pictureBox_Paint.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox_Paint.Name = "pictureBox_Paint";
            this.pictureBox_Paint.Size = new System.Drawing.Size(300, 140);
            this.pictureBox_Paint.TabIndex = 2;
            this.pictureBox_Paint.TabStop = false;
            this.pictureBox_Paint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Paint_MouseClick);
            this.pictureBox_Paint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Paint_MouseMove);
            this.pictureBox_Paint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Paint_MouseClick);
            // 
            // form_Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 189);
            this.Controls.Add(this.pictureBox_Paint);
            this.Controls.Add(this.toolStrip_Paint);
            this.Controls.Add(this.menuStrip_Paint);
            this.MainMenuStrip = this.menuStrip_Paint;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "form_Paint";
            this.Text = "Paint On, My Dude!";
            this.menuStrip_Paint.ResumeLayout(false);
            this.menuStrip_Paint.PerformLayout();
            this.toolStrip_Paint.ResumeLayout(false);
            this.toolStrip_Paint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Paint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Paint;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip_Paint;
        private System.Windows.Forms.ToolStripButton btn_Red;
        private System.Windows.Forms.ToolStripButton btn_Blue;
        private System.Windows.Forms.ToolStripButton btn_Green;
        private System.Windows.Forms.ToolStripButton btn_Purp;
        private System.Windows.Forms.ToolStripButton btn_Black;
        private System.Windows.Forms.PictureBox pictureBox_Paint;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Paint;
    }
}

