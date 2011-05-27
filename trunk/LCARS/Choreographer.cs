using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Streambolics.Lcars
{
    public class Choreographer : Component
    {
        public Choreographer ()
        {
            InitializeComponent ();
        }

        public Choreographer (IContainer container)
        {
            container.Add (this);
            InitializeComponent ();
        }

        private void InitializeComponent ()
        {
        }

        internal void Enqueue (Panel aPanel)
        {
        }
    }
}
