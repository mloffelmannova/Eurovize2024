using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace Eurovize2024
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

        private void btnAiko_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.SoundLocation = "hudba/Aiko - Pedestal.wav";
            prehravac.Play();

        }

        private void btnAiko1_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.SoundLocation = "hudba/Out of My Mind.wav";
            prehravac.Play();
        }

        private void btnAiko2_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.SoundLocation = "hudba/Tom Sean - Dopamine.wav";
            prehravac.Play();
        }

        private void btnAiko3_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.SoundLocation = "hudba/MYDY - Red Flag Parade.wav";
            prehravac.Play();
        }

        private void btnAiko4_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.SoundLocation = "hudba/Good Enough.wav";
            prehravac.Play();
        }

        private void btnAiko5_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.SoundLocation = "hudba/Gianna Lei - Starlet.wav";
            prehravac.Play();
        }

        private void btnAiko6_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.SoundLocation = "hudba/Elly - The Angels Share.wav";
            prehravac.Play();
        }





        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.Stop();
        }

        private void btnStop1_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.Stop();
        }

        private void btnStop2_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.Stop();
        }

        private void btnStop3_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.Stop();
        }

        private void btnStop4_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.Stop();
        }

        private void btnStop5_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.Stop();
        }

        private void btnStop6_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer prehravac = new SoundPlayer();
            prehravac.Stop();
        }
    }
}
