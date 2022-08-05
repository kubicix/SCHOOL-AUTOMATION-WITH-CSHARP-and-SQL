namespace Student_Grade_System
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTeacherPass = new System.Windows.Forms.TextBox();
            this.TxtStudentPass = new System.Windows.Forms.TextBox();
            this.BtnTeacherLogin = new System.Windows.Forms.Button();
            this.BtnStudentLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MskTeacherNumber = new System.Windows.Forms.MaskedTextBox();
            this.MskStudentNumber = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MskTeacherNumber);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.BtnTeacherLogin);
            this.groupBox1.Controls.Add(this.TxtTeacherPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(419, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MskStudentNumber);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.BtnStudentLogin);
            this.groupBox2.Controls.Add(this.TxtStudentPass);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(41, 230);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(419, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(171, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(158, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(171, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(158, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password :";
            // 
            // TxtTeacherPass
            // 
            this.TxtTeacherPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTeacherPass.Location = new System.Drawing.Point(250, 80);
            this.TxtTeacherPass.Name = "TxtTeacherPass";
            this.TxtTeacherPass.PasswordChar = '*';
            this.TxtTeacherPass.Size = new System.Drawing.Size(100, 20);
            this.TxtTeacherPass.TabIndex = 3;
            // 
            // TxtStudentPass
            // 
            this.TxtStudentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentPass.Location = new System.Drawing.Point(250, 89);
            this.TxtStudentPass.Name = "TxtStudentPass";
            this.TxtStudentPass.PasswordChar = '*';
            this.TxtStudentPass.Size = new System.Drawing.Size(100, 20);
            this.TxtStudentPass.TabIndex = 5;
            // 
            // BtnTeacherLogin
            // 
            this.BtnTeacherLogin.Location = new System.Drawing.Point(250, 106);
            this.BtnTeacherLogin.Name = "BtnTeacherLogin";
            this.BtnTeacherLogin.Size = new System.Drawing.Size(100, 23);
            this.BtnTeacherLogin.TabIndex = 4;
            this.BtnTeacherLogin.Text = "Login";
            this.BtnTeacherLogin.UseVisualStyleBackColor = true;
            this.BtnTeacherLogin.Click += new System.EventHandler(this.BtnTeacherLogin_Click);
            // 
            // BtnStudentLogin
            // 
            this.BtnStudentLogin.Location = new System.Drawing.Point(250, 115);
            this.BtnStudentLogin.Name = "BtnStudentLogin";
            this.BtnStudentLogin.Size = new System.Drawing.Size(100, 23);
            this.BtnStudentLogin.TabIndex = 6;
            this.BtnStudentLogin.Text = "Login";
            this.BtnStudentLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // MskTeacherNumber
            // 
            this.MskTeacherNumber.Location = new System.Drawing.Point(250, 43);
            this.MskTeacherNumber.Mask = "0000";
            this.MskTeacherNumber.Name = "MskTeacherNumber";
            this.MskTeacherNumber.Size = new System.Drawing.Size(100, 20);
            this.MskTeacherNumber.TabIndex = 9;
            this.MskTeacherNumber.ValidatingType = typeof(int);
            // 
            // MskStudentNumber
            // 
            this.MskStudentNumber.Location = new System.Drawing.Point(250, 50);
            this.MskStudentNumber.Mask = "0000";
            this.MskStudentNumber.Name = "MskStudentNumber";
            this.MskStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.MskStudentNumber.TabIndex = 10;
            this.MskStudentNumber.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Student Grade System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox MskTeacherNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnTeacherLogin;
        private System.Windows.Forms.TextBox TxtTeacherPass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnStudentLogin;
        private System.Windows.Forms.TextBox TxtStudentPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskStudentNumber;
    }
}

