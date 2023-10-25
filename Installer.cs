using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDoge_FirmwareInstaller
{
	internal abstract class Installer
	{


		public abstract void Install();


		public string HardwareName { get; protected set; }





		protected void RunProcess(ProcessStartInfo info)
		{
			var process = new Process { StartInfo = info };

			process.OutputDataReceived += (sender, e) =>
			{
				if (e.Data != null)
				{
					Console.WriteLine(e.Data);
				}
			};

			process.ErrorDataReceived += (sender, e) =>
			{
				if (e.Data != null)
				{
					Console.WriteLine(e.Data);
				}
			};
			process.Start();
			process.BeginOutputReadLine();
			process.BeginErrorReadLine();
			process.WaitForExit();
		}

	}
}
