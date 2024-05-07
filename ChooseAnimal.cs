using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalvaOceano;

namespace SaveTheOcean2
{
    public partial class ChooseAnimal : Form
    {
        public ChooseAnimal()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Hide();
            AddAnimal addAnimal = new AddAnimal();
            addAnimal.ShowDialog();
        }

        private void buttonAnimal_Click(object sender, EventArgs e)
        {
            Hide();
            ChooseRole escogerRol = new ChooseRole();
            escogerRol.ShowDialog();
        }
    }
}
