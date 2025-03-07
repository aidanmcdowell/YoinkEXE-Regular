using System;
using System.Threading;
using System.Windows.Forms;
using YoinkEXE;

namespace YoinkEXE
{
    internal class Functions
    {
        public static string exploitdllname;

        public static OpenFileDialog openfiledialog;
        internal static object savefiledialog;

        static Functions()
        {
            Functions.exploitdllname = "Yoink.dll";
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Lua Script Txt (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                Title = "Yoink Lua Open Script"
            };
            Functions.openfiledialog = openFileDialog;
        }

        public Functions()
        {
        }

        public static void Inject()
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                MessageBox.Show("Already injected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                switch (Injector.DllInjector.GetInstance.Inject("RobloxPlayerBeta", string.Concat(AppDomain.CurrentDomain.BaseDirectory, Functions.exploitdllname)))
                {
                    case Injector.DllInjectionResult.DllNotFound:
                        {
                            MessageBox.Show(string.Concat("couldn't find", Functions.exploitdllname), "Dll was not found!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            break;
                        }
                    case Injector.DllInjectionResult.GameProcessNotFound:
                        {
                            MessageBox.Show("Couldn't find RobloxPlayerBeta.exe!", "Target process was not found!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            break;
                        }
                    case Injector.DllInjectionResult.InjectionFailed:
                        {
                            MessageBox.Show("Injection Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            break;
                        }
                    default:
                        {
                            Thread.Sleep(3000);
                            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
                            {
                            }
                            break;
                        }
                }
            }
        }
    }
}