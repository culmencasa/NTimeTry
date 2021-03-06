﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Windows.Utils
{
    public static class EnvironmentEx
    {
        public static WindowsNames GetCurrentOSName()
        {
            WindowsNames osname = WindowsNames.Unknown;
            OperatingSystem os = Environment.OSVersion;
            switch (os.Platform)
            {
                case PlatformID.Win32Windows:
                    switch (os.Version.Minor)
                    {
                        case 0:
                            osname = WindowsNames.Windows95;
                            break;
                        case 10:
                            if (os.Version.Revision.ToString() == "2222A ")
                                osname = WindowsNames.Windows98SE;
                            else
                                osname = WindowsNames.Windows98;
                            break;
                        case 90:
                            osname = WindowsNames.WindowsMe;
                            break;
                    }
                    break;
                case PlatformID.Win32NT:
                    switch (os.Version.Major) // 主要版本号
                    {
                        case 3:
                            osname = WindowsNames.WindowsNT35;
                            break;
                        case 4:
                            osname = WindowsNames.WindowsNT40;
                            break;
                        case 5:
                            switch (os.Version.Minor) // 次要版本号
                            {
                                case 0:
                                    osname = WindowsNames.Windows2000;
                                    break;
                                case 1:
                                    osname = WindowsNames.WindowsXP;
                                    break;
                                case 2:
                                    osname = WindowsNames.Windows2003;
                                    break;
                            }
                            break;
                        case 6:
                            switch (os.Version.Minor) // 次要版本号
                            {
                                case 0:
                                    osname = WindowsNames.WindowsVista;
                                    break;
                                case 1:
                                    osname = WindowsNames.Windows7;
                                    break;
                            }
                            break;
                    }
                    break;
            }

            return osname;
        }

    }
}
