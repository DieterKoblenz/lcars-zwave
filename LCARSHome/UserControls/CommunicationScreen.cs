using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Sloppycode.net;
using System.IO;
using System.Runtime.InteropServices;

namespace LCARSHome.UserControls
{
    public partial class CommunicationScreen : UserControl
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        private int _itemsFound = 0;
        private string _URL;
        private RssFeed _feed;
        private Status _CurrentStatus = Status.Green;

        internal void SetStatus(Status status)
        {
            this._CurrentStatus = status;
            switch (status)
            {
                case Status.Green:
                    {

                        //TODO: Add Events
                        break;
                    }
                case Status.Yellow:
                    {
                        //TODO: Add Events
                        break;
                    }
                case Status.Red:
                    {
                        //TODO: Add Events
                        break;
                    }
                case Status.Blue:
                    {
                        //TODO: Add Events
                        break;
                    }
            }
        }
        public CommunicationScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sound1.PlayOnce("Resources\\DoubleBeep.wav");
            Thread.Sleep(800);
            Program._MainForm.LoadScreen(Screen.HomeScreen, Screen.CommunicationScreen);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _URL = button3.Tag.ToString();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private RssFeed readRss(string URL)
        {
            RssReader rssReader = new RssReader();
            rssReader.RdfMode = false;
            rssReader.FeedLoaded += new EventHandler(rssReader_FeedLoaded);
            rssReader.ItemAdded += new EventHandler(rssReader_ItemAdded);
            RssFeed feed = rssReader.Retrieve(URL);

            return feed;
        }

        #region Feed event handlers
		private void rssReader_FeedLoaded(object sender, System.EventArgs e)
		{
			//this.statusBar1.Text = "RSS feed loaded succesfully.";
		}

		private void rssReader_ItemAdded(object sender, System.EventArgs e)
		{
			this._itemsFound++;
		}

		private void rssReader_Error(object sender, RssReaderErrorEventArgs e)
		{
            sound1.PlayOnce("Resources\\UnableToComply.wav");
			//this.statusBar1.Text = "Error occured: "+e.Message;
		}
		#endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            RssFeed feed = readRss(_URL);
            _feed = feed;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_feed.ErrorMessage == null || _feed.ErrorMessage == "")
            {
                string template = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Resources\\RSSTemplate.html");
                string html = RssReader.CreateHtml(_feed, template, this.richTextBoxItemPrefix.Text, "", 5);

                StreamWriter streamWriter = File.CreateText(Directory.GetCurrentDirectory()+"\\rss.html");
                streamWriter.Write(html);
                streamWriter.Close();
                webBrowser1.Navigate(Directory.GetCurrentDirectory() + "\\rss.html");
               // System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\rss.html");
            }
            else
            {
                sound1.PlayOnce("Resources\\UnableToComply.wav");
            }
        }

        private void webBrowser1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible==true)
            {
                try
                {
                    webBrowser1.Navigate("about:<html><head><title></title></head><body bgcolor=black></body></html>");
                }
                catch { }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _URL = button4.Tag.ToString();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _URL = button6.Tag.ToString();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        public void button10_Click(object sender, EventArgs e)
        {
            if (button10.SubFunction != Streambolics.Lcars.SubFunction.Color1)
            {
                button10.SubFunction = Streambolics.Lcars.SubFunction.Color1;
                mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
                mciSendString("record recsound", "", 0, 0);
                Console.WriteLine("recording...");
            }
            else
            {
                button10.SubFunction = Streambolics.Lcars.SubFunction.Primary;
                Console.WriteLine("end recording...");
                string path = "C:\\Work\\LOG-" + DateTime.Now.ToString("MMddyyyyHHmmss") + ".wav";
                mciSendString("save recsound " + path, "", 0, 0);
                mciSendString("close recsound ", "", 0, 0);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
