namespace tallersem3djahuaco.View;

public partial class V2 : ContentPage
{
	public V2()
	{
		InitializeComponent();
		
	}
	private void btnAbrir(object sender, EventArgs e)
	{
		Navigation.PushAsync(new View.V3());
	}
}