using System.Drawing;

namespace task1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.setColorBtn = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControl11 = new task1.UserControl1();
            this.customControl11 = new task1.CustomControl1();
            this.customControl12 = new task1.CustomControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // setColorBtn
            // 
            this.setColorBtn.Location = new System.Drawing.Point(81, 86);
            this.setColorBtn.Name = "setColorBtn";
            this.setColorBtn.Size = new System.Drawing.Size(83, 45);
            this.setColorBtn.TabIndex = 0;
            this.setColorBtn.Text = "set Color";
            this.setColorBtn.UseVisualStyleBackColor = true;
            this.setColorBtn.Click += new System.EventHandler(this.setColorBtn_Click);
            // 
            // testLabel
            // 
            this.testLabel.Location = new System.Drawing.Point(250, 100);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(111, 31);
            this.testLabel.TabIndex = 1;
            this.testLabel.Text = "test";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(609, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(363, 204);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(253, 165);
            this.userControl11.TabIndex = 3;
            // 
            // customControl11
            // 
            this.customControl11.Location = new System.Drawing.Point(518, 83);
            this.customControl11.Name = "customControl11";
            this.customControl11.Size = new System.Drawing.Size(75, 23);
            this.customControl11.TabIndex = 4;
            this.customControl11.Text = "customControl11";
            // 
            // customControl12
            // 
            this.customControl12.Location = new System.Drawing.Point(245, 223);
            this.customControl12.Name = "customControl12";
            this.customControl12.Size = new System.Drawing.Size(75, 23);
            this.customControl12.TabIndex = 5;
            this.customControl12.Text = "customControl12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customControl12);
            this.Controls.Add(this.customControl11);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.setColorBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button setColorBtn;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControl1 userControl11;
        private CustomControl1 customControl11;
        private CustomControl1 customControl12;
    }
}

