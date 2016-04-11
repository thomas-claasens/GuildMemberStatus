using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BattleDotNet;

namespace GuildMemberDetails
{
    public partial class Form1 : Form
    {
        private string apiKey = "qrfwx6c29zs8g2hw8ze2qz7yke9r36v2";
        private string secret = "Gx7usVwT3vfKnE3GuWsq5y2hjGYYNjjZ";
        private BattleDotNet.WoWClient bNetClient;
        public Form1()
        {
            InitializeComponent();
            bNetClient = new WoWClient(BattleDotNet.Region.EU, apiKey, secret);
            Console.WriteLine(bNetClient.GetAuctions("silvermoon").Alliance.Count());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var guild = bNetClient.GetGuild("Forward únto Dawn", "Silvermoon");
            Console.WriteLine(guild.Members.Count());

        }
    }
}
