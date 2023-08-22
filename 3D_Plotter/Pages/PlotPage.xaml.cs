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
using System.Windows.Threading;

namespace _3D_Plotter.Pages
{
    /// <summary>
    /// Interaktionslogik für PlotPage.xaml
    /// </summary>
    public partial class PlotPage : Page
    {
        private DispatcherTimer timer;
        private int counter = 0;
        public PlotPage()
        {
            InitializeComponent();
            PlotPageTB.Text += "\n"+GlobaleVariablen.n.ToString();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1); // Aktualisierung alle 1 Sekunde
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            UpdatePage();
        }
        void UpdatePage()
        {
            PlotPageTB.Text += "\n" + GlobaleVariablen.n.ToString();
        }

    }
}
