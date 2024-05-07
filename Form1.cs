using SaveTheOcean2;
namespace SalvaOceano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            XMLHelpers.AddFalsePlay();


            Hide();
            ChooseAnimal chooseAnimal = new ChooseAnimal();
            chooseAnimal.ShowDialog();
        
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
