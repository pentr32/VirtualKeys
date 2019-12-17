using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualKeys
{
    // Source: https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mouse_event

    public static class Mouse
    {
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;               // The left button is down.

        public const int MOUSEEVENTF_LEFTUP = 0x04;                 // The left button is up.

        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;              // The right button is down.

        public const int MOUSEEVENTF_RIGHTUP = 0x10;                // The right button is up.
    }
}
