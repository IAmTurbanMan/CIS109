namespace MyWebBrowser
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.browserBar = new System.Windows.Forms.ToolStrip();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btn_Back = new System.Windows.Forms.ToolStripButton();
            this.btn_Forward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbo_Location = new System.Windows.Forms.ToolStripComboBox();
            this.btn_Go = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.browserBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // browserBar
            // 
            this.browserBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Back,
            this.btn_Forward,
            this.toolStripSeparator1,
            this.cbo_Location,
            this.btn_Go});
            this.browserBar.Location = new System.Drawing.Point(0, 0);
            this.browserBar.Name = "browserBar";
            this.browserBar.Size = new System.Drawing.Size(800, 25);
            this.browserBar.TabIndex = 0;
            this.browserBar.Text = "toolStrip1";
            // 
            // webBrowser
            // 
            this.webBrowser.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(0, 25);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(800, 425);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // btn_Back
            // 
            this.btn_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(36, 22);
            this.btn_Back.Text = "Back";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Forward.Image = ((System.Drawing.Image)(resources.GetObject("btn_Forward.Image")));
            this.btn_Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(54, 22);
            this.btn_Forward.Text = "Forward";
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cbo_Location
            // 
            this.cbo_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.cbo_Location.Name = "cbo_Location";
            this.cbo_Location.Size = new System.Drawing.Size(121, 25);
            this.cbo_Location.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_Location_KeyDown);
            // 
            // btn_Go
            // 
            this.btn_Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Go.Image = ((System.Drawing.Image)(resources.GetObject("btn_Go.Image")));
            this.btn_Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(26, 22);
            this.btn_Go.Text = "Go";
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.browserBar);
            this.Name = "frm_Main";
            this.Text = "Al Thawra";
            this.browserBar.ResumeLayout(false);
            this.browserBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip browserBar;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripButton btn_Back;
        private System.Windows.Forms.ToolStripButton btn_Forward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cbo_Location;
        private System.Windows.Forms.ToolStripButton btn_Go;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

