namespace tallersem3djahuaco.View;

public partial class V1 : ContentPage
{
	public V1()
	{
		InitializeComponent();
	}
	public void btnRegistrar(object sender, EventArgs e)
	{
        Navigation.PushAsync(new View.V3());
    }
	public void btnInicar(object sender, EventArgs e)
	{
		Navigation.PushAsync(new View.V2());
	}
}