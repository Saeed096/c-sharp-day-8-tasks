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
    public partial class firstForm : Form
    {
        public firstForm()
        {
            InitializeComponent();
        }

        private void formatBtn_Click(object sender, EventArgs e)
        {
            secondForm secondForm = new secondForm();
            secondForm.font_changed += update_font;
            secondForm.colorChanged += changeColor;

            secondForm.Show();
          //  secondForm.fontChanged += changeFont;
          //  secondForm.fontSizeChanged += changeSize;
            //secondForm.boldChanged += makeBold;
            //secondForm.underlineChanged += makeUnderline;
         //   secondForm.styleChanged += changeStyle;


        }

        void update_font(object sender ,Font f)
        {
            nameTextBox.Font = f;
        }

        //void changeFont(object sender, int i)
        //{



        //    nameTextBox.Font = new System.Drawing.Font(FontFamily.GenericSerif, 10);                  // cannot set font or size????? 
        //    //Font f = new Font(s , 5);
        //    //nameTextBox.Font = f;               // cannot set font or size????? 
        //    //Font font = new Font(s, 12);
        //    //nameTextBox.Font = font;
        //}
        //FontFamily

        //void changeSize(object sender , float newSize)
        //{
        //    //Font font = new Font("arial", 12);
        //    nameTextBox.Font = new Font(nameTextBox.Font, newSize);                  // cannot set font or size????? 
        //}

        void changeColor(object sender, Color c) 
        {
            nameTextBox.ForeColor = c;
        }

        //void changeStyle(object sender, FontStyle f)
        //{
        //    nameTextBox.Font= new Font(nameTextBox.Font ,f);
        //}

        //void makeBold(object sender, int n) 
        //{
        //    if (n == 1)
        //  nameTextBox.Font = new Font(nameTextBox.Font , FontStyle.Bold);

        //    else
        //        nameTextBox.Font = new Font(nameTextBox.Font, FontStyle.Regular);
        //}

        //void makeUnderline(object sender, int n)
        //{
        //    if (n == 1)
        //        nameTextBox.Font = new Font(nameTextBox.Font, FontStyle.Underline);

        //    else
        //        nameTextBox.Font = new Font(nameTextBox.Font, FontStyle.Regular);
        //}


    }
}
