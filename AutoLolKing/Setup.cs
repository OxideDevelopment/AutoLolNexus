using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoLolNexus
{
    public partial class Setup : Form
    {
        public string ServerName
        {
            get { return serverName.Text; }
        }

        public string SummonerName
        {
            get { return summonerName.Text; }
        }
        public Setup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
