namespace TemasMauiApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void temaSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        var recursos = Application.Current!.Resources.MergedDictionaries;

        var claro = recursos.OfType<Resources.Styles.Claro>().FirstOrDefault();
        var oscuro = recursos.OfType<Resources.Styles.Oscuro>().FirstOrDefault();

        if (e.Value) // Activado → tema oscuro
        {
            if (oscuro == null)
                recursos.Add(new Resources.Styles.Oscuro());

            if (claro != null)
                recursos.Remove(claro);
        }
        else // Desactivado → tema claro
        {
            if (claro == null)
                recursos.Add(new Resources.Styles.Claro());

            if (oscuro != null)
                recursos.Remove(oscuro);
        }
    }
}



