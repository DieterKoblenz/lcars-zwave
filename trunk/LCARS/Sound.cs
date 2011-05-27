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
using System.Drawing;
using System.Threading;

namespace Streambolics.Lcars
{
    [ToolboxBitmap (@"C:\Inetpub\wwwroot\LCARS\LCARS_Toolbox\icon\st1_16.ico")]
    public class Sound : Component
    {
        // Fields
        private Thread main;
        private SoundThread sound;

        // Methods
        public void PlayLoop (string soundFile)
        {
            this.sound = new SoundThread (soundFile, true);
            this.main = new Thread (new ThreadStart (this.sound.Play));
            this.main.Start ();
        }

        public void PlayOnce (string soundFile)
        {
            this.PlayOnce (soundFile, false);
        }

        public void PlayOnce (string soundFile, bool wait)
        {
            this.sound = new SoundThread (soundFile, false);
            this.main = new Thread (new ThreadStart (this.sound.Play));
            this.main.Start ();
            if (wait)
            {
                this.main.Join ();
                this.main = null;
            }
        }

        public void Stop ()
        {
            if ((this.main != null) && this.main.IsAlive)
            {
                this.main.Abort ();
                this.main.Join ();
            }
        }
    }


}