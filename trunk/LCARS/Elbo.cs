#region Original Work By Marcelo Chavez
//---------------------------------------------------------------------------------------------------
//
//  This library is based on original work by Marcelo Chavez.
//  Please see http://www.codeproject.com/KB/miscctrl/lcars_net_controls.aspx
//  for more information.
//
//---------------------------------------------------------------------------------------------------
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Streambolics.Lcars
{
    [ToolboxBitmap (@"C:\Inetpub\wwwroot\LCARS\LCARS_Toolbox\icon\st1_16.ico")]
    public class Elbo : LcarsControl
    {
        // Fields
        private int _ArcExt = 100;
        private int _ArcInt = 50;
        private int _ColWidth = 20;

        private ContentAlignment _Orientation = ContentAlignment.TopLeft;
        
        // BUG: The Row Height of a typical Elbo is far larger than the column width.
        //      Initialize with a much better chosen value.
        private int _RowHeight = 20;

        // Methods
        public Elbo ()
        {
            this.InitializeComponent ();
        }

        private void InitializeComponent ()
        {
            this.BackColor = System.Drawing.Color.Black;
            base.Name = "LCARSElbo";
            base.Size = new Size (0x68, 0x20);
        }

        protected override void DoRenderFunction (Graphics g, Brush BackBrush, Brush FunctionBrush)
        {
            base.DoRenderFunction (g, BackBrush, FunctionBrush);
            int width = base.ClientSize.Width;
            int height = base.ClientSize.Height;
            int x = 0;
            int y = 0;

            // TODO: The names of these variables were lost during decompilation. Try to understand their meaning.
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;
            int num9 = 0;
            int num10 = 0;
            int num11 = 0;
            int num12 = 0;
            int num13 = this._ArcExt;
            int num14 = this._ArcInt;
            switch (this._Orientation)
            {
                case ContentAlignment.TopLeft:
                    x = 0;
                    y = 0;
                    num5 = 0;
                    num6 = 0;
                    num7 = this._ColWidth;
                    num8 = this._RowHeight;
                    num9 = this._ColWidth;
                    num10 = this._RowHeight;
                    num11 = this._ColWidth;
                    num12 = this._RowHeight;
                    break;

                case ContentAlignment.BottomLeft:
                    x = 0;
                    y = height - (num13 / 2);
                    num5 = 0;
                    num6 = height - num13;
                    num7 = this._ColWidth;
                    num8 = 0;
                    num9 = this._ColWidth;
                    num10 = (height - this._RowHeight) - (num14 / 2);
                    num11 = this._ColWidth;
                    num12 = (height - this._RowHeight) - num14;
                    break;

                case ContentAlignment.TopRight:
                    x = width - (num13 / 2);
                    y = 0;
                    num5 = width - num13;
                    num6 = 0;
                    num7 = 0;
                    num8 = this._RowHeight;
                    num9 = (width - this._ColWidth) - (num14 / 2);
                    num10 = this._RowHeight;
                    num11 = (width - this._ColWidth) - num14;
                    num12 = this._RowHeight;
                    break;

                case ContentAlignment.BottomRight:
                    x = width - (num13 / 2);
                    y = height - (num13 / 2);
                    num5 = width - num13;
                    num6 = height - num13;
                    num7 = 0;
                    num8 = 0;
                    num9 = (width - this._ColWidth) - (num14 / 2);
                    num10 = (height - this._RowHeight) - (num14 / 2);
                    num11 = (width - this._ColWidth) - num14;
                    num12 = (height - this._RowHeight) - num14;
                    break;
            }

            g.FillRectangle (FunctionBrush, 0, 0, width, height);
            g.FillRectangle (BackBrush, x, y, num13 / 2, num13 / 2);
            g.FillPie (FunctionBrush, num5, num6, num13, num13, 0, 360);
            g.FillRectangle (BackBrush, num7, num8, width - this._ColWidth, height - this._RowHeight);
            g.FillRectangle (FunctionBrush, num9, num10, num14 / 2, num14 / 2);
            g.FillPie (BackBrush, num11, num12, num14, num14, 0, 360);
            this.ElboOrientation = _Orientation;
        }

        // Properties
        [Category ("LCARS"), Description ("External arc diameter")]
        public int ArcExternal
        {
            get
            {
                return this._ArcExt;
            }
            set
            {
                this._ArcExt = value;
                base.Invalidate ();
            }
        }

        [Category ("LCARS"), Description ("Internal arc diameter")]
        public int ArcInternal
        {
            get
            {
                return this._ArcInt;
            }
            set
            {
                this._ArcInt = value;
                base.Invalidate ();
            }
        }

        [Category ("LCARS"), Description ("Width of the column")]
        public int ColWidth
        {
            get
            {
                return this._ColWidth;
            }
            set
            {
                this._ColWidth = value;
                base.Invalidate ();
            }
        }

        [Category ("LCARS"), Description ("Orientation")]
        public ContentAlignment Orientation
        {
            get
            {
                return this._Orientation;
            }
            set
            {
                this._Orientation = value;
                base.Invalidate ();
            }
        }

        [Category ("LCARS"), Description ("Height of the row")]
        public int RowHeight
        {
            get
            {
                return this._RowHeight;
            }
            set
            {
                this._RowHeight = value;
                base.Invalidate ();
            }
        }
    }
}