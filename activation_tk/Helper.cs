using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activation_tk
{
    internal class Helper
    {
        public static void activate(Windows version)
        {
            string key = "";

            switch (version)
            {
                case Windows.tenhome:
                    key = "slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                    break;
                case Windows.tenpro:
                    key = "slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX";
                    break;
                case Windows.elevenhome:
                    key = "slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                    break;
                case Windows.elevenpro:
                    key = "slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX";
                    break;
            }
            if (key != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                PowerShell ps = PowerShell.Create();
                ps.AddScript(key);
                ps.Invoke();
                ps.AddScript("slmgr /skms kms8.msguides.com");
                ps.Invoke();
                ps.AddScript("slmgr /ato");
                ps.Invoke();
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Activation completed!");
            }
            else
            {
                MessageBox.Show("Error occurred, key is empty");
            }
            



        }
        
    }

    internal enum Windows
    {
        tenhome,
        tenpro,
        elevenhome,
        elevenpro
    }
}
