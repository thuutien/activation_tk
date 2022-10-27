namespace activation_tk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bnt_10home = new System.Windows.Forms.Button();
            this.bnt_10pro = new System.Windows.Forms.Button();
            this.bnt_11home = new System.Windows.Forms.Button();
            this.bnt_11pro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows Activation ToolKit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(148, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Open-source software";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(149, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Version 1.0";
            // 
            // bnt_10home
            // 
            this.bnt_10home.Location = new System.Drawing.Point(81, 169);
            this.bnt_10home.Name = "bnt_10home";
            this.bnt_10home.Size = new System.Drawing.Size(137, 27);
            this.bnt_10home.TabIndex = 4;
            this.bnt_10home.Text = "Windows 10 Home";
            this.bnt_10home.UseVisualStyleBackColor = true;
            this.bnt_10home.Click += new System.EventHandler(this.bnt_10home_Click);
            // 
            // bnt_10pro
            // 
            this.bnt_10pro.Location = new System.Drawing.Point(81, 218);
            this.bnt_10pro.Name = "bnt_10pro";
            this.bnt_10pro.Size = new System.Drawing.Size(137, 27);
            this.bnt_10pro.TabIndex = 5;
            this.bnt_10pro.Text = "Windows 10 Pro";
            this.bnt_10pro.UseVisualStyleBackColor = true;
            this.bnt_10pro.Click += new System.EventHandler(this.bnt_10pro_Click);
            // 
            // bnt_11home
            // 
            this.bnt_11home.Location = new System.Drawing.Point(261, 169);
            this.bnt_11home.Name = "bnt_11home";
            this.bnt_11home.Size = new System.Drawing.Size(137, 27);
            this.bnt_11home.TabIndex = 6;
            this.bnt_11home.Text = "Windows 11 Home";
            this.bnt_11home.UseVisualStyleBackColor = true;
            this.bnt_11home.Click += new System.EventHandler(this.bnt_11home_Click);
            // 
            // bnt_11pro
            // 
            this.bnt_11pro.Location = new System.Drawing.Point(261, 218);
            this.bnt_11pro.Name = "bnt_11pro";
            this.bnt_11pro.Size = new System.Drawing.Size(137, 27);
            this.bnt_11pro.TabIndex = 7;
            this.bnt_11pro.Text = "Windows 11 Pro";
            this.bnt_11pro.UseVisualStyleBackColor = true;
            this.bnt_11pro.Click += new System.EventHandler(this.bnt_11pro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(502, 272);
            this.Controls.Add(this.bnt_11pro);
            this.Controls.Add(this.bnt_11home);
            this.Controls.Add(this.bnt_10pro);
            this.Controls.Add(this.bnt_10home);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Windows Activation ToolKit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnt_10home;
        private System.Windows.Forms.Button bnt_10pro;
        private System.Windows.Forms.Button bnt_11home;
        private System.Windows.Forms.Button bnt_11pro;
    }
}

