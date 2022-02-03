
namespace Форма_Хилл
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Regestration_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Passwordtext2 = new System.Windows.Forms.TextBox();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.Logintext = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(177)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.Regestration_button);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Passwordtext2);
            this.panel1.Controls.Add(this.Passwordtext);
            this.panel1.Controls.Add(this.Logintext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 388);
            this.panel1.TabIndex = 0;
            // 
            // Regestration_button
            // 
            this.Regestration_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.Regestration_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regestration_button.FlatAppearance.BorderSize = 0;
            this.Regestration_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regestration_button.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.Regestration_button.Location = new System.Drawing.Point(138, 269);
            this.Regestration_button.Name = "Regestration_button";
            this.Regestration_button.Size = new System.Drawing.Size(243, 35);
            this.Regestration_button.TabIndex = 6;
            this.Regestration_button.Text = "Зарегестрироваться";
            this.Regestration_button.UseVisualStyleBackColor = false;
            this.Regestration_button.Click += new System.EventHandler(this.Regestration_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторите пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите логин";
            // 
            // Passwordtext2
            // 
            this.Passwordtext2.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.Passwordtext2.Location = new System.Drawing.Point(314, 196);
            this.Passwordtext2.Name = "Passwordtext2";
            this.Passwordtext2.Size = new System.Drawing.Size(157, 35);
            this.Passwordtext2.TabIndex = 2;
            this.Passwordtext2.UseSystemPasswordChar = true;
            // 
            // Passwordtext
            // 
            this.Passwordtext.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.Passwordtext.Location = new System.Drawing.Point(314, 129);
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.Size = new System.Drawing.Size(157, 35);
            this.Passwordtext.TabIndex = 1;
            this.Passwordtext.UseSystemPasswordChar = true;
            // 
            // Logintext
            // 
            this.Logintext.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.Logintext.Location = new System.Drawing.Point(314, 62);
            this.Logintext.Name = "Logintext";
            this.Logintext.Size = new System.Drawing.Size(157, 35);
            this.Logintext.TabIndex = 0;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 388);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Passwordtext2;
        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.TextBox Logintext;
        private System.Windows.Forms.Button Regestration_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}