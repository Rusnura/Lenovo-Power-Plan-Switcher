using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenovoPlanSwitcher.Utils
{
    public class RegistryUtils
    {
        public static void AddKeyToUserRegistry(string key, string value, string location)
        {
            using (RegistryKey rKey = Registry.CurrentUser.CreateSubKey(location))
            {
                rKey.SetValue(key, value);
            }
        }

        public static void RemoveKeyFromUserRegistry(string key, string location)
        {
            using (RegistryKey rKey = Registry.CurrentUser.OpenSubKey(location, true))
            {
                rKey.DeleteValue(key, true);
            }
        }

        public static bool CheckKeyExists(string key, string location)
        {
            return Registry.CurrentUser.OpenSubKey(location).GetValue(key, null) != null;
        }
    }
}
