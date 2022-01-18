namespace MonthCalendar
{
    partial class Form1
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
            this.monthCal = new System.Windows.Forms.MonthCalendar();
            this.btnTermin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCal
            // 
            this.monthCal.Location = new System.Drawing.Point(38, 18);
            this.monthCal.MaxSelectionCount = 14;
            this.monthCal.Name = "monthCal";
            this.monthCal.TabIndex = 0;
            // 
            // btnTermin
            // 
            this.btnTermin.Location = new System.Drawing.Point(38, 228);
            this.btnTermin.Name = "btnTermin";
            this.btnTermin.Size = new System.Drawing.Size(199, 56);
            this.btnTermin.TabIndex = 1;
            this.btnTermin.Text = "Odaberite termin";
            this.btnTermin.UseVisualStyleBackColor = true;
            this.btnTermin.Click += new System.EventHandler(this.btnTermin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 328);
            this.Controls.Add(this.btnTermin);
            this.Controls.Add(this.monthCal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCal;
        private System.Windows.Forms.Button btnTermin;
    }
}

