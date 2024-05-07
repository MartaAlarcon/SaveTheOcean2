using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalvaOceano.DTO;
using SaveTheOcean2;
using System.Xml;
using System.IO;
using SalvaOceano;
using System.Web;


namespace SalvaOceano
{
    public partial class ChooseRole : Form
    {
        public ChooseRole()
        {
            InitializeComponent();
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            if (CB_Rol.Text == "Veterinario")
            {
                Player player = new Player
                {
                    Name = TXT_Name.Text,
                    Rol = CB_Rol.Text,
                    Xp = 80,
                    Play = true
                };
                string name = player.Name;
                string xmlFilePath = "player.xml";

                XMLHelpers.CreateXMLFile(player, xmlFilePath);

                Hide();
                Game game = new Game(name);
                game.ShowDialog();

            }
            else
            {
                Player player = new Player
                {
                    Name = TXT_Name.Text,
                    Rol = CB_Rol.Text,
                    Xp = 45,
                    Play = true
                };
                string name = player.Name;
                string xmlFilePath = "player.xml";

                XMLHelpers.CreateXMLFile(player, xmlFilePath);

                Hide();
                Game game = new Game(name);
                game.ShowDialog();

            }
        }
    }
}
