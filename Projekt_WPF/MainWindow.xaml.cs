using Projekt;
using Projekt_WPF.Jezici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Projekt_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string HR = "hr", EN = "en";
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            btnJezik.Content = HR;
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window1 odabir_Nacije = new Window1();
            this.Visibility = Visibility.Hidden;
            odabir_Nacije.Show();
        }
        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Odabir_nacije_Women odabir_Nacije_Women = new Odabir_nacije_Women();
            this.Visibility = Visibility.Hidden;
            odabir_Nacije_Women.Show();
        }
        private void PostaviKulturu(string kultura)
        {
            try
            {
                //postavi lokalizaciju = prevodi
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(kultura);
                //postavi globalizaciju = datum,vrijeme,valute
                Thread.CurrentThread.CurrentCulture = new CultureInfo(kultura);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                PostaviKulturu(EN);
                btnJezik.Content = "EN";
            }
            else
            {
                PostaviKulturu(HR);
                btnJezik.Content = "HR";
            }
            ZapisiKulturu();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var rb = sender as RadioButton;
            System.IO.File.WriteAllText(@"../../../../OdabranaRezolucija.txt", rb.Content.ToString());
        }
        private void ZapisiKulturu()
        {
            System.IO.File.WriteAllText(@"..\..\..\..\OdabranaKultura.txt", btnJezik.Content.ToString().ToLower());
        }
    }
}
