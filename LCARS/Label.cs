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

namespace Streambolics.Lcars
{
    // TODO: Make the label derive from a panel so it gets all the interesting features.
    //       Move the drawing of the caption into the panel.
    //       Expose the Caption property (in reality, the Text property...)

    [ToolboxBitmap (@"C:\Inetpub\wwwroot\LCARS\LCARS_Toolbox\icon\st1_16.ico")]
    public class Label : Panel
    {
        public Label ()
        {
            this.InitializeComponent ();
        }

        private void InitializeComponent ()
        {
            base.Name = "LCARS_Label";
            base.Size = new Size (0x80, 40);
        }

        public new ContentAlignment TextAlign
        {
            get
            {
                return base.TextAlign;
            }
            set
            {
                base.TextAlign = value;
            }
        }

    }


}
