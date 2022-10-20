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

namespace jogo_pedra_papel_tesoura
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        int contadorVitoriasComputador = 0;
        int contadorSuasVitorias = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void ClickPedra(object sender, RoutedEventArgs e)
        {
            imgPedra.Visibility = Visibility.Visible;
            imgPapel.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Hidden;
            JogadaComputador();
            Vitoria();
            Empate();
        }

        private void ClickPapel(object sender, RoutedEventArgs e)
        {
            imgPapel.Visibility = Visibility.Visible;
            imgPedra.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Hidden;
            JogadaComputador();
            Vitoria();
            Empate();
        }

        private void ClickTesoura(object sender, RoutedEventArgs e)
        {
            imgTesoura.Visibility = Visibility.Visible;
            imgPedra.Visibility = Visibility.Hidden;
            imgPapel.Visibility = Visibility.Hidden;
            JogadaComputador();
            Vitoria();
            Empate();
        }

        private void JogadaComputador()
        {
            Random random = new Random();
            int opcao = random.Next(1, 4);
            switch(opcao)
            {
                case 1:
                    imgPedra1.Visibility = Visibility.Visible;
                    imgPapel1.Visibility = Visibility.Hidden;
                    imgTesoura1.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    imgPedra1.Visibility = Visibility.Hidden;
                    imgPapel1.Visibility = Visibility.Visible;
                    imgTesoura1.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    imgPedra1.Visibility = Visibility.Hidden;
                    imgPapel1.Visibility = Visibility.Hidden;
                    imgTesoura1.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void Vitoria()
        {
            if(imgPapel.Visibility == Visibility.Visible && imgPedra1.Visibility == Visibility.Visible)
            {
                contadorSuasVitorias++;
                txtVencedor.Text = "Você venceu!!!";
                txtSuasVitorias.Text = contadorSuasVitorias.ToString();
            }

            else if (imgPedra.Visibility == Visibility.Visible && imgTesoura1.Visibility == Visibility.Visible)
            {
                contadorSuasVitorias++;
                txtVencedor.Text = "Você venceu!!!";
                txtSuasVitorias.Text = contadorSuasVitorias.ToString();
            }

            else if (imgTesoura.Visibility == Visibility.Visible && imgPapel1.Visibility == Visibility.Visible)
            {
                contadorSuasVitorias++;
                txtVencedor.Text = "Você venceu!!!";
                txtSuasVitorias.Text = contadorSuasVitorias.ToString();
            }

            else if (imgPapel1.Visibility == Visibility.Visible && imgPedra.Visibility == Visibility.Visible)
            {
                contadorVitoriasComputador++;
                txtVencedor.Text = "O Computador venceu!!!";
                txtVitoriaComputador.Text = contadorVitoriasComputador.ToString();
            }

            else if (imgPedra1.Visibility == Visibility.Visible && imgTesoura.Visibility == Visibility.Visible)
            {
                contadorVitoriasComputador++;
                txtVencedor.Text = "O Computador venceu!!!";
                txtVitoriaComputador.Text = contadorVitoriasComputador.ToString();
            }

            else if (imgTesoura1.Visibility == Visibility.Visible && imgPapel.Visibility == Visibility.Visible)
            {
                contadorVitoriasComputador++;
                txtVencedor.Text = "O Computador venceu!!!";
                txtVitoriaComputador.Text = contadorVitoriasComputador.ToString();
            }
        }

        private void Empate()
        {
            if (imgPapel.Visibility == Visibility.Visible && imgPapel1.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Houve um empate!";
            }

            else if (imgPedra.Visibility == Visibility.Visible && imgPedra1.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Houve um empate!";
            }

            else if (imgTesoura.Visibility == Visibility.Visible && imgTesoura1.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Houve um empate!";
            }
        }
    }
}
