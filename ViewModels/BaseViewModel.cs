﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace ExpenseTrackerMobile.ViewModels
{
	public partial class BaseViewModel : ObservableObject
	{
		[ObservableProperty]
		[NotifyPropertyChangedFor(nameof(IsNotBusy))]
		private bool isBusy;

		[ObservableProperty]
		private string title;

		public bool IsNotBusy => !isBusy;
	}
	
}
