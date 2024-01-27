namespace WebForms3
{
    partial class RadioButtons
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
            lblSelect = new Label();
            Rdbtn1 = new RadioButton();
            Rdbtn2 = new RadioButton();
            Rdbtn3 = new RadioButton();
            Rdbtn4 = new RadioButton();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Font = new Font("Wide Latin", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelect.Location = new Point(12, 9);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(797, 40);
            lblSelect.TabIndex = 0;
            lblSelect.Text = "Select one Person to proceed";
            // 
            // Rdbtn1
            // 
            Rdbtn1.AutoSize = true;
            Rdbtn1.Location = new Point(211, 88);
            Rdbtn1.Name = "Rdbtn1";
            Rdbtn1.Size = new Size(115, 29);
            Rdbtn1.TabIndex = 1;
            Rdbtn1.TabStop = true;
            Rdbtn1.Text = "Option A ";
            Rdbtn1.UseVisualStyleBackColor = true;
            // 
            // Rdbtn2
            // 
            Rdbtn2.AutoSize = true;
            Rdbtn2.Location = new Point(211, 136);
            Rdbtn2.Name = "Rdbtn2";
            Rdbtn2.Size = new Size(108, 29);
            Rdbtn2.TabIndex = 2;
            Rdbtn2.TabStop = true;
            Rdbtn2.Text = "Option B";
            Rdbtn2.UseVisualStyleBackColor = true;
            // 
            // Rdbtn3
            // 
            Rdbtn3.AutoSize = true;
            Rdbtn3.Location = new Point(211, 184);
            Rdbtn3.Name = "Rdbtn3";
            Rdbtn3.Size = new Size(109, 29);
            Rdbtn3.TabIndex = 3;
            Rdbtn3.TabStop = true;
            Rdbtn3.Text = "Option C";
            Rdbtn3.UseVisualStyleBackColor = true;
            // 
            // Rdbtn4
            // 
            Rdbtn4.AutoSize = true;
            Rdbtn4.Location = new Point(211, 233);
            Rdbtn4.Name = "Rdbtn4";
            Rdbtn4.Size = new Size(111, 29);
            Rdbtn4.TabIndex = 4;
            Rdbtn4.TabStop = true;
            Rdbtn4.Text = "Option D";
            Rdbtn4.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(650, 367);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(207, 58);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Next Page";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // RadioButtons
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 450);
            Controls.Add(btnEnter);
            Controls.Add(Rdbtn4);
            Controls.Add(Rdbtn3);
            Controls.Add(Rdbtn2);
            Controls.Add(Rdbtn1);
            Controls.Add(lblSelect);
            Name = "RadioButtons";
            Text = "RadioButtons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelect;
        private RadioButton Rdbtn1;
        private RadioButton Rdbtn2;
        private RadioButton Rdbtn3;
        private RadioButton Rdbtn4;
        private Button btnEnter;
    }
}