
namespace Форма_Хилл
{
    partial class Shifr
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
            this.Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Regestration_button = new System.Windows.Forms.Button();
            this.decrytpbox = new System.Windows.Forms.TextBox();
            this.keybox2 = new System.Windows.Forms.TextBox();
            this.wordtext2 = new System.Windows.Forms.TextBox();
            this.encryptbox = new System.Windows.Forms.TextBox();
            this.keybox1 = new System.Windows.Forms.TextBox();
            this.wordtext1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(177)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Regestration_button);
            this.panel1.Controls.Add(this.decrytpbox);
            this.panel1.Controls.Add(this.keybox2);
            this.panel1.Controls.Add(this.wordtext2);
            this.panel1.Controls.Add(this.encryptbox);
            this.panel1.Controls.Add(this.keybox1);
            this.panel1.Controls.Add(this.wordtext1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.Save.Location = new System.Drawing.Point(311, 403);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(126, 35);
            this.Save.TabIndex = 22;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(448, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 58);
            this.label6.TabIndex = 21;
            this.label6.Text = "Дешифрованное слово";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(331, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 33);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ключ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(331, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 33);
            this.label4.TabIndex = 19;
            this.label4.Text = "Слово";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 55);
            this.label2.TabIndex = 17;
            this.label2.Text = "Зашифрованное слово";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.button1.Location = new System.Drawing.Point(470, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Дешифровать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Regestration_button
            // 
            this.Regestration_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.Regestration_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regestration_button.FlatAppearance.BorderSize = 0;
            this.Regestration_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regestration_button.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.Regestration_button.Location = new System.Drawing.Point(128, 359);
            this.Regestration_button.Name = "Regestration_button";
            this.Regestration_button.Size = new System.Drawing.Size(164, 35);
            this.Regestration_button.TabIndex = 14;
            this.Regestration_button.Text = "Шифровать";
            this.Regestration_button.UseVisualStyleBackColor = false;
            this.Regestration_button.Click += new System.EventHandler(this.Regestration_button_Click);
            // 
            // decrytpbox
            // 
            this.decrytpbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrytpbox.Location = new System.Drawing.Point(470, 289);
            this.decrytpbox.Name = "decrytpbox";
            this.decrytpbox.Size = new System.Drawing.Size(157, 35);
            this.decrytpbox.TabIndex = 13;
            // 
            // keybox2
            // 
            this.keybox2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keybox2.Location = new System.Drawing.Point(470, 148);
            this.keybox2.Name = "keybox2";
            this.keybox2.Size = new System.Drawing.Size(157, 35);
            this.keybox2.TabIndex = 12;
            // 
            // wordtext2
            // 
            this.wordtext2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordtext2.Location = new System.Drawing.Point(470, 69);
            this.wordtext2.Name = "wordtext2";
            this.wordtext2.Size = new System.Drawing.Size(157, 35);
            this.wordtext2.TabIndex = 11;
            // 
            // encryptbox
            // 
            this.encryptbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptbox.Location = new System.Drawing.Point(128, 289);
            this.encryptbox.Name = "encryptbox";
            this.encryptbox.Size = new System.Drawing.Size(157, 35);
            this.encryptbox.TabIndex = 10;
            // 
            // keybox1
            // 
            this.keybox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keybox1.Location = new System.Drawing.Point(128, 148);
            this.keybox1.Name = "keybox1";
            this.keybox1.Size = new System.Drawing.Size(157, 35);
            this.keybox1.TabIndex = 9;
            // 
            // wordtext1
            // 
            this.wordtext1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordtext1.Location = new System.Drawing.Point(128, 69);
            this.wordtext1.Name = "wordtext1";
            this.wordtext1.Size = new System.Drawing.Size(157, 35);
            this.wordtext1.TabIndex = 8;
            // 
            // Shifr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Shifr";
            this.Text = "Shifr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shifr_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox decrytpbox;
        private System.Windows.Forms.TextBox keybox2;
        private System.Windows.Forms.TextBox wordtext2;
        private System.Windows.Forms.TextBox encryptbox;
        private System.Windows.Forms.TextBox keybox1;
        private System.Windows.Forms.TextBox wordtext1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Regestration_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save;
    }
}