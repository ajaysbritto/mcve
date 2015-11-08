using System.Windows;

namespace WCF_Dictionary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            var c = client.GetData(0);

            //How do i get the dictionary object here?
            //foreach(var t in c.StringValue)
            //    listBox.Items.Add("");
        }
    }
}
