using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CardGame.ViewModels
{
	internal class BaseViewModel : INotifyPropertyChanged
	{
		bool isBusy = false;
		public bool IsBusy {
			get { return isBusy; }
			set { SetProperty(ref isBusy, value); }
		}

		string title = string.Empty;
		public string Title
		{
			get { return title; }
			set { SetProperty(ref title, value); }
		}

		protected bool SetProperty<T>(ref T backingStore, 
			T value, [CallerMemberName] string propertyName = "", 
			Action? onChanged = null)
		{
			if (EqualityComparer<T>.Default.Equals(backingStore, value))
				return false;

			backingStore = value;
			onChanged?.Invoke();
			OnProperyChanged(propertyName);
			return true; ;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnProperyChanged([CallerMemberName] string propertyName = "")
		{
			var changed = PropertyChanged;
			if (changed == null)
				return;

			changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
