using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class AutoClicker : Form
    {
        //global key hooks
        private const int WH_KEYBOARD_LL = 13;
        private LowLevelKeyboardProcDelegate m_callback;
        private IntPtr m_hHook;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("Kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(IntPtr lpModuleName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr LowLevelKeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                var khs = (KeyboardHookStruct)
                          Marshal.PtrToStructure(lParam,
                          typeof(KeyboardHookStruct));
                if (Convert.ToInt32("" + wParam) == 256)
                {
                    if ((int)khs.VirtualKeyCode == 121)//F10
                    {
                        buttonStop.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 113)//F2
                    {
                        buttonStart.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 114)//F3
                    {
                        buttonPickLoc.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    
                }
            }
            return CallNextHookEx(m_hHook, nCode, wParam, lParam);
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct KeyboardHookStruct
        {
            public readonly int VirtualKeyCode;
            public readonly int ScanCode;
            public readonly int Flags;
            public readonly int Time;
            public readonly IntPtr ExtraInfo;
        }
        private delegate IntPtr LowLevelKeyboardProcDelegate(
            int nCode, IntPtr wParam, IntPtr lParam);

        public void SetHook()
        {
            m_callback = LowLevelKeyboardHookProc;
            m_hHook = SetWindowsHookEx(WH_KEYBOARD_LL,
                m_callback,
                GetModuleHandle(IntPtr.Zero), 0);
        }
        public void Unhook()
        {
            UnhookWindowsHookEx(m_hHook);
        }



        //hook for mouse
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        //Normalized absolute coordinates
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        //Click on the left mouse button
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //Raising the left mouse button
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        //Clicking on the right mouse button
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //Raising the right mouse button
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //mouse pointer movement
        private const int MOUSEEVENTF_MOVE = 0x0001;

        // To determine the cursor position
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        static protected long totalPixels = 0;
        static protected int diffX;
        static protected int diffY;

        static public bool _isStart = false;
        public AutoClicker()
        {
            InitializeComponent();
            SetHook();
            this.Focus();
            this.KeyPreview = true;
            this.KeyDown += AutoClicker_KeyDown;

        }
        private void AutoClicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                Application.Exit(); // Close the application
            }
        }
        

        private void pictureBoxExit_Click(object sender, EventArgs e) // Button to close the application
        {
            this.Close();
        }

        Point lastPoint;
        private void PanelExitMin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void PanelExitMin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _isStart = false;
            textBoxForMins.Text = "0";
            textBoxForSecs.Text = "0";
            textBoxX.Text = "0";
            textBoxY.Text = "0";

        }

        private void textBoxForSecs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        // function for determining the cursor position
        private void buttonPickLoc_Click(object sender, EventArgs e)
        {
            Point defPnt = new Point();
            GetCursorPos(ref defPnt);
            textBoxX.Text = defPnt.X.ToString();
            textBoxY.Text = defPnt.Y.ToString();
        }


        async private void buttonStart_Click(object sender, EventArgs e)
        {
            _isStart = true;
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            int x = 65535 / resolution.Width * Convert.ToInt32(textBoxX.Text);
            int y = 65535 / resolution.Height * Convert.ToInt32(textBoxY.Text);

            while (_isStart)
            {
                if (ButtonLeft.Checked == true && ButtonOne.Checked == true)
                {
                    //move the mouse to the specified coordinates
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
                    //click the left mouse button once
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                }
                if (ButtonLeft.Checked == true && ButtonDouble.Checked == true)
                {
                    //move the mouse to the specified coordinates
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
                    ////click the left mouse button twice
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                }
                if (ButtonRight.Checked == true && ButtonOne.Checked == true)
                {
                    //move the mouse to the specified coordinates
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
                    //click the right mouse button once
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
                }
                if (ButtonRight.Checked == true && ButtonDouble.Checked == true)
                {   //move the mouse to the specified coordinates
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
                    //click the right mouse button twice
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
                }
                await Task.Delay(60000 * Convert.ToInt32(textBoxForMins.Text) + 1000 * Convert.ToInt32(textBoxForSecs.Text));
            }
        }
    }
}
