using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class ViewModel
    {
        private Form1 _form1;

        public ViewModel(Form1 form1)
        {
            _form1 = form1;
            /*The loop is leveraged to search the button among controls
            And once it is found, the click event of that related button
            * will be raised */
            foreach (Control item in _form1.Controls)
            {
                if (item is Button)
                {
                    (item as Button).Click += new EventHandler(ViewModel_Click);
                }
            }
            //This will lunch the form1 instance
            Application.Run(_form1);
        }

        protected void ViewModel_Click(object sender, EventArgs args)
        {
            int result = 0;
            int cumul;
            foreach (Control item in _form1.Controls)
            {
                if (item is TextBox)
                {
                    if (int.TryParse((item as TextBox).Text, out cumul))
                    {
                        result += cumul;
                    }
                }
            }
            foreach (Control item in _form1.Controls)
            {
                /* As we remark here, we use the TabIndex property
                * to precise which label will be used to dislpay the
                result as we have three labels in the scene */
                if (item is Label && item.TabIndex == 5)
                {
                    (item as Label).Text = result.ToString();
                }
            }
        }
    }
}
