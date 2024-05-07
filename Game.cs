using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveTheOcean2;
using SalvaOceano.DTO;
using Npgsql;
using SaveTheOcean2.Persistence.Utils;


namespace SalvaOceano
{
    public partial class Game : Form
    {
        private string playerName;

        public Game(string name)
        {
            InitializeComponent();
            playerName = name;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            ChooseRole chooseRole = new ChooseRole();
            labelWelcome.Text = "Hola " + playerName + "! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. \r\nLes dades que ens han donat són les següents:";
            lblRescueNum.Text = RandomRescue();
            DateOnly date = new DateOnly();
            lblDate.Text = date.ToString();
            lblGA.Text = RandomGA();
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT * FROM \"animals\" ORDER BY RANDOM() LIMIT 1";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Obtener los datos del animal aleatorio
                    string name = reader.GetString(reader.GetOrdinal("name"));
                    string place = reader.GetString(reader.GetOrdinal("place"));
                    string family = reader.GetString(reader.GetOrdinal("family"));
                    string species = reader.GetString(reader.GetOrdinal("species"));
                    double weight = reader.GetInt32(reader.GetOrdinal("weight"));

                    // Mostrar los datos en las etiquetas correspondientes
                    labelName.Text = name;
                    lblPlace.Text = place;
                    lblFamily.Text = family;
                    labelSF.Text = family;
                    labelSpecies.Text = species;
                    labelWeight.Text = weight.ToString();
                }
            }
        }

        public static string RandomRescue()
        {
            //El número de rescat  amb les sigles “RES“ seguides d’un valor aleatori de 3 xifres (entre el 0 i el 999, inclosos).

            Random random = new Random();
            int num = random.Next(0, 1000);
            return "RES" + num.ToString("000");

        }
        public static string RandomGA()
        {
            //El grau d’afectació de l'exemplar es generarà de manera aleatòria entre el 1 i el 99 (inclosos).
            Random random = new Random();
            int num = random.Next(1, 100);
            return num.ToString();
        }

        private void bttnSaveHere_Click(object sender, EventArgs e)
        {
            if (lblFamily.Text == "Au Marina")
            {
                // GAnou = (GA - x)/5,on x = 5
                int GA = int.Parse(lblGA.Text);
                int x = 5;
                int GAnew = (GA - x) / 5;
                if (GAnew <= 30)
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.\r\nFins el proper rescat!\r\n");
                    XMLHelpers.AddXp(50);
                }
                else
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.");
                    XMLHelpers.AddXp(-20);
                }
            }
            else if (lblFamily.Text == "Tortuga marina")
            {
                //GAnou = (2·GA + 3) - ((GA - 20)·2) - x, on x = 15
                int GA = int.Parse(lblGA.Text);
                int x = 15;
                int GAnew = (2 * GA + 3) - ((GA - 20) * 2) - x;
                if (GAnew <= 30)
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.\r\nFins el proper rescat!\r\n");
                    XMLHelpers.AddXp(50);
                }
                else
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.");
                    XMLHelpers.AddXp(-20);
                }
            }
            else if (lblFamily.Text == "Cetaci")
            {
                // GAnou = GA - (GA/5) - x, on x = 50
                int GA = int.Parse(lblGA.Text);
                int x = 50;
                int GAnew = GA - (GA / 5) - x;
                if (GAnew <= 30)
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.\r\nFins el proper rescat!\r\n");
                    XMLHelpers.AddXp(50);
                }
                else
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.");
                    XMLHelpers.AddXp(-20);
                }
            }
            else
            {
                int GA = int.Parse(lblGA.Text);
                int x = 5;
                int GAnew = (GA - x) / 5;
                if (GAnew <= 30)
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.\r\nFins el proper rescat!\r\n");
                    XMLHelpers.AddXp(50);
                }
                else
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.");
                    XMLHelpers.AddXp(-20);
                }
            }
            Close();
        }

        private void bttnSaveCram_Click(object sender, EventArgs e)
        {
            if (lblFamily.Text == "Au Marina")
            {
                // GAnou = (GA - x)/5,on x = 0
                int GA = int.Parse(lblGA.Text);
                int x = 0;
                int GAnew = (GA - x) / 5;
                if (GAnew <= 30)
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.\r\nFins el proper rescat!\r\n");
                    XMLHelpers.AddXp(50);

                }
                else
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.");
                    XMLHelpers.AddXp(-20);

                }
            }
            else if (lblFamily.Text == "Tortuga marina")
            {
                //GAnou = (2·GA + 3) - ((GA - 20)·2) - x, on x = 15
                int GA = int.Parse(lblGA.Text);
                int x = 15;
                int GAnew = (2 * GA + 3) - ((GA - 20) * 2) - x;
                if (GAnew <= 30)
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.\r\nFins el proper rescat!\r\n");
                    XMLHelpers.AddXp(50);

                }
                else
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.");
                    XMLHelpers.AddXp(-20);
                }
            }
            else if (lblFamily.Text == "Cetaci")
            {
                // GAnou = GA - (GA/5) - x, on x = 0
                int GA = int.Parse(lblGA.Text);
                int x = 0;
                int GAnew = GA - (GA / 5) - x;
                if (GAnew <= 30)
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.\r\nFins el proper rescat!\r\n");
                    XMLHelpers.AddXp(50);

                }
                else
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.");
                    XMLHelpers.AddXp(-20);

                }
            }
            else
            {
                int GA = int.Parse(lblGA.Text);
                int x = 5;
                int GAnew = (GA - x) / 5;
                if (GAnew <= 30)
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.\r\nFins el proper rescat!\r\n");
                    XMLHelpers.AddXp(50);

                }
                else
                {
                    MessageBox.Show($"El tractament aplicat ha reduït el GA fins al {GAnew}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.");
                    XMLHelpers.AddXp(-20);

                }
            }
            Close();
        }
    }
}
