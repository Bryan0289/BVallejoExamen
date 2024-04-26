namespace BVallejoExamen.Views;


public class Usuario
{
    public string user { get; set; }
    public string pass { get; set; }
}

public partial class Login : ContentPage
{
    
    List<Usuario> usuarios = new List<Usuario>();
    public Login()
	{

        loadUsers();
        InitializeComponent();
	}
    public void loadUsers()
    {
        usuarios.Add(new Usuario { user = "estudiante2024", pass = "uisrael2024" });
        usuarios.Add(new Usuario { user = "examen1", pass = "parcial1" });
        usuarios.Add(new Usuario { user = "NombreEstudiante", pass = "2024" });

    }

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        string user = txtUser.Text;
        string pass = txtPassword.Text;
        foreach (var usuario in usuarios)
        {

            if (usuario.user == user && usuario.pass == pass)
            {
                Navigation.PushAsync(new Registro(user));
                return;
            }
        }
        DisplayAlert("Error", "Usuario incorrecto", "OK");

    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaDe());
    }
}