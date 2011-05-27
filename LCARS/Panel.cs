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
using System.Windows.Forms;

namespace Streambolics.Lcars
{
    [ToolboxBitmap (@"C:\Inetpub\wwwroot\LCARS\LCARS_Toolbox\icon\st1_16.ico")]
    public class Panel : LcarsControl
    {
        private ContentAlignment _TextAlign = ContentAlignment.MiddleCenter;
        private bool _RoundedRight = false;
        private bool _RoundedLeft = false;
        private int _RightSegments = 0;
        private int _LeftSegments = 0;
        private int _TextClip = 0;
        private Choreographer _Choreographer = null;

        public Panel ()
        {
            InitializeComponent ();
        }

        private void InitializeComponent ()
        {
            Name = "LCARS_Panel";
            Size = new Size (0x68, 0x20);
        }

        protected override void OnTextChanged (EventArgs e)
        {
            base.OnTextChanged (e);
            if (_Choreographer == null)
            {
                _TextClip = Text.Length;
            }
            else
            {
                _TextClip = 0;
                _Choreographer.Enqueue (this);
            }
            Invalidate ();
        }

        protected override void DoRenderFunction (Graphics g, Brush BackBrush, Brush FunctionBrush)
        {
            base.DoRenderFunction (g, BackBrush, FunctionBrush);

            int width = ClientSize.Width;
            int height = ClientSize.Height;
            int half = height / 2;

            Rectangle r = new Rectangle (0, 0, width, height);
            g.FillRectangle (BackBrush, r);

            if (RoundedLeft)
            {
                g.FillPie (FunctionBrush, 0, 0, height, height, 90, 180);
                r.X += half;
                r.Width -= half;
            }

            if (RoundedRight)
            {
                g.FillPie (FunctionBrush, width - height, 0, height, height, 270, 180);
                r.Width -= half;
            }

            for (int i = 0; i < _RightSegments; i++)
            {
                r.Width -= height;
                g.FillRectangle (FunctionBrush, r.Right + half, 0, half + 1, height);
            }

            for (int i = 0; i < _LeftSegments; i++)
            {
                g.FillRectangle (FunctionBrush, r.X, 0, half, height);
                r.X += height;
                r.Width -= height;
            }

            // TODO: Use the padding here to reduce the rectangle where the text should be
            //       written.

            SizeF ef = g.MeasureString (Text, Font);

            float TextOffsetX = 0f;
            float TextOffsetY = 0f;

            // TODO: Use all options of the TextAlign enum to position the text

            switch (_TextAlign)
            {
                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomRight:
                    TextOffsetY = r.Bottom - ef.Height;
                    break;

                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.MiddleRight:
                    TextOffsetY = (r.Y + r.Bottom - ef.Height) / 2f;
                    break;

                case ContentAlignment.TopCenter:
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopRight:
                    TextOffsetY = r.Y;
                    break;
            }

            switch (_TextAlign)
            {
                case ContentAlignment.BottomLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.TopLeft:
                    TextOffsetX = r.X;
                    break;

                case ContentAlignment.BottomRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.TopRight:
                    TextOffsetX = r.Right - ef.Width;
                    break;

                case ContentAlignment.BottomCenter:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.TopCenter:
                    TextOffsetX = (r.X + r.Right - ef.Width) / 2f;
                    break;
            }

            // TODO: Add an option saying where to draw the rectangle:
            //       All the way
            //       Nowhere
            //       Only where there is no text
            //       Have a way to have different options depending hovering status.
            g.FillRectangle (FunctionBrush, r);

            using (SolidBrush TextBrush = new SolidBrush (ForeColor))
            {
                // TODO: Clip here according to the rectangle, so the
                //       text is properly rendered.
                g.DrawString (Text, Font, TextBrush, TextOffsetX, TextOffsetY);
            }
        }

        [Category ("Layout")]
        public int LeftSegments
        {
            get
            {
                return _LeftSegments;
            }
            set
            {
                if (_LeftSegments != value)
                {
                    _LeftSegments = value;
                    Invalidate ();
                }
            }
        }

        [Category ("Layout")]
        public int RightSegments
        {
            get
            {
                return _RightSegments;
            }
            set
            {
                if (_RightSegments != value)
                {
                    _RightSegments = value;
                    Invalidate ();
                }
            }
        }

        protected ContentAlignment TextAlign
        {
            get
            {
                return _TextAlign;
            }
            set
            {
                if (_TextAlign != value)
                {
                    _TextAlign = value;
                    Invalidate ();
                }
            }
        }

        [Category ("Layout")]
        public bool RoundedLeft
        {
            get
            {
                return _RoundedLeft;
            }
            set
            {
                if (_RoundedLeft != value)
                {
                    _RoundedLeft = value;
                    Invalidate ();
                }
            }
        }

        [Category ("Layout")]
        public bool RoundedRight
        {
            get
            {
                return _RoundedRight;
            }
            set
            {
                if (_RoundedRight != value)
                {
                    _RoundedRight = value;
                    Invalidate ();
                }
            }
        }
    }
}
