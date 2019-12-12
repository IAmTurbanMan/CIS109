namespace MyDigitalClock
{
    partial class form_DigtalClock
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
            this.label_DigitalClock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_DigitalClock
            // 
            this.label_DigitalClock.Font = new System.Drawing.Font("Yu Gothic UI Light", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DigitalClock.ForeColor = System.Drawing.Color.Linen;
            this.label_DigitalClock.Location = new System.Drawing.Point(62, 74);
            this.label_DigitalClock.Name = "label_DigitalClock";
            this.label_DigitalClock.Size = new System.Drawing.Size(677, 197);
            this.label_DigitalClock.TabIndex = 0;
            this.label_DigitalClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_DigtalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.label_DigitalClock);
            this.MinimizeBox = false;
            this.Name = "form_DigtalClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.form_DigtalClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_DigitalClock;
    }
}

