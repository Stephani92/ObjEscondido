namespace OndeEstouNaCasa
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnGoDoor = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 171);
            this.textBox1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(44, 178);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(136, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go Here";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnGoDoor
            // 
            this.btnGoDoor.Location = new System.Drawing.Point(44, 216);
            this.btnGoDoor.Name = "btnGoDoor";
            this.btnGoDoor.Size = new System.Drawing.Size(447, 33);
            this.btnGoDoor.TabIndex = 2;
            this.btnGoDoor.Text = "Go through the door";
            this.btnGoDoor.UseVisualStyleBackColor = true;
            this.btnGoDoor.Click += new System.EventHandler(this.btnGoDoor_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(44, 261);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(447, 33);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(44, 316);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(447, 33);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 361);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGoDoor);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnGoDoor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnCheck;
    }
}

