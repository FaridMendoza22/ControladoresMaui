namespace Formulario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            datepicker.Date = DateTime.Now;
            datepicker.MinimumDate = new DateTime(2022, 06, 05);
            datepicker.MaximumDate = new DateTime(2024, 06, 05);
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {  
            var name= nombres.Text;
            var lastname = apellido.Text;
            var email = gmail.Text;
            var date = datepicker.Date;
            var gender = genero.SelectedItem;
            var check = chkAceptaPoliticas.IsChecked ?"Acepto Politicas":"No Acepto Politicas";
            _ =DisplayAlert("Éxito", $"{name}\n{lastname}\n{email}\n{date}\n{gender}\n{check}", "OK");
        }
       
    }
}

