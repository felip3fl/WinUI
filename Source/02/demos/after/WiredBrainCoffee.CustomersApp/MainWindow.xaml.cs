using Microsoft.UI.Xaml;

namespace WiredBrainCoffee.CustomersApp
{
  public sealed partial class MainWindow : Window
  {
    public MainWindow()
    {
      this.InitializeComponent();
    }

    private void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
    {
      btnAddCustomer.Content = "Customer added!";
    }
  }
}
