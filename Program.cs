
using RadioDoge_FirmwareInstaller;
using RadioDoge_FirmwareInstaller.Windows;
using System.Runtime.InteropServices;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("RadioDoge Firmware Installer");
		Console.WriteLine();

		var menu = GetInstallerMenu();

		var installer = menu.GetInstaller();

		if(installer != null)
		{
			installer.Install();
		}


		Console.WriteLine("Press Enter to Exit...");
		Console.ReadLine();
	}


	public static InstallerMenu GetInstallerMenu()
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			return new InstallerMenu(new Installer[]
			{
				new WindowsHeltecWiFiLoRa32V3Installer()
			});
		else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
			return new InstallerMenu(new Installer[]
			{

			});
		else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
			return new InstallerMenu(new Installer[]
			{

			});
		else
			return new InstallerMenu(new Installer[]
			{
			});
	}

}