using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDoge_FirmwareInstaller
{
	internal class InstallerMenu
	{

		private Installer[] _installers;


		public InstallerMenu(Installer[] installers)
		{
			_installers = installers;
		}

		public Installer GetInstaller()
		{

			if(_installers.Length == 0)
			{
				Console.WriteLine("Sorry, there are no supported installers on this platform.");
				return null;
			}

			int choice;
			while (true)
			{
				Console.WriteLine("Select Hardware:");

				for (int i = 0; i < _installers.Length; i++)
				{
					Console.WriteLine($"{i + 1}.) {_installers[i].HardwareName}");
				}

				if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= _installers.Length)
				{
					return _installers[choice - 1];
				}
				else
				{
					Console.WriteLine("Invalid choice. Please enter a valid number.");
				}
			}
		}


	}
}
