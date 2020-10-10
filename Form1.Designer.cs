namespace Username_Generator
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
            this.button_generate = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.button_about = new System.Windows.Forms.Button();
            this.pictureBox_img = new System.Windows.Forms.PictureBox();
            this.pictureBox_copy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_copy)).BeginInit();
            this.SuspendLayout();
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generate.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.button_generate.Location = new System.Drawing.Point(121, 181);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(126, 30);
            this.button_generate.TabIndex = 0;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_username.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBox_username.Location = new System.Drawing.Point(84, 130);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(202, 20);
            this.textBox_username.TabIndex = 1;
            this.textBox_username.Text = "Your Username";
            this.textBox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_about
            // 
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Candara", 8.75F);
            this.button_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.button_about.Location = new System.Drawing.Point(306, 251);
            this.button_about.Margin = new System.Windows.Forms.Padding(2);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(51, 25);
            this.button_about.TabIndex = 2;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox_img
            // 
            this.pictureBox_img.Image = global::Username_Generator.Properties.Resources.username;
            this.pictureBox_img.Location = new System.Drawing.Point(139, 11);
            this.pictureBox_img.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_img.Name = "pictureBox_img";
            this.pictureBox_img.Size = new System.Drawing.Size(95, 97);
            this.pictureBox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_img.TabIndex = 3;
            this.pictureBox_img.TabStop = false;
            // 
            // pictureBox_copy
            // 
            this.pictureBox_copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_copy.Image = global::Username_Generator.Properties.Resources.copy;
            this.pictureBox_copy.Location = new System.Drawing.Point(60, 125);
            this.pictureBox_copy.Name = "pictureBox_copy";
            this.pictureBox_copy.Size = new System.Drawing.Size(22, 30);
            this.pictureBox_copy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_copy.TabIndex = 4;
            this.pictureBox_copy.TabStop = false;
            this.pictureBox_copy.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(368, 287);
            this.Controls.Add(this.pictureBox_copy);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.pictureBox_img);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.button_generate);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Username Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_copy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.PictureBox pictureBox_img;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.PictureBox pictureBox_copy;
    }
}

