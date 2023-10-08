namespace Project1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoThuNhat = new System.Windows.Forms.TextBox();
            this.Form = new System.Windows.Forms.GroupBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_SoThuHai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất :";
            // 
            // txt_SoThuNhat
            // 
            this.txt_SoThuNhat.AccessibleName = "";
            this.txt_SoThuNhat.Location = new System.Drawing.Point(176, 34);
            this.txt_SoThuNhat.Name = "txt_SoThuNhat";
            this.txt_SoThuNhat.Size = new System.Drawing.Size(161, 22);
            this.txt_SoThuNhat.TabIndex = 1;
            // 
            // Form
            // 
            this.Form.Controls.Add(this.button4);
            this.Form.Controls.Add(this.button3);
            this.Form.Controls.Add(this.button2);
            this.Form.Controls.Add(this.txt_Result);
            this.Form.Controls.Add(this.label3);
            this.Form.Controls.Add(this.button1);
            this.Form.Controls.Add(this.txt_SoThuHai);
            this.Form.Controls.Add(this.label2);
            this.Form.Controls.Add(this.txt_SoThuNhat);
            this.Form.Controls.Add(this.label1);
            this.Form.Location = new System.Drawing.Point(10, 0);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(778, 355);
            this.Form.TabIndex = 2;
            this.Form.TabStop = false;
            this.Form.Text = "Form";
            // 
            // txt_Result
            // 
            this.txt_Result.AccessibleName = "";
            this.txt_Result.Enabled = false;
            this.txt_Result.Location = new System.Drawing.Point(176, 129);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(161, 22);
            this.txt_Result.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(37, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_SoThuHai
            // 
            this.txt_SoThuHai.AccessibleName = "";
            this.txt_SoThuHai.Location = new System.Drawing.Point(176, 78);
            this.txt_SoThuHai.Name = "txt_SoThuHai";
            this.txt_SoThuHai.Size = new System.Drawing.Size(161, 22);
            this.txt_SoThuHai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số thứ hai :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(90, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(145, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(200, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Form);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Form.ResumeLayout(false);
            this.Form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoThuNhat;
        private System.Windows.Forms.GroupBox Form;
        private System.Windows.Forms.TextBox txt_SoThuHai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

