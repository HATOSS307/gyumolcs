using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyumolcsok_forms
{
    internal static class Program
    {
        //-- 2022.11-28
        static public Form_nyito formgyumolcs_nyito = null;
        static public form_delete formgyumolcs_delete = null;
        static public modosit formgyumolcs_edit = null;
        static public form_new formgyumolcs_new = null;


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formgyumolcs_edit = new modosit();
            formgyumolcs_delete = new form_delete();
            formgyumolcs_new = new form_new();
            formgyumolcs_nyito = new Form_nyito();
            Application.Run(new Form_nyito());
        }
    }
}
