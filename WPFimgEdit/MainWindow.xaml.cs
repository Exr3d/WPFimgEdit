using Microsoft.Win32;
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

namespace WPFimgEdit
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

        private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                imgDynamic.Source = new BitmapImage(fileUri);
                imgDynamic.Stretch = Stretch.None;
            }
        }

        private void StretchChange(object sender, RoutedEventArgs e)
        {
            if (FillCh.IsChecked==true)
            {
                imgDynamic.Stretch = Stretch.Fill;

            }
            else if (UniformCh.IsChecked == true)
            {
                imgDynamic.Stretch = Stretch.Uniform;

            }
            else if (UniformToFillCh.IsChecked == true)
            {
                imgDynamic.Stretch = Stretch.UniformToFill;

            }
            else if (NoneCh.IsChecked == true)
            {
                imgDynamic.Stretch = Stretch.None;
                
            }
        }

        private void FillChecked(object sender, RoutedEventArgs e)
        {

        }

        private void dostaje(object sender, RoutedEventArgs e)
        {
            imgWidth.Text = "";
        }

        private void lost(object sender, RoutedEventArgs e)
        {
            if (imgWidth.Text == "")
            {
            imgWidth.Text = "Wpisz szerokosc";
            }
            else
            {
                imgWidth.Text = imgWidth.Text;
            }
            
        }

        private void lostH(object sender, RoutedEventArgs e)
        {
            if (imgHeight.Text == "")
            {
                imgHeight.Text = "Wpisz szerokosc";
            }
            else
            {
                imgHeight.Text = imgHeight.Text;
            }
        }

        private void dostajeH(object sender, RoutedEventArgs e)
        {
            imgHeight.Text = "";
        }

        

        private void setWHclick(object sender, RoutedEventArgs e)
        {
            int wys = int.Parse(imgHeight.Text);
            int sze = int.Parse(imgWidth.Text);

            imgDynamic.Width = sze;
            imgDynamic.Height = wys;
            

        }

       

        private void jotde(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double test = slider.Value;
            if (imgDynamic != null)
            {
                imgDynamic.Opacity = test;
            }

        }
    }
}
