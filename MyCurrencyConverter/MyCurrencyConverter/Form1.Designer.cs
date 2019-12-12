namespace MyCurrencyConverter
{
    partial class form_CurrencyConverter
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
            this.btn_Converter = new System.Windows.Forms.Button();
            this.brwsr_Converter = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btn_Converter
            // 
            this.btn_Converter.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Converter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Converter.Location = new System.Drawing.Point(12, 12);
            this.btn_Converter.Name = "btn_Converter";
            this.btn_Converter.Size = new System.Drawing.Size(506, 49);
            this.btn_Converter.TabIndex = 0;
            this.btn_Converter.Text = "Currency Converter";
            this.btn_Converter.UseVisualStyleBackColor = false;
            this.btn_Converter.Click += new System.EventHandler(this.btn_Converter_Click);
            // 
            // brwsr_Converter
            // 
            this.brwsr_Converter.Location = new System.Drawing.Point(13, 68);
            this.brwsr_Converter.MinimumSize = new System.Drawing.Size(20, 20);
            this.brwsr_Converter.Name = "brwsr_Converter";
            this.brwsr_Converter.Size = new System.Drawing.Size(505, 224);
            this.brwsr_Converter.TabIndex = 1;
            this.brwsr_Converter.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // form_CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 304);
            this.Controls.Add(this.brwsr_Converter);
            this.Controls.Add(this.btn_Converter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_CurrencyConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Converter;
        private System.Windows.Forms.WebBrowser brwsr_Converter;
    }
}

