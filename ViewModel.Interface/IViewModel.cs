





using System.ComponentModel;

namespace ViewModel.Interface
{
    public interface IViewModel : INotifyPropertyChanged
    {
        string OutputMessage { get; set; }
        void Load();
        void Refresh();
    }
}
