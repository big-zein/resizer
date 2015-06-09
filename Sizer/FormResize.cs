using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Resizer
{
    public partial class Resizer : Form
    {

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        //[DllImport("user32.dll")]
        //static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }

        public Resizer()
        {
            InitializeComponent();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            timerDelay.Interval = int.Parse(tbDelay.Text);
            timerDelay.Start();
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            this.Hide();
            timerDelay.Stop();
            runResize();
            this.Show();
        }

        private void runResize()
        {
            const uint MOUSEEVENTF_LEFTDOWN = 0x02;
            const uint MOUSEEVENTF_LEFTUP = 0x04;
            const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
            const uint MOUSEEVENTF_RIGHTUP = 0x10;

            uint xpos = (uint)Cursor.Position.X;
            uint ypos = (uint)Cursor.Position.Y;

            SetCursorPos((int)xpos, (int)ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);

            System.Threading.Thread.Sleep(100);

            IntPtr handle = GetForegroundWindow();

            int x = 0;
            int y = 0;
            if (rbKeep.Checked)
            {
                Rect r = new Rect();
                GetWindowRect(handle, ref r);
                x = r.Left;
                y = r.Top;
            }
            else
            {
                x = int.Parse(lbPosition.SelectedItem.ToString().Substring(0, lbPosition.SelectedItem.ToString().IndexOf(',')));
                y = int.Parse(lbPosition.SelectedItem.ToString().Substring(lbPosition.SelectedItem.ToString().IndexOf(',') + 1));
            }

            const short SWP_NOMOVE = 0X2;
            const short SWP_NOSIZE = 1;
            const short SWP_NOZORDER = 0X4;
            const int SWP_SHOWWINDOW = 0x0040;

            int width = int.Parse(lbSize.SelectedItem.ToString().Substring(0, lbSize.SelectedItem.ToString().IndexOf('x')));
            int height = int.Parse(lbSize.SelectedItem.ToString().Substring(lbSize.SelectedItem.ToString().IndexOf('x') + 1));

            SetWindowPos(handle, 0, x, y, width, height, SWP_NOZORDER | SWP_SHOWWINDOW);
        }

        private void Resizer_Load(object sender, EventArgs e)
        {
            foreach (string item in Properties.Settings.Default.sizePreset)
            {
                lbSize.Items.Add(item);
            }
            lbSize.SelectedIndex = Properties.Settings.Default.sizeIndex;
            foreach (string item in Properties.Settings.Default.positionPreset)
            {
                lbPosition.Items.Add(item);
            }
            lbPosition.SelectedIndex = Properties.Settings.Default.positionIndex;

            tbDelay.Text = Properties.Settings.Default.delay.ToString();
            if (Properties.Settings.Default.position == 0)
            {
                rbKeep.Checked = true;
            }
            else
            {
                rbMove.Checked = true;
            }
            Location = new Point(Properties.Settings.Default.startX, Properties.Settings.Default.startY);

            foreach (Control item in Controls)
            {
                item.KeyDown += onF1;
            }
        }

        private void onF1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                
                btnResize_Click(sender, new EventArgs());
            }
        }

        private void btAddPreset_Click(object sender, EventArgs e)
        {
            try
            {
                int width = int.Parse(tbWidth.Text);
                int height = int.Parse(tbHeight.Text);
                lbSize.Items.Add(width.ToString() + "x" + height.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void btnDeletePreset_Click(object sender, EventArgs e)
        {
            if (lbSize.SelectedIndex != -1)
            {
                lbSize.Items.RemoveAt(lbSize.SelectedIndex);
            }
        }        

        private void rbMove_CheckedChanged(object sender, EventArgs e)
        {
            //setCheckbox(int.Parse(((RadioButton)sender).Tag.ToString()));
        }

        private void Resizer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.sizePreset.Clear();
            foreach (string item in lbSize.Items)
            {
                Properties.Settings.Default.sizePreset.Add(item);
            }
            Properties.Settings.Default.positionPreset.Clear();
            foreach (string item in lbPosition.Items)
            {
                Properties.Settings.Default.positionPreset.Add(item);
            }
            Properties.Settings.Default.delay = int.Parse(tbDelay.Text);
            
            Properties.Settings.Default.position = rbKeep.Checked ? 0 : 1;
            Properties.Settings.Default.sizeIndex = lbSize.SelectedIndex;
            Properties.Settings.Default.positionIndex = lbPosition.SelectedIndex;
            Properties.Settings.Default.startX = Location.X;
            Properties.Settings.Default.startY = Location.Y;
            Properties.Settings.Default.Save();
        }

        private void btAddPos_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbX.Text);
                int y = int.Parse(tbY.Text);
                lbPosition.Items.Add(x.ToString() + "," + y.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void btnDelPos_Click(object sender, EventArgs e)
        {
            if (lbPosition.SelectedIndex != -1)
            {
                lbPosition.Items.RemoveAt(lbPosition.SelectedIndex);
            }
        }


    }
}


//private void timer1_Tick(object sender, EventArgs e)
//{
//    this.Hide();
//    timer1.Stop();

//    const uint MOUSEEVENTF_LEFTDOWN = 0x02;
//    const uint MOUSEEVENTF_LEFTUP = 0x04;
//    const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
//    const uint MOUSEEVENTF_RIGHTUP = 0x10;

//    uint xpos = (uint) Cursor.Position.X;
//    uint ypos = (uint) Cursor.Position.Y;

//    SetCursorPos((int)xpos, (int)ypos);
//    mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
//    mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);

//    const int nChars = 256;
//    StringBuilder Buff = new StringBuilder(nChars);
//    IntPtr handle = GetForegroundWindow();

//    //string windowname = "";
//    //if (GetWindowText(handle, Buff, nChars) > 0)
//    //{
//    //    windowname = Buff.ToString();
//    //}


//    const short SWP_NOMOVE = 0X2;
//    const short SWP_NOSIZE = 1;
//    const short SWP_NOZORDER = 0X4;
//    const int SWP_SHOWWINDOW = 0x0040;

//    //Process[] processes = Process.GetProcessesByName(windowname);
//    //foreach (var process in processes)
//    //{
//    //    IntPtr handl = process.MainWindowHandle;

//    //    if (handl != IntPtr.Zero)
//    //    {
//            SetWindowPos(handle, 0, 0, 0, 1000, 1000, SWP_NOZORDER | SWP_SHOWWINDOW);
//    //    }
//    //}
//}

//private void setCheckbox(int isMove)
//{
//    if (isMove == 0)
//    {
//        //tbX.Enabled = tbY.Enabled = false;
//    }
//    else 
//    {
//        //tbX.Enabled = tbY.Enabled = true;
//    }

//}

//mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
//mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);