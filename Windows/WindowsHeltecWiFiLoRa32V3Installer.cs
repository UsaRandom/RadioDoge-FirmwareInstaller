using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace RadioDoge_FirmwareInstaller.Windows
{
	
	internal class WindowsHeltecWiFiLoRa32V3Installer : Installer
	{

		public WindowsHeltecWiFiLoRa32V3Installer()
		{
			HardwareName = "Heltec WiFi LoRa 32 V3";
		}

		public override void Install()
		{
			InstallDriver();

			Upload();
		}



		private void InstallDriver()
		{
			string infPath = @".\Content\drivers\cp210x\silabser.inf"; // Replace with your .inf path

			RunProcess(new ProcessStartInfo
			{
				FileName = "pnputil.exe",
				Arguments = $"/add-driver \"{infPath}\" /install",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true,
				RedirectStandardError = true
			});

		}





		private void Upload()
		{

			var comPort = GetCOMPort();

			if(comPort == string.Empty)
			{
				Console.WriteLine("Can't determine COM Port for Device!");
				Console.WriteLine("It is likely the driver failed to install.");
				Console.WriteLine("Ensure you ran this as Administrator!");
				Console.WriteLine("Failed!");
				Console.ReadLine();
				return;
			}



			RunProcess(new ProcessStartInfo
			{
				FileName = @".\Content\arduino-cli.exe",
				Arguments = $"core update-index --additional-urls \"https://github.com/Heltec-Aaron-Lee/WiFi_Kit_series/releases/download/0.0.9/package_heltec_esp32_index.json\"",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true,
				RedirectStandardError = true
			});

			RunProcess(new ProcessStartInfo
			{
				FileName = @".\Content\arduino-cli.exe",
				Arguments = $"update --additional-urls \"https://github.com/Heltec-Aaron-Lee/WiFi_Kit_series/releases/download/0.0.9/package_heltec_esp32_index.json\"",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true,
				RedirectStandardError = true
			});

			RunProcess(new ProcessStartInfo
			{
				FileName = @".\Content\arduino-cli.exe",
				Arguments = $"core install Heltec-esp32:esp32 --additional-urls \"https://github.com/Heltec-Aaron-Lee/WiFi_Kit_series/releases/download/0.0.9/package_heltec_esp32_index.json\"",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true,
				RedirectStandardError = true
			});


			RunProcess(new ProcessStartInfo
			{
				FileName = @".\Content\arduino-cli.exe",
				Arguments = $"lib install \"Heltec ESP32 Dev-Boards\" --additional-urls \"https://github.com/Heltec-Aaron-Lee/WiFi_Kit_series/releases/download/0.0.9/package_heltec_esp32_index.json\"",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true,
				RedirectStandardError = true
			});
			
			Console.WriteLine("Compiling... this may take a moment.");

			RunProcess(new ProcessStartInfo
			{
				FileName = @".\Content\arduino-cli.exe",
				Arguments = $"compile -b Heltec-esp32:esp32:WIFI_LoRa_32_V3 ./Content/heltec-firmware/ --additional-urls \"https://github.com/Heltec-Aaron-Lee/WiFi_Kit_series/releases/download/0.0.9/package_heltec_esp32_index.json\"",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true,
				RedirectStandardError = true
			});

			RunProcess(new ProcessStartInfo
			{
				FileName = @".\Content\arduino-cli.exe",
				Arguments = $"upload -p {comPort} -b Heltec-esp32:esp32:WIFI_LoRa_32_V3 ./Content/heltec-firmware/ --additional-urls \"https://github.com/Heltec-Aaron-Lee/WiFi_Kit_series/releases/download/0.0.9/package_heltec_esp32_index.json\"",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true,
				RedirectStandardError = true
			});
		}


		private string GetCOMPort()
		{
			using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity"))
			{
				// Get the collection of objects
				var devices = searcher.Get();

				foreach (ManagementObject device in devices)
				{
					// Get the name of the device, which should include the COM port if it's a serial device
					string name = device["Name"] as string;
					if (name is not null && name.Contains("COM"))
					{
						if (device["DeviceID"].ToString() == "USB\\VID_10C4&PID_EA60\\0001")
						{
							// Get the COM port out of the name using a regular expression
							System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(name, @"COM(\d+)");
							if (match.Success)
							{
								string comPort = match.Value;  // This will be something like "COM5"
								return comPort;
							}
						}

					}

				}
			}

			return string.Empty;
		}



	}
}
