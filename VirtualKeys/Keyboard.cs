using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualKeys
{
    // https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
    // http://www.jasinskionline.com/windowsapi/ref/other/virtualkeycodes.html

    public static class Keyboard
    {
        public const int VK_LBUTTON = 0x1;                  // Left mouse button

        public const int VK_RBUTTON = 0x2;                  // Right mouse button

        public const int VK_MBUTTON = 0x4;                  // Middle mouse button (three-button mouse)

        public const int VK_BACK = 0x8;                     // BACKSPACE key

        public const int VK_TAB = 0x9;                      // TAB key

        public const int VK_CLEAR = 0xc;                    // CLEAR key

        public const int VK_RETURN = 0xd;                   // ENTER key

        public const int VK_SHIFT = 0x10;                   // SHIFT key

        public const int VK_CONTROL = 0x11;                 // CTRL key

        public const int VK_MENU = 0x12;                    // ALT key

        public const int VK_PAUSE = 0x13;                   // PAUSE key

        public const int VK_CAPITAL = 0x14;                 // CAPS LOCK key

        public const int VK_ESCAPE = 0x1b;                  // ESC key

        public const int VK_SPACE = 0x20;                   // SPACEBAR

        public const int VK_PRIOR = 0x21;                   // PAGE UP key

        public const int VK_NEXT = 0x22;                    // PAGE DOWN key

        public const int VK_END = 0x23;                     // END key

        public const int VK_HOME = 0x24;                    // HOME key

        public const int VK_LEFT = 0x25;                    // LEFT ARROW key

        public const int VK_UP = 0x26;                      // UP ARROW key

        public const int VK_RIGHT = 0x27;                   // RIGHT ARROW key

        public const int VK_DOWN = 0x28;                    // DOWN ARROW key

        public const int VK_PRINT = 0x2a;                   // PRINT key

        public const int VK_SNAPSHOT = 0x2c;                // PRINT SCREEN key

        public const int VK_INSERT = 0x2d;                  // INS key

        public const int VK_DELETE = 0x2e;                  // DEL key

        public const int VK_HELP = 0x2f;                    // HELP key

        public const int VK_0 = 0x30;                       // 0 key

        public const int VK_1 = 0x31;                       // 1 key

        public const int VK_2 = 0x32;                       // 2 key

        public const int VK_3 = 0x33;                       // 3 key

        public const int VK_4 = 0x34;                       // 4 key

        public const int VK_5 = 0x35;                       // 5 key

        public const int VK_6 = 0x36;                       // 6 key
          
        public const int VK_7 = 0x37;                       // 7 key

        public const int VK_8 = 0x38;                       // 8 key

        public const int VK_9 = 0x39;                       // 9 key

        public const int VK_A = 0x41;                       // A key

        public const int VK_B = 0x42;                       // B key

        public const int VK_C = 0x43;                       // C key

        public const int VK_D = 0x44;                       // D key

        public const int VK_E = 0x45;                       // E key

        public const int VK_F = 0x46;                       // F key

        public const int VK_G = 0x47;                       // G key

        public const int VK_H = 0x48;                       // H key

        public const int VK_I = 0x49;                       // I key

        public const int VK_J = 0x4a;                       // J key

        public const int VK_K = 0x4b;                       // K key

        public const int VK_L = 0x4c;                       // L key

        public const int VK_M = 0x4d;                       // M key

        public const int VK_N = 0x4e;                       // N key

        public const int VK_O = 0x4f;                       // O key

        public const int VK_P = 0x50;                       // P key

        public const int VK_Q = 0x51;                       // Q key

        public const int VK_R = 0x52;                       // R key

        public const int VK_S = 0x53;                       // S key

        public const int VK_T = 0x54;                       // T key

        public const int VK_U = 0x55;                       // U key

        public const int VK_V = 0x56;                       // V key

        public const int VK_W = 0x57;                       // W key

        public const int VK_X = 0x58;                       // X key

        public const int VK_Y = 0x59;                       // Y key

        public const int VK_Z = 0x5a;                       // Z key

        public const int VK_STARTKEY = 0x5b;                // START key

        public const int VK_CONTEXTKEY = 0x5d;              // CON key

        public const int VK_NUMPAD0 = 0x60;                 // Numeric keypad 0 key

        public const int VK_NUMPAD1 = 0x61;                 // Numeric keypad 1 key

        public const int VK_NUMPAD2 = 0x62;                 // Numeric keypad 2 key

        public const int VK_NUMPAD3 = 0x63;                 // Numeric keypad 3 key

        public const int VK_NUMPAD4 = 0x64;                 // Numeric keypad 4 key

        public const int VK_NUMPAD5 = 0x65;                 // Numeric keypad 5 key

        public const int VK_NUMPAD6 = 0x66;                 // Numeric keypad 6 key

        public const int VK_NUMPAD7 = 0x67;                 // Numeric keypad 7 key

        public const int VK_NUMPAD8 = 0x68;                 // Numeric keypad 8 key

        public const int VK_NUMPAD9 = 0x69;                 // Numeric keypad 9 key

        public const int VK_MULTIPLY = 0x6a;                // Multiply key

        public const int VK_ADD = 0x6b;                     // Add key

        public const int VK_SEPARATOR = 0x6c;               // Separator key

        public const int VK_SUBTRACT = 0x6d;                // Subtract key

        public const int VK_DECIMAL = 0x6e;                 // Decimal key

        public const int VK_DIVIDE = 0x6f;                  // Divide key

        public const int VK_F1 = 0x70;                      // F1 key

        public const int VK_F2 = 0x71;                      // F2 key

        public const int VK_F3 = 0x72;                      // F3 key

        public const int VK_F4 = 0x73;                      // F4 key

        public const int VK_F5 = 0x74;                      // F5 key

        public const int VK_F6 = 0x75;                      // F6 key

        public const int VK_F7 = 0x76;                      // F7 key

        public const int VK_F8 = 0x77;                      // F8 key

        public const int VK_F9 = 0x78;                      // F9 key

        public const int VK_F10 = 0x79;                     // F10 key

        public const int VK_F11 = 0x7a;                     // F11 key

        public const int VK_F12 = 0x7b;                     // F12 key

        public const int VK_F13 = 0x7c;                     // F13 key

        public const int VK_F14 = 0x7d;                     // F14 key

        public const int VK_F15 = 0x7e;                     // F15 key

        public const int VK_F16 = 0x7f;                     // F16 key

        public const int VK_F17 = 0x80;                     // F17 key

        public const int VK_F18 = 0x81;                     // F18 key

        public const int VK_F19 = 0x82;                     // F19 key

        public const int VK_F20 = 0x83;                     // F20 key

        public const int VK_F21 = 0x84;                     // F21 key

        public const int VK_F22 = 0x85;                     // F22 key

        public const int VK_F23 = 0x86;                     // F23 key

        public const int VK_F24 = 0x87;                     // F24 key

        public const int VK_NUMLOCK = 0x90;                 // NUM LOCK key

        public const int VK_OEM_SCROLL = 0x91;              // SCROLL LOCK key

        public const int VK_LSHIFT = 0xa0;                  // Left shift key

        public const int VK_RSHIFT = 0xa1;                  // Right shift key

        public const int VK_LCONTROL = 0xa2;                // Left control key

        public const int VK_RCONTROL = 0xa3;                // Right control key

        public const int VK_LMENU = 0xa4;                   // Left menu key

        public const int VK_RMENU = 0xa5;                   // Right menu key

        public const int VK_OEM_1 = 0xba;                   // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ';:' key

        public const int VK_OEM_PLUS = 0xbb;                // For any country/region, the '+' key

        public const int VK_OEM_COMMA = 0xbc;               // For any country/region, the ',' key

        public const int VK_OEM_MINUS = 0xbd;               // For any country/region, the '-' key

        public const int VK_OEM_PERIOD = 0xbe;              // For any country/region, the '.' key

        public const int VK_OEM_2 = 0xbf;                   // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '/?' key

        public const int VK_OEM_3 = 0xc0;                   // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '`~' key

        public const int VK_OEM_4 = 0xdb;                   // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '[{' key

        public const int VK_OEM_5 = 0xdc;                   // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '\|' key

        public const int VK_OEM_6 = 0xdd;                   // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ']}' key

        public const int VK_OEM_7 = 0xde;                   // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the 'single-quote/double-quote' key

        public const int VK_OEM_8 = 0xdf;                   // Used for miscellaneous characters; it can vary by keyboard.

        public const int VK_OEM_102 = 0xE2;                 // Either the angle bracket key or the backslash key on the RT 102-key keyboard.

        public const int VK_ICO_F17 = 0xe0;                 // F17 on Olivetti extended keyboard (internal use only).

        public const int VK_ICO_F18 = 0xe1;                 // F18 on Olivetti extended keyboard (internal use only).                  

        public const int VK_ICO_HELP = 0xe3;                // Help on Olivetti extended keyboard (internal use only)

        public const int VK_ICO_00 = 0xe4;                  // 00 on Olivetti extended keyboard (internal use only)

        public const int VK_ICO_CLEAR = 0xe6;               // Clear on Olivette extended keyboard (internal use only)

        public const int VK_OEM_RESET = 0xe9;               // Reset (Nokia keyboards only)

        public const int VK_OEM_JUMP = 0xea;                // Jump (Nokia keyboards only)

        public const int VK_OEM_PA1 = 0xeb;                 // PA1 (Nokia keyboards only)

        public const int VK_OEM_PA2 = 0xec;                 // PA2 (Nokia keyboards only)

        public const int VK_OEM_PA3 = 0xed;                 // PA3 (Nokia keyboards only)

        public const int VK_OEM_WSCTRL = 0xee;              // WSCTRL (Nokia keyboards only)

        public const int VK_OEM_CUSEL = 0xef;               // CUSEL (Nokia keyboards only)

        public const int VK_OEM_ATTN = 0xf0;                // ATTN (Nokia keyboards only)

        public const int VK_OEM_FINNISH = 0xf1;             // FINNISH (Nokia keyboards only)

        public const int VK_OEM_COPY = 0xf2;                // COPY (Nokia keyboards only)

        public const int VK_OEM_AUTO = 0xf3;                // AUTO (Nokia keyboards only)

        public const int VK_OEM_ENLW = 0xf4;                // ENLW (Nokia keyboards only)

        public const int VK_OEM_BACKTAB = 0xf5;             // BACKTAB (Nokia keyboards only)

        public const int VK_ATTN = 0xf6;                    // ATTN

        public const int VK_CRSEL = 0xf7;                   // CRSEL

        public const int VK_EXSEL = 0xf8;                   // EXSEL

        public const int VK_EREOF = 0xf9;                   // EREOF

        public const int VK_PLAY = 0xfa;                    // PLAY

        public const int VK_ZOOM = 0xfb;                    // ZOOM

        public const int VK_NONAME = 0xfc;                  // NONAME

        public const int VK_PA1 = 0xfd;                     // PA1

        public const int VK_OEM_CLEAR = 0xfe;               // CLEAR
    }
}
