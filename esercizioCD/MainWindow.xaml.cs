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

namespace esercizioCD
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<CD> _listaCD;
        public MainWindow()
        {
            InitializeComponent();
            _listaCD = new List<CD>();

        }

        private void btn_aggiungiCD_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string titolo = txt_titolo.Text;
                string autore = txt_autore.Text;
                _listaCD.Add(new CD(titolo, autore));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_aggiungiBrano_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string titolo = txt_titolo.Text;
                string autore = txt_autore.Text;
                int durata = int.Parse(txt_durata.Text);
                if (lst_cd.SelectedItem == null)
                {
                    throw new Exception("Prima devi selezionare un cd");
                }
                (lst_cd.SelectedItem as CD).Brani.Add(new Brano(titolo, autore, durata));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lst_cd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (lst_cd.SelectedItem != null)
                {
                    lb_brani.Content = (lst_cd.SelectedItem as CD).ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
