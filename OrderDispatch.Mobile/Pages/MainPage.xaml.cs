using OrderDispatch.Mobile.Models;
using OrderDispatch.Mobile.PageModels;

namespace OrderDispatch.Mobile.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}