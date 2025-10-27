using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light_Switch;
using System;
using System.Runtime.InteropServices;

public static class ThemeHelper
{
    private const int WM_SETTINGCHANGE = 0x001A;
    private const int HWND_BROADCAST = 0xffff;

    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    private static extern IntPtr SendMessageTimeout(
        IntPtr hWnd, uint Msg, IntPtr wParam, string lParam,
        uint fuFlags, uint uTimeout, out IntPtr lpdwResult);

    public static void NotifyThemeChanged()
    {
        SendMessageTimeout(
            new IntPtr(HWND_BROADCAST),
            WM_SETTINGCHANGE,
            IntPtr.Zero,
            "ImmersiveColorSet",
            0x2 /* SMTO_ABORTIFHUNG */,
            100,
            out _);
    }
}
