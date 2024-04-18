namespace RolagemDados
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            DiceSidesPicker.SelectedItem = 0;
        }

        private void OnRollBtn_Clicked(object sender, EventArgs e)
        {

            int selectedSides = Convert.ToInt32(DiceSidesPicker.SelectedItem);
            int numeroSorteado = new Random().Next(1, selectedSides + 1);
            //int numeroSorteado = new Random().Next(1, selectedSides) + 1;
            ResultNumber.Text = numeroSorteado.ToString();

        }
    }
}
