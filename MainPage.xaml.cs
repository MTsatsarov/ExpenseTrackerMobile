﻿using ExpenseTrackerMobile.ViewModels;

namespace ExpenseTrackerMobile;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

