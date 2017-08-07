using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace imageToWeb {
    /// <summary>
    /// Register and unregister simple shell context menus.
    /// </summary>
    static class FileShellExtension
	{
        /// <summary>
        /// Register a simple shell context menu.
        /// </summary>
        /// <param name="shellKeyName">Name that appears in the registry.</param>
        /// <param name="menuText">Text that appears in the context menu.</param>
        /// <param name="menuCommand">Command line that is executed.</param>
        /// <param name="iconPath">The file path for the command Icon.</param>
        public static bool Register(string shellKeyName, string menuText, string menuCommand,
            string settingsCommand, string iconPath)
		{
			Debug.Assert(   !string.IsNullOrEmpty(shellKeyName) &&
                            !string.IsNullOrEmpty(menuText) &&
                            !string.IsNullOrEmpty(menuCommand) &&
                            !string.IsNullOrEmpty(settingsCommand) &&
                            !string.IsNullOrEmpty(iconPath));
			
			// create full path to registry location
			string regPath = string.Format(@"*\shell\{0}", shellKeyName);

            //Console.WriteLine("regPath:" + regPath);
            //Console.WriteLine("menuText:" + menuText);
            //Console.WriteLine("menuCommand:" + menuCommand);

            try {
                // add context menu to the registry
                RegistryKey topKey = Registry.ClassesRoot.CreateSubKey(regPath);
                topKey.SetValue("icon", iconPath);
                topKey.SetValue("AppliesTo", ".jpg OR .bmp OR .png OR .gif OR .jpeg OR .tiff");
                topKey.SetValue("MUIVerb", menuText);
                topKey.SetValue("subcommands", "");
                // add shell for subcommands
                RegistryKey keyShell = topKey.CreateSubKey("shell");

                // Add SubCommands
                RegistryKey keySubAction = keyShell.CreateSubKey("GO"); //Registry.ClassesRoot.CreateSubKey(string.Format(@"{ 0}\action1", regPath));
                keySubAction.SetValue(null, "GO");
                keySubAction.SetValue("icon", "imageres.dll,176");
                RegistryKey keySubCommand = keySubAction.CreateSubKey("command");
                keySubCommand.SetValue(null, menuCommand);

                keySubAction = keyShell.CreateSubKey("Settings"); //Registry.ClassesRoot.CreateSubKey(string.Format(@"{ 0}\action1", regPath));
                keySubAction.SetValue(null, imageToWeb.Program.rm.GetString("settingsReg", Program.cul));
                keySubAction.SetValue("icon", "imageres.dll,109");
                keySubCommand = keySubAction.CreateSubKey("command");
                keySubCommand.SetValue(null, settingsCommand);
            } catch (Exception ex) {
                MessageBox.Show(string.Format(
                    "{0} \n" + imageToWeb.Program.rm.GetString("runAsAdmin", Program.cul),
                    ex.Message), "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Unregister a simple shell context menu.
        /// </summary>
        /// <param name="shellKeyName">Name that was registered in the registry.</param>
        public static bool Unregister(string shellKeyName)
		{
			Debug.Assert(!string.IsNullOrEmpty(shellKeyName));
                
			// full path to the registry location			
            string regPath = string.Format(@"*\shell\{0}", shellKeyName);
            try {
			    // remove context menu from the registry
			    Registry.ClassesRoot.DeleteSubKeyTree(regPath);
            } catch (Exception ex) {
                MessageBox.Show(string.Format(
                    "{0} \n" + imageToWeb.Program.rm.GetString("runAsAdmin", Program.cul),
                    ex.Message), "Unregister Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
