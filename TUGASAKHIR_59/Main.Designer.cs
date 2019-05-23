namespace TUGASAKHIR_59
{
    partial class Main
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
            this.BinButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hexaButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OctalButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BinButton
            // 
            this.BinButton.Location = new System.Drawing.Point(441, 241);
            this.BinButton.Name = "BinButton";
            this.BinButton.Size = new System.Drawing.Size(143, 23);
            this.BinButton.TabIndex = 7;
            this.BinButton.Text = "Konversi ke Binary";
            this.BinButton.UseVisualStyleBackColor = true;
            this.BinButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(143, 270);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(441, 53);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hexaButton
            // 
            this.hexaButton.Location = new System.Drawing.Point(143, 241);
            this.hexaButton.Name = "hexaButton";
            this.hexaButton.Size = new System.Drawing.Size(143, 23);
            this.hexaButton.TabIndex = 5;
            this.hexaButton.Text = "Konversi ke Hexadecimal";
            this.hexaButton.UseVisualStyleBackColor = true;
            this.hexaButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selamat Datang\r\n<nama>";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OctalButton
            // 
            this.OctalButton.Location = new System.Drawing.Point(292, 241);
            this.OctalButton.Name = "OctalButton";
            this.OctalButton.Size = new System.Drawing.Size(143, 23);
            this.OctalButton.TabIndex = 9;
            this.OctalButton.Text = "Konversi ke Octal";
            this.OctalButton.UseVisualStyleBackColor = true;
            this.OctalButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Silahkan masukkan nilai desimal yang ingin dikonversikan";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TUGASAKHIR_59.Properties.Resources.form2fix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OctalButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BinButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.hexaButton);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "APLIKASI KONVERSI BILANGAN DESIMAL KE HEXADECIMAL, OCTAL, DAN BINARY";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BinButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button hexaButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OctalButton;
        private System.Windows.Forms.Label label2;
    }
}