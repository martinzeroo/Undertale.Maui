using Undertale.Maui.Models;

namespace Views;

public partial class EndPage : ContentPage
{
    public EndPage(Monsters monsters)
    {
        InitializeComponent();

        this.BindingContext = monsters;
    }
}