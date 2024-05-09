using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
   
    public partial class secondForm : Form
    {
        //public event EventHandler<int> fontChanged;
        public event EventHandler<float> fontSizeChanged;
        public event EventHandler<Color> colorChanged;
        //public event EventHandler<int> boldChanged;
        //public event EventHandler<int> underlineChanged;
        public event EventHandler<FontStyle> styleChanged;

        public event EventHandler<Font> font_changed;


        public secondForm() 
        {
            /*######*/ List<string> strings = new List<string> { "GenericSansSerif", "GenericSerif", "GenericMonospace" };  // why cannot put string???????????
            //strings.Add(Microsoft Sans Serif);

            InitializeComponent();
            fontComboBox.DataSource = strings;
            //fontComboBox.DisplayMember = "Name";
            //fontComboBox.ValueMember = "";
        }

        private void customRB_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();                               // way to show before clicking ok???????
            Color c = colorDialog1.Color;
            colorChanged(this, c); 
        }

        //private void fontSizeComboBox_ValueChanged(object sender, EventArgs e)
        //{
        //    fontSizeChanged(this, (float) fontSizeComboBox.Value);
        //}

        //private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)   // how to get selected font???????
        //{
        //    fontChanged(this, fontComboBox.SelectedIndex);
        //}

        private void redRB_CheckedChanged(object sender, EventArgs e)
        {
            if (redRB.Checked)
            {
                colorChanged(this, Color.Red);
            }
        }

        private void blueRB_CheckedChanged(object sender, EventArgs e)        // 2 func can be merged?????
        {
            if (blueRB.Checked)
            {
                colorChanged(this, Color.Blue);
            }
        }

        //private void styleChB_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (boldChB.Checked)
        //        styleChanged(this, 1);

        //    else
        //        styleChanged(this, 0);

        //}

        //private void styleChB_CheckedChanged(object sender, EventArgs e)
        //{
        //    FontStyle style = FontStyle.Regular;
        //    if (boldChB.Checked)
        //        style = style | FontStyle.Bold;   // | means add the style??????


        //    if (italicChB.Checked)
        //        style = style | FontStyle.Italic;


        //    if (underlineChB.Checked)
        //        style = style | FontStyle.Underline;

        //    styleChanged(this, style);

        //}

        private void font_MouseUp(object sender, MouseEventArgs e)
        {
            FontStyle style = FontStyle.Regular;
            if (boldChB.Checked)
                style = style | FontStyle.Bold;   // | means add the style??????


            if (italicChB.Checked)
                style = style | FontStyle.Italic;


            if (underlineChB.Checked)
                style = style | FontStyle.Underline;

            FontFamily ff = FontFamily.GenericSansSerif;
            switch (fontComboBox.SelectedIndex)
            {
                case 0: ff = FontFamily.GenericSansSerif; break;
                case 1: ff = FontFamily.GenericSerif; break;
                case 2: ff = FontFamily.GenericMonospace; break;
            }

            float size = (float) fontSizeComboBox.Value;

            Font f = new Font(ff, size, style, GraphicsUnit.Pixel);
            font_changed(this, f);      // font change when mouse up for selected items "not including selected index in combobox"
        }



        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;
            if (boldChB.Checked)
                style = style | FontStyle.Bold;   // | means add the style??????


            if (italicChB.Checked)
                style = style | FontStyle.Italic;


            if (underlineChB.Checked)
                style = style | FontStyle.Underline;

            FontFamily ff = FontFamily.GenericSansSerif;
            switch (fontComboBox.SelectedIndex)
            {
                case 0: ff = FontFamily.GenericSansSerif; break;
                case 1: ff = FontFamily.GenericSerif; break;
                case 2: ff = FontFamily.GenericMonospace; break;
            }

            float size = (float)fontSizeComboBox.Value;

            Font f = new Font(ff, size, style, GraphicsUnit.Pixel);
            if (font_changed != null)   
                font_changed(this, f);
        }


        //private void fontSizeComboBox_MouseUp(object sender, MouseEventArgs e)
        //{
        //    FontStyle style = FontStyle.Regular;
        //    if (boldChB.Checked)
        //        style = style | FontStyle.Bold;   // | means add the style??????


        //    if (italicChB.Checked)
        //        style = style | FontStyle.Italic;


        //    if (underlineChB.Checked)
        //        style = style | FontStyle.Underline;

        //    FontFamily ff = FontFamily.GenericSansSerif;
        //    switch (fontComboBox.SelectedIndex)
        //    {
        //        case 0: ff = FontFamily.GenericSansSerif; break;
        //        case 1: ff = FontFamily.GenericSerif; break;
        //        case 2: ff = FontFamily.GenericMonospace; break;
        //    }

        //    float size = (float)fontSizeComboBox.Value;

        //    Font f = new Font(ff, size, style, GraphicsUnit.Pixel);
        //    font_changed(this, f);      // font change when mouse up for selected items "not including selected index in combobox"
        //}


        //private void boldChB_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (boldChB.Checked)
        //        boldChanged(this, 1);

        //    else boldChanged(this, 0);
        //}

        //private void underlineChB_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (underlineChB.Checked)
        //        underlineChanged(this, 1);

        //    else underlineChanged(this, 0);
        //}
    }
}
