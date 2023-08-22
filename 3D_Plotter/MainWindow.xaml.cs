using _3D_Plotter.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

namespace _3D_Plotter
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StartPage startPage;
        private PlotPage plotPage;
        private SettingsPage settingsPage;
        SolidColorBrush LightGreen = new SolidColorBrush(Colors.LightGreen);
        SolidColorBrush Gray = new SolidColorBrush(Colors.Gray);
        public MainWindow()
        {
            InitializeComponent();
            /*Seiten initialisieren*/
            startPage = new StartPage();
            plotPage = new PlotPage();
            settingsPage = new SettingsPage();

            /*Click routine*/
            Start.Click += new RoutedEventHandler(this.BtnStart_Click);
            Plot.Click += new RoutedEventHandler(this.BtnPlot_Click);
            Settings.Click += new RoutedEventHandler(this.BtnSettings_Click);

        }

        private void BtnStart_Click(Object sender, EventArgs e)
        {
            MainFrame.Content = startPage;
            Task StartPlot = new Task(() => 
            {
                GlobaleVariablen.n = Plotter.Fakul(5);
                GlobaleVariablen.rdy = true;
                Dispatcher.Invoke(() =>
                {
                    Test.Text += GlobaleVariablen.n.ToString();
                });
            });
            StartPlot.Start();
        }
        private void BtnPlot_Click(Object sender, EventArgs e)
        {
            MainFrame.Content = plotPage;
        }
        private void BtnSettings_Click(Object sender, EventArgs e)
        {
            MainFrame.Content = settingsPage;
        }
    }
}
