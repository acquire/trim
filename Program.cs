using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trim
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var text = Clipboard.GetText();
            var newline = new string[] { "\n", "\t" };
            var array = text.Split(newline, StringSplitOptions.None);
            var retval = "";
            foreach(var a in array)
            {
                var b = "";
                //remove "
                b = a.Replace("\"","");
                //remove "\r"
                b = b.Replace("\r", "");
                //wikipedia does "\t" at end of table cell
                b = b.Replace("\t", "");
                retval += b.Trim();
                retval += Environment.NewLine;
            }
            retval = retval.Trim();
            Clipboard.SetText(retval);
        }
    }
}
