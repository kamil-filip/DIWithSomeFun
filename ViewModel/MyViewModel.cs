using Repository.Interface;
using System;
using System.ComponentModel;
using ViewModel.Interface;

namespace ViewModel
{
    public class MyViewModel : IViewModel
    {
        private IRepository _repository;

        public event PropertyChangedEventHandler PropertyChanged;





        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }



        public MyViewModel(IRepository repository)
        {
            _repository = repository;
        }

        private string _outMsg;


        public string OutputMessage
        { get { return _outMsg; }
          set
            {
                _outMsg = value;
                OnPropertyChanged("OutputMessage");
            }
        }

        public void Load()
        {
            OutputMessage = _repository.Get();
        }

        public void Refresh()
        {
            OutputMessage = "";
        }
    }
}
