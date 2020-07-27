namespace EhlertProgram2
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
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Button_Submission = new System.Windows.Forms.Button();
            this.Label_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(527, 354);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(211, 20);
            this.TextBox_Name.TabIndex = 0;
            this.TextBox_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.Color.Yellow;
            this.Name_Label.Location = new System.Drawing.Point(410, 350);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(111, 24);
            this.Name_Label.TabIndex = 1;
            this.Name_Label.Text = "Enter Name";
            // 
            // Button_Submission
            // 
            this.Button_Submission.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Submission.Location = new System.Drawing.Point(527, 266);
            this.Button_Submission.Name = "Button_Submission";
            this.Button_Submission.Size = new System.Drawing.Size(135, 40);
            this.Button_Submission.TabIndex = 2;
            this.Button_Submission.Text = "Submit";
            this.Button_Submission.UseVisualStyleBackColor = true;
            this.Button_Submission.Click += new System.EventHandler(this.Submission_Click);
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Result.ForeColor = System.Drawing.Color.Yellow;
            this.Label_Result.Location = new System.Drawing.Point(523, 506);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(138, 24);
            this.Label_Result.TabIndex = 3;
            this.Label_Result.Text = "No Submission";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1368, 645);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Button_Submission);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.TextBox_Name);
            this.Name = "Form1";
            this.Text = "Name Retrieval App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Button Button_Submission;
        private System.Windows.Forms.Label Label_Result;
    }
}

