namespace Countermanagement
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
            this.btncounter1 = new System.Windows.Forms.Button();
            this.btncounter2 = new System.Windows.Forms.Button();
            this.btncounter3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Token = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncounter1
            // 
            this.btncounter1.Location = new System.Drawing.Point(95, 66);
            this.btncounter1.Name = "btncounter1";
            this.btncounter1.Size = new System.Drawing.Size(96, 23);
            this.btncounter1.TabIndex = 0;
            this.btncounter1.Text = "Counter1";
            this.btncounter1.UseVisualStyleBackColor = true;
            this.btncounter1.Click += new System.EventHandler(this.btncounter1_Click);
            // 
            // btncounter2
            // 
            this.btncounter2.Location = new System.Drawing.Point(260, 66);
            this.btncounter2.Name = "btncounter2";
            this.btncounter2.Size = new System.Drawing.Size(96, 23);
            this.btncounter2.TabIndex = 0;
            this.btncounter2.Text = "Counter2";
            this.btncounter2.UseVisualStyleBackColor = true;
            this.btncounter2.Click += new System.EventHandler(this.btncounter2_Click);
            // 
            // btncounter3
            // 
            this.btncounter3.Location = new System.Drawing.Point(436, 66);
            this.btncounter3.Name = "btncounter3";
            this.btncounter3.Size = new System.Drawing.Size(96, 23);
            this.btncounter3.TabIndex = 0;
            this.btncounter3.Text = "Counter3";
            this.btncounter3.UseVisualStyleBackColor = true;
            this.btncounter3.Click += new System.EventHandler(this.btncounter3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Green;
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(88, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Location = new System.Drawing.Point(254, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.Blue;
            this.textBox3.Location = new System.Drawing.Point(430, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Token
            // 
            this.Token.Location = new System.Drawing.Point(47, 223);
            this.Token.Name = "Token";
            this.Token.Size = new System.Drawing.Size(83, 26);
            this.Token.TabIndex = 2;
            this.Token.Text = "Token";
            this.Token.UseVisualStyleBackColor = true;
            this.Token.Click += new System.EventHandler(this.Token_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(136, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wating client list for service";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(390, 190);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(35, 13);
            this.lblmsg.TabIndex = 5;
            this.lblmsg.Text = "label2";
            this.lblmsg.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Token);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btncounter3);
            this.Controls.Add(this.btncounter2);
            this.Controls.Add(this.btncounter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncounter1;
        private System.Windows.Forms.Button btncounter2;
        private System.Windows.Forms.Button btncounter3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Token;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmsg;
    }
}

