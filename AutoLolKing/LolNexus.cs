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
    public partial class LolNexus : Form
    {

        private string Server;
        private string SummonerName;

        public LolNexus(string server, string summonerName)
        {
            InitializeComponent();

            Server = server;
            SummonerName = summonerName;
        }

        private void LolNexus_Load(object sender, EventArgs e)
        {
            var builder = new StringBuilder();
            builder.Append("http://www.lolnexus.com/");
            builder.Append(Server);
            builder.Append("/");
            builder.Append("search?name=");
            builder.Append(SummonerName);
            builder.Append("&region=");
            builder.Append(Server);

            webControl1.Source = new Uri(builder.ToString());
        }
    }
}
