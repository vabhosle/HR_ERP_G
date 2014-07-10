using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace form1
{
    public partial class Splash : Form
    {
        public Splash()
        {
            Timer t1 = new Timer();
            t1.Tick += new EventHandler(ticked);
            t1.Interval = 2000;
            t1.Start();
            InitializeComponent();
        }

        private void ticked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
