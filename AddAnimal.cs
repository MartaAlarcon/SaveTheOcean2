using SaveTheOcean2.Persistence.Utils;
using System.Text.RegularExpressions;
using SaveTheOcean2.Persistence.DAO;
using SaveTheOcean2.DTO;
using SaveTheOcean2.Persistence.Mapping;

namespace SaveTheOcean2
{
    public partial class AddAnimal : Form
    {
        public AddAnimal()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string regex = @"^[a-zA-Z]+$";
            Regex letters = new Regex(regex);
            string numbers = @"^[0-9]+$";
            Regex digits = new Regex(numbers);

            if (!letters.IsMatch(txtBoxName.Text))
            {
                errorProviderString.SetError(txtBoxName, "Introdueix un nom vàlid");
            }
            else if (!letters.IsMatch(txtBoxFamily.Text))
            {
                errorProviderString.SetError(txtBoxFamily, "Introdueix una família vàlida");
            }
            else if (!letters.IsMatch(txtBoxPlace.Text))
            {
                errorProviderString.SetError(txtBoxPlace, "Introdueix un lloc vàlid");
            }
            else if (!letters.IsMatch(txtBoxSpecies.Text))
            {
                errorProviderString.SetError(txtBoxSpecies, "Introdueix una espècie vàlida");
            }
            else if (!digits.IsMatch(txtBoxWeight.Text))
            {
                errorProviderString.SetError(txtBoxWeight, "Introdueix un pes vàlid (només nombres enters");
            }
            else
            {
                errorProviderString.SetError(txtBoxName, "");
            }

            string Name = txtBoxName.Text;
            string Family = txtBoxFamily.Text;
            string Place = txtBoxPlace.Text;
            string Species = txtBoxName.Text;
            int Weight = Convert.ToInt32(txtBoxWeight.Text);



            IAnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
            AnimalDTO animal = new AnimalDTO
            {

                Name = Name,
                Family = Family,
                Place = Place,
                Species = Species,
                Weight = Weight

            };

            try
            {
                animalDAO.AddAnimal(animal);
                MessageBox.Show("Animal persistit correctament.");
                Hide();
                ChooseAnimal chooseAnimal = new ChooseAnimal();
                chooseAnimal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al persistir l'animal: {ex.Message}");
            }
        }

    }
}
