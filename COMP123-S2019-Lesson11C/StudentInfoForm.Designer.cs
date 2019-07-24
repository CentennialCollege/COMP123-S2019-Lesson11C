namespace COMP123_S2019_Lesson11C
{
    partial class StudentInfoForm
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDDataLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.StudentIDDataLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.Location = new System.Drawing.Point(178, 31);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(219, 62);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IDDataLabel
            // 
            this.IDDataLabel.BackColor = System.Drawing.Color.White;
            this.IDDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDDataLabel.Location = new System.Drawing.Point(403, 31);
            this.IDDataLabel.Name = "IDDataLabel";
            this.IDDataLabel.Size = new System.Drawing.Size(183, 62);
            this.IDDataLabel.TabIndex = 0;
            this.IDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.Location = new System.Drawing.Point(170, 114);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(227, 62);
            this.StudentIDLabel.TabIndex = 0;
            this.StudentIDLabel.Text = "StudentID";
            this.StudentIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentIDDataLabel
            // 
            this.StudentIDDataLabel.BackColor = System.Drawing.Color.White;
            this.StudentIDDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentIDDataLabel.Location = new System.Drawing.Point(403, 114);
            this.StudentIDDataLabel.Name = "StudentIDDataLabel";
            this.StudentIDDataLabel.Size = new System.Drawing.Size(183, 62);
            this.StudentIDDataLabel.TabIndex = 0;
            this.StudentIDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Location = new System.Drawing.Point(170, 192);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(227, 62);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.White;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameDataLabel.Location = new System.Drawing.Point(403, 192);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(183, 62);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(170, 271);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(227, 62);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.BackColor = System.Drawing.Color.White;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameDataLabel.Location = new System.Drawing.Point(403, 271);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(183, 62);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 473);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(174, 59);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LastNameDataLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameDataLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.StudentIDDataLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.IDDataLabel);
            this.Controls.Add(this.IDLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "StudentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info Form";
            this.UseWaitCursor = true;
            this.Activated += new System.EventHandler(this.StudentInfoForm_Activate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentInfoForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label IDDataLabel;
        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.Label StudentIDDataLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Button BackButton;
    }
}