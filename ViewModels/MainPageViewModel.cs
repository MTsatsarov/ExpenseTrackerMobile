using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExpenseTrackerMobile.Models.Login;
using ExpenseTrackerMobile.Services.Interfaces;

namespace ExpenseTrackerMobile.ViewModels
{
	
	public partial class MainPageViewModel : BaseViewModel
	{
		public MainPageViewModel(IAccountService service)
		{
			this.Title = "Sign In";
			this.service = service;
		}

		[ObservableProperty]
		LoginModel model;
		private readonly IAccountService service;

		[RelayCommand]
		public async Task GoToRegister()
		{
			await Shell.Current.GoToAsync(nameof(RegisterPage),true);
		}

		[RelayCommand]
		public async Task SignIn()
		{
			 await this.service.LoginUser(Model.Email, Model.Password);
		}
	}
}
