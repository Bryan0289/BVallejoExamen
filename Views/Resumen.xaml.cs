using System.Xml.Linq;

namespace BVallejoExamen.Views;

public partial class Resumen : ContentPage
{
    string user;
    string date;
    string pais;
    string ciudad;
    decimal mInicial;
    decimal cuotas;
    string nombre;
    string apellido;
    string edad;
    public Resumen(string user, string date, string pais, string ciudad, decimal mInicial,
        decimal cuotas, string nombre, string apellido, string edad)
	{
        
        this.user = user;
        this.date = date;
        this.pais = pais;
        this.ciudad=ciudad;
        this.mInicial=mInicial;
        this.cuotas=cuotas;
        this.nombre=nombre;
        this.apellido=apellido;
        this.edad  =edad;
		InitializeComponent();
        loadData();
    }
    public void loadData()
    {
        lUser.Text = user;
        txtNombre.Text = nombre;
        txtApellido.Text = apellido;
        txtEdad.Text = edad;
        txtFecha.Text = date;
        txtCiudad.Text= ciudad;
        txtPais.Text= pais;
        txtMonInic.Text = mInicial.ToString();
        txtPagoMen.Text = cuotas.ToString();
        txtPagTotal.Text = ((cuotas * 4) + mInicial).ToString();

    }

    private void btnLogout_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());

    }
}