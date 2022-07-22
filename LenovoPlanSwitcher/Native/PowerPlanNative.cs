using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenovoPlanSwitcher.Native
{
    public class PowerPlanNative
    {

        [DllImport("PowrProf.dll")]
        private static extern UInt32 PowerEnumerate(IntPtr RootPowerKey, IntPtr SchemeGuid, IntPtr SubGroupOfPowerSettingGuid, UInt32 AcessFlags, UInt32 Index, ref Guid Buffer, ref UInt32 BufferSize);

        [DllImport("PowrProf.dll")]
        private static extern UInt32 PowerReadFriendlyName(IntPtr RootPowerKey, ref Guid SchemeGuid, IntPtr SubGroupOfPowerSettingGuid, IntPtr PowerSettingGuid, IntPtr Buffer, ref UInt32 BufferSize);

        [DllImport("PowrProf.dll")]
        private static extern UInt32 PowerSetActiveScheme(IntPtr RootPowerKey, ref Guid SchemeGuid);

        [DllImport("PowrProf.dll")]
        private static extern UInt32 PowerGetActiveScheme(IntPtr RootPowerKey, out IntPtr GuidPointer);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr LocalFree(IntPtr pointer);

        public static Guid getCurrentPowerPlan()
        {
            Guid currentPlan = Guid.Empty;
            IntPtr currentPlanGuidPointer = IntPtr.Zero;

            try
            {
                PowerGetActiveScheme(IntPtr.Zero, out currentPlanGuidPointer);
                currentPlan = (Guid) Marshal.PtrToStructure(currentPlanGuidPointer, typeof(Guid));
            }
            finally
            {
                if (currentPlanGuidPointer != IntPtr.Zero)
                {
                    if (LocalFree(currentPlanGuidPointer) != IntPtr.Zero)
                    {
                        MessageBox.Show("Не удалось освободить память!");
                    }
                }
            }

            return currentPlan;
        }

        public enum AccessFlags : uint
        {
            ACCESS_SCHEME = 16,
            ACCESS_SUBGROUP = 17,
            ACCESS_INDIVIDUAL_SETTING = 18
        }

        public static string GetName(Guid schemeGuid)
        {
            uint sizeName = 1024;
            IntPtr pSizeName = Marshal.AllocHGlobal((int)sizeName);
            string friendlyName;

            try
            {
                PowerReadFriendlyName(IntPtr.Zero, ref schemeGuid, IntPtr.Zero, IntPtr.Zero, pSizeName, ref sizeName);
                friendlyName = Marshal.PtrToStringUni(pSizeName);
            }
            finally
            {
                Marshal.FreeHGlobal(pSizeName);
            }

            return friendlyName;
        }

        public static IEnumerable<Guid> GetAll()
        {
            Guid schemeGuid = Guid.Empty;

            uint sizeSchemeGuid = (uint)Marshal.SizeOf(typeof(Guid));
            uint schemeIndex = 0;

            while (PowerEnumerate(
                IntPtr.Zero, 
                IntPtr.Zero, 
                IntPtr.Zero, 
                (uint)AccessFlags.ACCESS_SCHEME, 
                schemeIndex, 
                ref schemeGuid, 
                ref sizeSchemeGuid) == 0) 
            {
                yield return schemeGuid;
                schemeIndex++;
            }
        }

        public static bool SetPowerPlan(Guid schemeGuid)
        {
            try
            {
                return PowerSetActiveScheme(IntPtr.Zero, ref schemeGuid) != 0;
            }
            catch
            {
                return false;
            }
        }

    }
}
