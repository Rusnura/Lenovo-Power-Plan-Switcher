using LenovoPlanSwitcher.Native;
using Microsoft.Win32.SafeHandles;
using System;

namespace LenovoPlanSwitcher.Drivers
{
    public static class LenovoDriver
    {
        private static SafeFileHandle _energyDriver;

        public static SafeFileHandle EnergyDriver
        {
            get
            {
                if (_energyDriver == null)
                {
                    IntPtr driverHandle = IO.CreateFileW("\\\\.\\EnergyDrv", 0xC0000000, 3u, IntPtr.Zero, 3u, 0x80, IntPtr.Zero);
                    if (driverHandle == new IntPtr(-1))
                    {
                        throw new Exception("Не удалось открыть драйвер \\EnergyDrv. Проверьте, установлены ли драйвера!");
                    }
                    _energyDriver = new SafeFileHandle(driverHandle, true);
                }

                return _energyDriver;
            }
        }
    }
}
