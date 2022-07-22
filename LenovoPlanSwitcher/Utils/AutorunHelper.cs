using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LenovoPlanSwitcher.Utils
{
    public class AutorunHelper
    {
        private const string APPLICATION_ID = "LenovoPowerPlanSwitcher";
        private const string AUTORUN_REGISTRY_PATH = "Software\\Microsoft\\Windows\\CurrentVersion\\Run\\";

        private static string applicationExecFile = "\"" + Assembly.GetEntryAssembly().Location + "\"";

        public static bool SetApplicationAutorunState(bool state)
        {
            try
            {
                if (RegistryUtils.CheckKeyExists(APPLICATION_ID, AUTORUN_REGISTRY_PATH))
                {
                    RegistryUtils.RemoveKeyFromUserRegistry(APPLICATION_ID, AUTORUN_REGISTRY_PATH);
                }

                if (state)
                {
                    RegistryUtils.AddKeyToUserRegistry(APPLICATION_ID, applicationExecFile, AUTORUN_REGISTRY_PATH);
                }
                return true;
            }
            catch
            {
                // TODO: Log...
                return false;
            }
        }

        public static bool GetApplicationAutorunState()
        {
            return RegistryUtils.CheckKeyExists(APPLICATION_ID, AUTORUN_REGISTRY_PATH);
        }
    }
}
