namespace BVallejoExamen.Views;

public partial class Registro : ContentPage
{
	string user;
	Boolean isCalculate = false;
	public Registro(string user)
	{
		//userName = user;
		InitializeComponent();
        this.user = user;
		lUser.Text= this.user;
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        string monto= txtMontoIni.Text;
        
        if (monto ==null)
        {
            DisplayAlert("Error", "Monto Vacio", "OK");
            return;
        }
        isCalculate = true;
        decimal montoInicial = Decimal.Parse(txtMontoIni.Text);
		decimal costo = 1500;
		decimal porcentaje = 1500 * 0.04m;

        decimal cuotaM = (costo - montoInicial) / 4+porcentaje;

        txtPagos.Text=cuotaM.ToString();




    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
		if (isCalculate)
		{
            string date = dpFecha.Date.ToString("dd/MM/yyyy");
            string pais = pkPais.SelectedItem.ToString()!;
            string ciudad = pkCiudad.SelectedItem.ToString()!;
            decimal mInicial = Decimal.Parse(txtMontoIni.Text);
            decimal cuotas = Decimal.Parse(txtPagos.Text);
            string nombre = txtName.Text;
            string apellido = txtApelldio.Text;
            string edad= txtEdad.Text;



            Navigation.PushAsync(new Resumen(user,date, pais, ciudad, mInicial,cuotas,nombre, apellido, edad));

        }
		DisplayAlert("Error", "Calcular Primero", "ok");

    }

    private void txtMontoIni_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (!int.TryParse(e.NewTextValue, out int numero))
        {
            DisplayAlert("Error", "Por favor ingresa solo números.", "OK");
            txtPagos.Text = e.OldTextValue;
            return;
        }

        if (numero >= 1500)
        {
            DisplayAlert("Error", "El número debe ser menor a 1500.", "OK");
            txtPagos.Text = e.OldTextValue;
            return;
        }
    }
}