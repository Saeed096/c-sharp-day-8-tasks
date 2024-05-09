using System.Drawing;
using System.Drawing.Text;

namespace Task
{
    partial class secondForm
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
            this.fontFormatGB = new System.Windows.Forms.GroupBox();
            this.fontSizeComboBox = new System.Windows.Forms.NumericUpDown();
            this.italicChB = new System.Windows.Forms.CheckBox();
            this.underlineChB = new System.Windows.Forms.CheckBox();
            this.boldChB = new System.Windows.Forms.CheckBox();
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontNameLabel = new System.Windows.Forms.Label();
            this.colorFormatGB = new System.Windows.Forms.GroupBox();
            this.customRB = new System.Windows.Forms.RadioButton();
            this.blueRB = new System.Windows.Forms.RadioButton();
            this.redRB = new System.Windows.Forms.RadioButton();
            this.applyBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontFormatGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeComboBox)).BeginInit();
            this.colorFormatGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontFormatGB
            // 
            this.fontFormatGB.Controls.Add(this.fontSizeComboBox);
            this.fontFormatGB.Controls.Add(this.italicChB);
            this.fontFormatGB.Controls.Add(this.underlineChB);
            this.fontFormatGB.Controls.Add(this.boldChB);
            this.fontFormatGB.Controls.Add(this.fontComboBox);
            this.fontFormatGB.Controls.Add(this.fontSizeLabel);
            this.fontFormatGB.Controls.Add(this.fontNameLabel);
            this.fontFormatGB.Location = new System.Drawing.Point(26, 53);
            this.fontFormatGB.Name = "fontFormatGB";
            this.fontFormatGB.Size = new System.Drawing.Size(220, 173);
            this.fontFormatGB.TabIndex = 0;
            this.fontFormatGB.TabStop = false;
            this.fontFormatGB.Text = "font Format";
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.Location = new System.Drawing.Point(90, 92);
            this.fontSizeComboBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(120, 22);
            this.fontSizeComboBox.TabIndex = 7;
            this.fontSizeComboBox.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.fontSizeComboBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.font_MouseUp);
            // 
            // italicChB
            // 
            this.italicChB.AutoSize = true;
            this.italicChB.Location = new System.Drawing.Point(149, 141);
            this.italicChB.Name = "italicChB";
            this.italicChB.Size = new System.Drawing.Size(32, 20);
            this.italicChB.TabIndex = 6;
            this.italicChB.Text = "I";
            this.italicChB.UseVisualStyleBackColor = true;
            this.italicChB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.font_MouseUp);
            // 
            // underlineChB
            // 
            this.underlineChB.AutoSize = true;
            this.underlineChB.Location = new System.Drawing.Point(90, 141);
            this.underlineChB.Name = "underlineChB";
            this.underlineChB.Size = new System.Drawing.Size(39, 20);
            this.underlineChB.TabIndex = 5;
            this.underlineChB.Text = "U";
            this.underlineChB.UseVisualStyleBackColor = true;
            this.underlineChB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.font_MouseUp);
            // 
            // boldChB
            // 
            this.boldChB.AutoSize = true;
            this.boldChB.Location = new System.Drawing.Point(37, 141);
            this.boldChB.Name = "boldChB";
            this.boldChB.Size = new System.Drawing.Size(38, 20);
            this.boldChB.TabIndex = 4;
            this.boldChB.Text = "B";
            this.boldChB.UseVisualStyleBackColor = true;
            this.boldChB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.font_MouseUp);
            // 
            // fontComboBox
            // 
            this.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox.FormattingEnabled = true;
            this.fontComboBox.Location = new System.Drawing.Point(90, 41);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(121, 24);
            this.fontComboBox.TabIndex = 3;
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
         //   this.fontComboBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.font_MouseUp);
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(6, 94);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(55, 16);
            this.fontSizeLabel.TabIndex = 2;
            this.fontSizeLabel.Text = "font size";
            this.fontSizeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.font_MouseUp);
            // 
            // fontNameLabel
            // 
            this.fontNameLabel.AutoSize = true;
            this.fontNameLabel.Location = new System.Drawing.Point(6, 44);
            this.fontNameLabel.Name = "fontNameLabel";
            this.fontNameLabel.Size = new System.Drawing.Size(65, 16);
            this.fontNameLabel.TabIndex = 1;
            this.fontNameLabel.Text = "font name";
            this.fontNameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.font_MouseUp);
            // 
            // colorFormatGB
            // 
            this.colorFormatGB.Controls.Add(this.customRB);
            this.colorFormatGB.Controls.Add(this.blueRB);
            this.colorFormatGB.Controls.Add(this.redRB);
            this.colorFormatGB.Location = new System.Drawing.Point(305, 53);
            this.colorFormatGB.Name = "colorFormatGB";
            this.colorFormatGB.Size = new System.Drawing.Size(220, 173);
            this.colorFormatGB.TabIndex = 7;
            this.colorFormatGB.TabStop = false;
            this.colorFormatGB.Text = "colorFormat";
            // 
            // customRB
            // 
            this.customRB.AutoSize = true;
            this.customRB.Location = new System.Drawing.Point(15, 131);
            this.customRB.Name = "customRB";
            this.customRB.Size = new System.Drawing.Size(71, 20);
            this.customRB.TabIndex = 2;
            this.customRB.TabStop = true;
            this.customRB.Text = "custom";
            this.customRB.UseVisualStyleBackColor = true;
            this.customRB.Click += new System.EventHandler(this.customRB_Click);
            // 
            // blueRB
            // 
            this.blueRB.AutoSize = true;
            this.blueRB.Location = new System.Drawing.Point(15, 90);
            this.blueRB.Name = "blueRB";
            this.blueRB.Size = new System.Drawing.Size(54, 20);
            this.blueRB.TabIndex = 1;
            this.blueRB.TabStop = true;
            this.blueRB.Text = "blue";
            this.blueRB.UseVisualStyleBackColor = true;
            this.blueRB.CheckedChanged += new System.EventHandler(this.blueRB_CheckedChanged);
            // 
            // redRB
            // 
            this.redRB.AutoSize = true;
            this.redRB.Location = new System.Drawing.Point(15, 50);
            this.redRB.Name = "redRB";
            this.redRB.Size = new System.Drawing.Size(54, 20);
            this.redRB.TabIndex = 0;
            this.redRB.TabStop = true;
            this.redRB.Text = "Red";
            this.redRB.UseVisualStyleBackColor = true;
            this.redRB.CheckedChanged += new System.EventHandler(this.redRB_CheckedChanged);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(228, 261);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 8;
            this.applyBtn.Text = "apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            // 
            // secondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 296);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.colorFormatGB);
            this.Controls.Add(this.fontFormatGB);
            this.Name = "secondForm";
            this.Text = "Trainees";
            this.fontFormatGB.ResumeLayout(false);
            this.fontFormatGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeComboBox)).EndInit();
            this.colorFormatGB.ResumeLayout(false);
            this.colorFormatGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fontFormatGB;
        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.Label fontNameLabel;
        private System.Windows.Forms.CheckBox italicChB;
        private System.Windows.Forms.CheckBox underlineChB;
        private System.Windows.Forms.CheckBox boldChB;
        private System.Windows.Forms.GroupBox colorFormatGB;
        private System.Windows.Forms.RadioButton customRB;
        private System.Windows.Forms.RadioButton blueRB;
        private System.Windows.Forms.RadioButton redRB;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.NumericUpDown fontSizeComboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}