using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           
        }

        private void boton_Click(object sender, RoutedEventArgs e)
        {
            if (pesoBruto.Text.Trim() == "" || pesoTara.Text.Trim() == "" || cantProducto.Text.Trim() == "")
            {
                cuadroResultado.Content = "Debe completar todos los campos";
            }
            else {
                float pesoTotal = float.Parse(pesoBruto.Text);
                float pesoRecipiente = float.Parse(pesoTara.Text);
                float pesoProducto = float.Parse(cantProducto.Text);

                float peso = pesoTotal - pesoRecipiente;
                float resultado = (peso / pesoProducto)*100;

                cuadroResultado.Content = $"{resultado.ToString("0.000")} mg. ";

                pesoBruto.Text = "";
                pesoTara.Text = "";
                cantProducto.Text = "";
            }

        }
    }
}
