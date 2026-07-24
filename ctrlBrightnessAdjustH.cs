using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elsoft.Screen
{
    public partial class ctrlBrightnessAdjustH : UserControl
    {
        private bool myAllowAdj = false;
        private int myBorder = 6;
        private int myMinPos = 0;
        private int myMaxPos = 0;
        private int myRange { get { return myMaxPos - myMinPos; } }
        public float Volume { set { DrawVolPos((int)(value * myRange)); } }
        public bool IsActive { get { return myAllowAdj; } }
        public event EventHandler<EventArgs> VolumeChanged = null;


        public ctrlBrightnessAdjustH()
        {
            InitializeComponent();
            pbBack.Controls.Add(pbVol);
            pbVol.Top = 0;
            pbVol.Left = 0; 
            pbVol.Height = 53;
            pbBack.Controls.Add(btnAdj);
            btnAdj.Left = 0;
            btnAdj.Width = 18;
            btnAdj.Height = 52;
            btnAdj.BringToFront();
            myMinPos = 0;
            myMaxPos = pbBack.Width - btnAdj.Width - 2 * myBorder;
            DrawVolPos(0);

        }

        private void btnAdj_MouseDown(object sender, MouseEventArgs e)
        {
            myAllowAdj = true;
            tmrMove.Start();
        }

        private void btnAdj_MouseUp(object sender, MouseEventArgs e)
        {
            myAllowAdj = false;
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            while (myAllowAdj)
            {
                DrawVolPos(PositionFromMouse);
                Application.DoEvents();
            }
        }
        private int PositionFromMouse { get { return this.Parent.PointToClient(MousePosition).X - this.Left - pbBack.Left - myBorder - btnAdj.Width / 2; } }
        private void DrawVolPos(int pos)
        {
            float finalpct;
            if (pos < myMinPos) pos = myMinPos;
            if (pos > myMaxPos) pos = myMaxPos;
            btnAdj.Left = myBorder + pos;
            pbVol.Width = btnAdj.Left + 3;
            finalpct = (float)(pos / (double)myRange);
            lblLevelPct.Text = (100.0 * finalpct).ToString("0") + "%";
            if (VolumeChanged != null) VolumeChanged(this, null);
        }

        private void pbVol_Click(object sender, EventArgs e)
        {
            DrawVolPos(PositionFromMouse);
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            DrawVolPos(PositionFromMouse);
        }
    }
}
