using System;
using System.ComponentModel;
using System.Windows.Forms;
using ViewModel.Interface;

namespace DIWinFormsView
{
    public partial class WinFormsView : Form
    {
 

        private IViewModel _viewModel;

        public WinFormsView(IViewModel vm)
        {
            _viewModel = vm;
            InitializeComponent();
            SetupBindings();
        }

        private void SetupBindings()
        {
            var textBoxBindingSource = new BindingSource
            {
                DataSource = _viewModel
            };            
            textBoxOutput.DataBindings.Add("Text", textBoxBindingSource, "OutputMessage", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                _viewModel.Load();
            }catch{
                //do sth
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                _viewModel.Refresh();
            }catch{
                //dp sth
            }
        }
    }
}
