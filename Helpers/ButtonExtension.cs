using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma2020.Helpers
{
    static class ButtonExtension
    {
        public static Button BigBtnSetStyle(this Button btn, string text)
        {
            btn.Size = new System.Drawing.Size(300, 50);
            btn.BackgroundImage = Properties.Resources.BigBtn;
            btn.Text = text;
            btn.Margin = new Padding(3);
            return btn;
        }

        public static Button SmallBtnSetStyle(this Button btn, string text)
        {
            btn.Size = new System.Drawing.Size(175, 50);
            btn.BackgroundImage = Properties.Resources.BigBtn;
            btn.Text = text;
            btn.Margin = new Padding(3);
            return btn;
        }
    }
}
