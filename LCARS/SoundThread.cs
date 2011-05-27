#region Original Work By Marcelo Chavez
//---------------------------------------------------------------------------------------------------
//
//  This library is based on original work by Marcelo Chavez.
//  Please see http://www.codeproject.com/KB/miscctrl/lcars_net_controls.aspx
//  for more information.
//
//---------------------------------------------------------------------------------------------------
#endregion

using System.Runtime.InteropServices;
using System.IO;
using System.Media;
using System.Timers;

namespace Streambolics.Lcars
{
    public class SoundThread
    {
        // Fields
        private string file;
        private bool loop;
        

        // Methods
        public SoundThread (string file, bool loop)
        {
            this.file = Directory.GetCurrentDirectory() + "\\" + file;
            this.loop = false;
        }

        public void Play ()
        {
            do
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(this.file);
                    player.Play();
                }
                catch
                {                    
                }
            }
            while (this.loop);
        }

    }

}