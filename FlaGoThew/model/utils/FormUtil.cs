using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaGoThew.model.utils
{
    public class FormUtil
    {
        public static void SwapForm(Form current, Form next)
        {
            current.Hide();
            next.Show();
            next.Closed += (s, args) => current.Close();
        }

    }
}
