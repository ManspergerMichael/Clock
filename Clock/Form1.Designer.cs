namespace Clock
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
            this.components = new System.ComponentModel.Container();
            this.hourMinuteLable = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.weekdayLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hourMinuteLable
            // 
            this.hourMinuteLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourMinuteLable.ForeColor = System.Drawing.Color.DarkGreen;
            this.hourMinuteLable.Location = new System.Drawing.Point(230, 9);
            this.hourMinuteLable.Name = "hourMinuteLable";
            this.hourMinuteLable.Size = new System.Drawing.Size(243, 73);
            this.hourMinuteLable.TabIndex = 0;
            this.hourMinuteLable.Text = "19 : 25";
            // 
            // secondsLabel
            // 
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.secondsLabel.Location = new System.Drawing.Point(479, 9);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(111, 73);
            this.secondsLabel.TabIndex = 1;
            this.secondsLabel.Text = "42";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.dateLabel.Location = new System.Drawing.Point(213, 82);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(400, 73);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Jan 05 2018";
            // 
            // weekdayLabel
            // 
            this.weekdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekdayLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.weekdayLabel.Location = new System.Drawing.Point(213, 170);
            this.weekdayLabel.Name = "weekdayLabel";
            this.weekdayLabel.Size = new System.Drawing.Size(400, 73);
            this.weekdayLabel.TabIndex = 3;
            this.weekdayLabel.Text = "Friday";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(837, 424);
            this.Controls.Add(this.weekdayLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.hourMinuteLable);
            this.Name = "Form1";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hourMinuteLable;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label weekdayLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

