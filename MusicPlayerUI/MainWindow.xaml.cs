using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicPlayerUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private bool isCheckVN;
        private bool isCheckEU;
        private bool isCheckKO;

        public bool IsCheckVN { get => isCheckVN; set { isCheckVN = value; isCheckEU = false; isCheckKO = false; OnPropertyChanged("IsCheckVN"); OnPropertyChanged("IsCheckEU");
          OnPropertyChanged("IsCheckKO");
            } }

        public bool IsCheckEU { get => isCheckEU; set
            {
                isCheckEU = value; isCheckVN = false; isCheckKO = false; OnPropertyChanged("IsCheckVN"); OnPropertyChanged("IsCheckEU");
                OnPropertyChanged("IsCheckKO");
            }
        }
        public bool IsCheckKO { get => isCheckKO; set
            {
                isCheckKO = value; isCheckEU = false; isCheckVN = false; OnPropertyChanged("IsCheckVN"); OnPropertyChanged("IsCheckEU");
                OnPropertyChanged("IsCheckKO");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            UCSongInfo.BackToMain += UCSongInfo_BackToMain;
            this.DataContext = this;
            isCheckVN = true;
        }

        private void UCSongInfo_BackToMain(object sender, EventArgs e)
        {
            GridTop10.Visibility = Visibility.Visible;
            UCSongInfo.Visibility = Visibility.Hidden;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ListSongListBox.ItemsSource = new List<string>() { "", "", "", "" };
        }




        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            GridTop10.Visibility = Visibility.Hidden;
            UCSongInfo.Visibility = Visibility.Visible;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
        }
    }
}