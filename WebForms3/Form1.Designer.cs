namespace WebForms3
{
    partial class DateTimeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            lblDate1 = new Label();
            lblDate2 = new Label();
            lblDate3 = new Label();
            lblTime1 = new Label();
            lblTime2 = new Label();
            btnShow = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(140, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(587, 42);
            dateTimePicker1.TabIndex = 0;
            // 
            // lblDate1
            // 
            lblDate1.AutoSize = true;
            lblDate1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate1.Location = new Point(132, 128);
            lblDate1.Name = "lblDate1";
            lblDate1.Size = new Size(149, 32);
            lblDate1.TabIndex = 1;
            lblDate1.Text = "Show Date 1";
            // 
            // lblDate2
            // 
            lblDate2.AutoSize = true;
            lblDate2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate2.Location = new Point(132, 178);
            lblDate2.Name = "lblDate2";
            lblDate2.Size = new Size(152, 32);
            lblDate2.TabIndex = 2;
            lblDate2.Text = "Show Date 2";
            // 
            // lblDate3
            // 
            lblDate3.AutoSize = true;
            lblDate3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate3.Location = new Point(132, 230);
            lblDate3.Name = "lblDate3";
            lblDate3.Size = new Size(152, 32);
            lblDate3.TabIndex = 3;
            lblDate3.Text = "Show Date 3";
            // 
            // lblTime1
            // 
            lblTime1.AutoSize = true;
            lblTime1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime1.Location = new Point(132, 274);
            lblTime1.Name = "lblTime1";
            lblTime1.Size = new Size(150, 32);
            lblTime1.TabIndex = 4;
            lblTime1.Text = "Show Time 1";
            // 
            // lblTime2
            // 
            lblTime2.AutoSize = true;
            lblTime2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime2.Location = new Point(133, 319);
            lblTime2.Name = "lblTime2";
            lblTime2.Size = new Size(153, 32);
            lblTime2.TabIndex = 5;
            lblTime2.Text = "Show Time 2";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(625, 380);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(154, 58);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // DateTimeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Controls.Add(lblTime2);
            Controls.Add(lblTime1);
            Controls.Add(lblDate3);
            Controls.Add(lblDate2);
            Controls.Add(lblDate1);
            Controls.Add(dateTimePicker1);
            Name = "DateTimeForm";
            Text = "Form1";
            KeyPress += DateTimeForm_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label lblDate1;
        private Label lblDate2;
        private Label lblDate3;
        private Label lblTime1;
        private Label lblTime2;
        private Button btnShow;
    }
}
