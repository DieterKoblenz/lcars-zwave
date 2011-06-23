#region Original Work By Marcelo Chavez
//---------------------------------------------------------------------------------------------------
//
//  This library is based on original work by Marcelo Chavez.
//  Please see http://www.codeproject.com/KB/miscctrl/lcars_net_controls.aspx
//  for more information.
//
//---------------------------------------------------------------------------------------------------
#endregion

using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System;

namespace Streambolics.Lcars
{
    /// <summary>
    ///     The base class for all LCARS controls.
    /// </summary>

    // TODO: See what happens if we use a Control instead of a UserControl here.

    public class LcarsControl : Control
    {
        // TODO: Embed the font, following http://www.bobpowell.net/embedfonts.htm
        private static Font _LcarsFont = new Font ("LCARS", 14, FontStyle.Regular);

        private Function _Function = Function.Primary;
        private SubFunction _SubFunction = SubFunction.Unavailable;
        private ContentAlignment _ElboOrientation = ContentAlignment.TopLeft;
        private bool _Online = true;
        private bool _UseAlternateColor = false;
        private bool _Highlighted = false;
        private bool _InAlert = false;
        
        public LcarsControl ()
        {
            BackColor = Color.Black;
            ForeColor = Color.White;
            Font = _LcarsFont;

            SetStyle (ControlStyles.DoubleBuffer, true);
            SetStyle (ControlStyles.AllPaintingInWmPaint, true);
            SetStyle (ControlStyles.ResizeRedraw, true);
        }

        /// <summary>
        ///     The color associated with the current function and status
        ///     of the control.
        /// </summary>
        /// <returns>
        ///     The color to use. The output is typically used to create a brush
        ///     to paint the active portion of a control.
        /// </returns>
        /// <seealso>GetFunctionBrush</seealso>

        public Color GetFunctionColor()
        {
            switch (_InAlert)
            {
                #region In Alert
                case true:
                    {
                        switch (_Online)
                        {
                            case false:
                                {
                                    switch (_UseAlternateColor)
                                    {
                                        case true:
                                            return Color.FromArgb(0x33, 0x00, 0x00);
                                        default:
                                            return Color.FromArgb(0xFF, 0x00, 0x00);
                                    }
                                }
                            default:
                                {
                                    switch (_UseAlternateColor)
                                    {
                                        case false:
                                            {
                                                return Color.FromArgb(0xFF, 0x00, 0x00);
                                            }
                                        default:
                                            {
                                                return Color.FromArgb(0x33, 0x00, 0x00);
                                            }
                                    }
                                }
                        }
                    }
                #endregion
                #region Not In Alert
                default:
                    {
                        switch (_Online)
                        {
                            #region Offline
                            case false:
                                {
                                    switch (_UseAlternateColor)
                                    {
                                        case true:
                                            return Color.FromArgb(0x33, 0x00, 0x00);
                                        default:
                                            return Color.FromArgb(0xFF, 0x00, 0x00);
                                    }
                                }
                            #endregion
                            #region Online
                            default:
                                {
                                    switch (_Function)
                                    {
                                        #region Primary
                                        case Function.Primary:
                                            {
                                                switch (_SubFunction)
                                                {
                                                    case SubFunction.Elbo:
                                                        return Color.FromArgb(0xF1, 0xDF, 0x6F);
                                                    case SubFunction.Offline:
                                                        {
                                                            switch (_UseAlternateColor)
                                                            {
                                                                case true:
                                                                    return Color.FromArgb(0x33, 0x00, 0x00);
                                                                default:
                                                                    return Color.FromArgb(0xFF, 0x00, 0x00);
                                                            }
                                                        }
                                                    case SubFunction.Unavailable:
                                                        return Color.FromArgb(0x33, 0x99, 0xFF);
                                                    case SubFunction.Primary:
                                                        return Color.FromArgb(0x99, 0xCC, 0xFF);
                                                    case SubFunction.Color1:
                                                        return Color.FromArgb(0xFF, 0xFF, 0x33);
                                                    case SubFunction.Color2:
                                                        return Color.FromArgb(0xFF, 0xFF, 0xCC);
                                                }
                                                break;
                                            }
                                        #endregion
                                        #region Secondary
                                        case Function.Secondary:
                                            {
                                                switch (_SubFunction)
                                                {
                                                    case SubFunction.Elbo:
                                                        return Color.FromArgb(0xB1, 0x95, 0x7A);
                                                    case SubFunction.Offline:
                                                        {
                                                            switch (_UseAlternateColor)
                                                            {
                                                                case true:
                                                                    return Color.FromArgb(0x33, 0x00, 0x00);
                                                                default:
                                                                    return Color.FromArgb(0xFF, 0x00, 0x00);
                                                            }
                                                        }
                                                    case SubFunction.Unavailable:
                                                        return Color.FromArgb(0x53, 0x55, 0xDE);
                                                    case SubFunction.Primary:
                                                        return Color.FromArgb(0x99, 0xCC, 0xFF);
                                                    case SubFunction.Color1:
                                                        return Color.FromArgb(0xFF, 0xCC, 0x00);
                                                    case SubFunction.Color2:
                                                        return Color.FromArgb(0xFF, 0xFF, 0x99);
                                                }
                                                break;
                                            }
                                        #endregion
                                        #region Ancillary
                                        case Function.Ancillary:
                                            {
                                                switch (_SubFunction)
                                                {
                                                    case SubFunction.Elbo:
                                                        return Color.FromArgb(0xF1, 0xB1, 0xAF);
                                                    case SubFunction.Offline:
                                                        {
                                                            switch (_UseAlternateColor)
                                                            {
                                                                case true:
                                                                    return Color.FromArgb(0x33, 0x00, 0x00);
                                                                default:
                                                                    return Color.FromArgb(0xFF, 0x00, 0x00);
                                                            }
                                                        }
                                                    case SubFunction.Unavailable:
                                                        return Color.FromArgb(0xA2, 0x7F, 0xA5);
                                                    case SubFunction.Primary:
                                                        return Color.FromArgb(0xAD, 0xAC, 0xD8);
                                                    case SubFunction.Color1:
                                                        return Color.FromArgb(0xFF, 0xFF, 0x33);
                                                    case SubFunction.Color2:
                                                        return Color.FromArgb(0xE6, 0xB0, 0xD4);
                                                }
                                                break;
                                            }
                                        #endregion
                                        #region Database
                                        case Function.Database:
                                            {
                                                switch (_SubFunction)
                                                {
                                                    case SubFunction.Elbo:
                                                        return Color.FromArgb(0xCC, 0x66, 0x66);
                                                    case SubFunction.Offline:
                                                        {
                                                            switch (_UseAlternateColor)
                                                            {
                                                                case true:
                                                                    return Color.FromArgb(0x33, 0x00, 0x00);
                                                                default:
                                                                    return Color.FromArgb(0xFF, 0x00, 0x00);
                                                            }
                                                        }
                                                    case SubFunction.Unavailable:
                                                        return Color.FromArgb(0xCC, 0xCC, 0xFF);
                                                    case SubFunction.Primary:
                                                        return Color.FromArgb(0x99, 0xCC, 0xFF);
                                                    case SubFunction.Color1:
                                                        return Color.FromArgb(0xFF, 0x99, 0x00);
                                                    case SubFunction.Color2:
                                                        return Color.Black;
                                                }
                                                break;
                                            }
                                        #endregion
                                        #region MultiDisplay
                                        case Function.MultiDisplay:
                                            {
                                                switch (_SubFunction)
                                                {
                                                    case SubFunction.Elbo:
                                                        {
                                                            switch (_ElboOrientation)
                                                            {
                                                                case ContentAlignment.BottomLeft:
                                                                    return Color.FromArgb(0x99, 0xCC, 0xFF);
                                                                case ContentAlignment.BottomRight:
                                                                    return Color.FromArgb(0x99, 0xCC, 0xFF);
                                                                case ContentAlignment.TopLeft:
                                                                    return Color.FromArgb(0xCC, 0x66, 0x66);
                                                                case ContentAlignment.TopRight:
                                                                    return Color.FromArgb(0xCC, 0x66, 0x66);
                                                            }
                                                            break;
                                                        }
                                                    case SubFunction.Offline:
                                                        {
                                                            switch (_UseAlternateColor)
                                                            {
                                                                case true:
                                                                    return Color.FromArgb(0x33, 0x00, 0x00);
                                                                default:
                                                                    return Color.FromArgb(0xFF, 0x00, 0x00);
                                                            }
                                                        }
                                                    case SubFunction.Unavailable:
                                                        return Color.FromArgb(0x33, 0x99, 0xFF);
                                                    case SubFunction.Primary:
                                                        return Color.FromArgb(0x99, 0xCC, 0xFF);
                                                    case SubFunction.Color1:
                                                        return Color.FromArgb(0xFF, 0x99, 0x00);
                                                    case SubFunction.Color2:
                                                        return Color.FromArgb(0xCC, 0x99, 0xCC);
                                                }
                                                break;
                                            }
                                        #endregion
                                        #region RedAlert
                                        case Function.RedAlert:
                                            {
                                                switch (_SubFunction)
                                                {
                                                    case SubFunction.Offline:
                                                        {
                                                            switch (_UseAlternateColor)
                                                            {
                                                                case true:
                                                                    return Color.FromArgb(0x33, 0x00, 0x00);
                                                                default:
                                                                    return Color.FromArgb(0xFF, 0x00, 0x00);
                                                            }
                                                        }
                                                    default:
                                                        {
                                                            return Color.FromArgb(0xFF, 0x00, 0x00);
                                                        }
                                                }
                                            }
                                        #endregion
                                    }
                                    return Color.White;
                                }
                            #endregion
                        }
                    }
                #endregion

            }
        }

        /// <summary>
        ///     A brush to paint the functional part of the control.
        /// </summary>
        /// <returns></returns>

        protected Brush GetFunctionBrush ()
        {
            return new SolidBrush (GetFunctionColor ());
        }

        /// <summary>
        ///     A brush to paint the non-functional background part of the control.
        /// </summary>
        /// <returns></returns>

        protected Brush GetBackgroundBrush ()
        {
            return new SolidBrush (BackColor);
        }

        #region Function

        protected virtual void OnFunctionChanged (EventArgs e)
        {
            Invalidate ();
        }

        [Category ("Behavior")]
        [Description ("Function of this control. This in turn determines its color.")]
        public Function Function
        {
            get
            {
                return _Function;
            }
            set
            {
                if (_Function != value)
                {
                    _Function = value;
                    OnFunctionChanged (EventArgs.Empty);
                }
            }
        }

        #endregion

        #region Online

        [Category("Behavior")]
        public bool Online
        {
            get
            {
                return _Online;
            }
            set
            {
                if (_Online != value)
                {
                    _Online = value;
                    Invalidate ();
                }
            }
        }

        #endregion

        /// <summary>
        ///     Whether to use the alternate color.
        /// </summary>
        /// <remarks><para>
        ///     This feature is used by the blinking state
        /// </para></remarks>
        protected bool UseAlternateColor
        {
            get
            {
                return _UseAlternateColor;
            }
            set
            {
                _UseAlternateColor = value;
            }
        }
        public SubFunction SubFunction { get { return _SubFunction; } set { _SubFunction = value; } }
        public bool InAlert { get { return _InAlert; } set { _InAlert = value; } }
        public ContentAlignment ElboOrientation { get { return _ElboOrientation; } set { _ElboOrientation = value; } }
        #region Highlighted

        protected virtual void OnHighlightedChanged (EventArgs e)
        {
            Invalidate ();
        }

        protected bool Highlighted
        {
            get
            {
                return _Highlighted;
            }
            set
            {
                if (_Highlighted != value)
                {
                    _Highlighted = value;
                    OnHighlightedChanged (EventArgs.Empty);
                }
            }
        }

        #endregion

        protected override void OnEnabledChanged (System.EventArgs e)
        {
            base.OnEnabledChanged (e);
            Invalidate ();
        }

        protected virtual void DoRenderFunction (Graphics g, Brush BackBrush, Brush FunctionBrush)
        {
        }

        protected override void OnPaint (PaintEventArgs e)
        {
            base.OnPaint (e);
            Graphics g = e.Graphics;

            // TODO: Expose those two so they can be changed by the designer.

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            using (Brush bb = GetBackgroundBrush ())
            {
                using (Brush fb = GetFunctionBrush ())
                {
                    DoRenderFunction (g, bb, fb);
                }
            }
        }


    }
}
