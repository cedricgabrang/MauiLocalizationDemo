using MauiLocalizationDemo.Resources.Strings;

namespace MauiLocalizationDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"{AppResources.Clicked} {count} {AppResources.Times}";
		else
			CounterBtn.Text = $"{AppResources.Clicked} {count} {AppResources.Times}";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

