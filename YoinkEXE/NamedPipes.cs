using System;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace YoinkEXE
{
	internal class NamedPipes
	{
		public static string luapipename;

		static NamedPipes()
		{
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://pastebin.com/raw/zScPfXFQ");
            NamedPipes.luapipename = reply;
        }

		public NamedPipes()
		{
		}

		public static void LuaPipe(string script)
		{
			if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))
			{
				MessageBox.Show(string.Concat("Inject ", Functions.exploitdllname, " before Using this!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				(new Thread(() => {
					try
					{
						using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", NamedPipes.luapipename, PipeDirection.Out))
						{
							namedPipeClientStream.Connect();
							using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream, Encoding.Default, 999999))
							{
								streamWriter.Write(script);
								streamWriter.Dispose();
							}
							namedPipeClientStream.Dispose();
						}
					}
					catch (IOException oException)
					{
						MessageBox.Show("Error occured connecting to the pipe.", "Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					catch (Exception exception)
					{
						MessageBox.Show(exception.Message.ToString());
					}
				})).Start();
			}
		}

		internal static void LuaPipe(string v1, string text, string v2)
		{
			throw new NotImplementedException();
		}

		public static bool NamedPipeExist(string pipeName)
		{
			bool flag;
			bool flag1;
			try
			{
				if (!NamedPipes.WaitNamedPipe(Path.GetFullPath(string.Format("\\\\\\\\.\\\\pipe\\\\{0}", pipeName)), 0))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error == 0)
					{
						flag1 = false;
						return flag1;
					}
					else if (lastWin32Error == 2)
					{
						flag1 = false;
						return flag1;
					}
				}
				flag = true;
			}
			catch (Exception exception)
			{
				flag = false;
			}
			flag1 = flag;
			return flag1;
		}

		[DllImport("kernel32.dll", CharSet=CharSet.Auto, ExactSpelling=false, SetLastError=true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

        
    }
}