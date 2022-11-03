using System;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
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
                case Windows.server2019e:
                    key = "slmgr /ipk WVDHN-86M7X-466P6-VHXV7-YY726";
                    break;
                case Windows.server2019s:
                    key = "slmgr /ipk N69G4-B89J2-4G8F4-WWYCC-J464C";
                    break;
                case Windows.server2019d:
                    key = "slmgr /ipk WMDGN-G9PQG-XVVXX-R3X43-63DFG";
                    break;
                case Windows.server2022s:
                    key = "slmgr /ipk VDYBN-27WPP-V4HQT-9VMD4-VMK7H";
                    break;
                case Windows.server2022d:
                    key = "slmgr /ipk WX4NM-KYWYW-QJJR4-XV3QB-6VM33";
                    break;
                default:
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
        public static void officeActivation(Office version)
        {
            string arch = "";

            switch (version)
            {
                case Office.Office2021p64:
                    arch = "cd C:\\Program Files\\Microsoft Office\\Office16";
                    break;
                case Office.Office2022p86:
                    arch = "cd C:\\Program Files(x86)\\Microsoft Office\\Office16";
                    break;
            }

            Cursor.Current = Cursors.WaitCursor;
            Process p = new Process()
            {
                StartInfo = new ProcessStartInfo("cmd.exe")
                {
                    RedirectStandardInput = true,
                    RedirectStandardOutput = false,
                    UseShellExecute = false,
                    Verb = "runas",
                    CreateNoWindow = false
                }
            };

            p.Start();
            p.StandardInput.WriteLine(arch);
            p.StandardInput.WriteLine("for /f %x in ('dir /b ..\\root\\Licenses16\\ProPlus2021VL_KMS*.xrm-ms') do cscript ospp.vbs /inslic:\"..\\root\\Licenses16\\%x\"");
            p.StandardInput.WriteLine("cscript ospp.vbs /setprt:1688");
            p.StandardInput.WriteLine("cscript ospp.vbs /unpkey:6F7TH >nul");
            p.StandardInput.WriteLine("cscript ospp.vbs /inpkey:FXYTK-NJJ8C-GB6DW-3DYQT-6F7TH");
            p.StandardInput.WriteLine("cscript ospp.vbs /sethst:s8.uk.to");
            p.StandardInput.WriteLine("cscript ospp.vbs /act");
            p.StandardInput.WriteLine("exit");
            
        }

        

    }

    internal enum Windows
    {
        tenhome,
        tenpro,
        elevenhome,
        elevenpro,
        server2019e,
        server2019s,
        server2019d,
        server2022s,
        server2022d,
    }
    internal enum Office
    {
        Office2021p64,
        Office2022p86,
    }
}
