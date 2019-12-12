namespace MyDigitalCalendar
{
    partial class form_Calendar
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
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Seconds = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Day = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_Time
            // 
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(203, 39);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(266, 92);
            this.label_Time.TabIndex = 0;
            this.label_Time.Text = "18 : 20";
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Seconds
            // 
            this.label_Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Seconds.Location = new System.Drawing.Point(475, 39);
            this.label_Seconds.Name = "label_Seconds";
            this.label_Seconds.Size = new System.Drawing.Size(122, 92);
            this.label_Seconds.TabIndex = 1;
            this.label_Seconds.Text = "50";
            this.label_Seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Date
            // 
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(12, 165);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(776, 92);
            this.label_Date.TabIndex = 2;
            this.label_Date.Text = "06 November 2019";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Day
            // 
            this.label_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Day.Location = new System.Drawing.Point(12, 285);
            this.label_Day.Name = "label_Day";
            this.label_Day.Size = new System.Drawing.Size(776, 92);
            this.label_Day.TabIndex = 3;
            this.label_Day.Text = "Wednesday";
            this.label_Day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Day);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Seconds);
            this.Controls.Add(this.label_Time);
            this.Name = "form_Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.form_Calendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Seconds;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Day;
        private System.Windows.Forms.Timer timer1;
    }
}

