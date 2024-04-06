namespace jlicuyT1.Vistas;

public partial class VPrincipal : ContentPage
{
	public VPrincipal()
	{
		InitializeComponent();
	}

    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
		string nombre = nombreIngresado.Text;
        string apellido = apellidoIngresado.Text;
		int edad = int.Parse(edadIngresado.Text);
		decimal salario = decimal.Parse(salarioIngresado.Text);

		decimal datocalculado = salario * 0.0945m;


        DisplayAlert("Información de Aporte IESS",
            "Bienvenido " + nombre + " " + apellido + " \n" +
            "Tienes " + edad + " años\n" +
            "Tu aporte mensual es $" + datocalculado.ToString("N2"), "Cerrar");

    }
}