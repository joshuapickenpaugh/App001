namespace App001
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
            this.btnPush01 = new System.Windows.Forms.Button();
            this.lblBox01 = new System.Windows.Forms.Label();
            this.txtBox01 = new System.Windows.Forms.TextBox();
            this.txtBox02 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPush01
            // 
            this.btnPush01.Location = new System.Drawing.Point(29, 231);
            this.btnPush01.Name = "btnPush01";
            this.btnPush01.Size = new System.Drawing.Size(100, 20);
            this.btnPush01.TabIndex = 0;
            this.btnPush01.Text = "PUSH";
            this.btnPush01.UseVisualStyleBackColor = true;
            this.btnPush01.Click += new System.EventHandler(this.btnPush01_Click);
            // 
            // lblBox01
            // 
            this.lblBox01.AutoSize = true;
            this.lblBox01.Location = new System.Drawing.Point(26, 168);
            this.lblBox01.Name = "lblBox01";
            this.lblBox01.Size = new System.Drawing.Size(35, 13);
            this.lblBox01.TabIndex = 1;
            this.lblBox01.Text = "label1";
            // 
            // txtBox01
            // 
            this.txtBox01.Location = new System.Drawing.Point(29, 47);
            this.txtBox01.Name = "txtBox01";
            this.txtBox01.Size = new System.Drawing.Size(100, 20);
            this.txtBox01.TabIndex = 2;
            // 
            // txtBox02
            // 
            this.txtBox02.Location = new System.Drawing.Point(29, 103);
            this.txtBox02.Name = "txtBox02";
            this.txtBox02.Size = new System.Drawing.Size(100, 20);
            this.txtBox02.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Year of Birth:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox02);
            this.Controls.Add(this.txtBox01);
            this.Controls.Add(this.lblBox01);
            this.Controls.Add(this.btnPush01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPush01;
        private System.Windows.Forms.Label lblBox01;
        private System.Windows.Forms.TextBox txtBox01;
        private System.Windows.Forms.TextBox txtBox02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

