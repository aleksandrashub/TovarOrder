using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Tovar
{
    public partial class MainWindow : Window
    {

        public const string codeAdm="0", codeUser="1";
        public MainWindow()
        {
            InitializeComponent();
        }

        public void BtnVhod_OnClick(object? sender, RoutedEventArgs e)
        {
           
            switch (CodeInput.Text)
            {
                case codeUser:
                    Order order = new Order();
                    order.Show();
                    this.Close();
                    break;
                case codeAdm:
                    ProductEdit productEdit = new ProductEdit();    
                    productEdit.Show();
                    this.Close();
                    break;
                   
            }
        }
    }
}