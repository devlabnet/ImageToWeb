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
        public static bool Register(string shellKeyName, string menuText, string menuCommand,  string iconPath)
		{
			Debug.Assert(   !string.IsNullOrEmpty(shellKeyName) &&
                            !string.IsNullOrEmpty(menuText) &&
                            !string.IsNullOrEmpty(menuCommand) &&
                            !string.IsNullOrEmpty(iconPath));
			
			// create full path to registry location
			string regPath = string.Format(@"*\shell\{0}", shellKeyName);

            //Console.WriteLine("regPath:" + regPath);
            //Console.WriteLine("menuText:" + menuText);
            //Console.WriteLine("menuCommand:" + menuCommand);

            try {
                // add context menu to the registry
                using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(regPath)) {
                    key.SetValue(null, menuText);
                    key.SetValue("icon", iconPath);
                    key.SetValue("AppliesTo", "image");
                }

                // add command that is invoked to the registry
                using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(
                    string.Format(@"{0}\command", regPath))) {
                    key.SetValue(null, menuCommand);
                }
            } catch (Exception ex) {
                MessageBox.Show(string.Format(
                    "{0} \n(Please Run as Administrator).",
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
                    "{0} \n(Please Run as Administrator).",
                    ex.Message), "Unregister Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
