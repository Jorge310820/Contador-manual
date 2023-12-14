namespace CONTADOR_MANUAL;

public partial class MainPage : ContentPage
{
    private int _contador = 0;
    public MainPage()
    {
        InitializeComponent();
    }
    private void OnContarButtonClicked(object sender, EventArgs
   e)
    {
        int incrementValue = (int)IncrementSlider.Value;
        _contador += incrementValue;
        ConteoLabel.Text = _contador.ToString();
    }
    private void OnReiniciarButtonClicked(object sender,
   EventArgs e)
    {
        _contador = 0;
        ConteoLabel.Text = _contador.ToString();
    }
    private void OnIncrementValueChanged(object sender,
   ValueChangedEventArgs e)
    {
        int incrementValue = (int)e.NewValue;
        ConteoLabel.Text = _contador.ToString();
        IncrementLabel.Text = $"Incremento: {incrementValue}";
    }
}