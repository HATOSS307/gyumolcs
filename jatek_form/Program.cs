using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatek_form
{
    internal static class Program
    {
        static public Form_nyito form_Nyito = null;
        static public form_delete form_Delete = null;
        static public form_edit form_Edit = null;
        static public form_rogzit form_Rogzit = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_Delete = new form_delete();
            form_Nyito = new Form_nyito();
            form_Edit = new form_edit();
            form_Rogzit = new form_rogzit();
            Application.Run(new Form_nyito());
        }

    }

}
