using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KeySignatureGenerator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public bool random = false;
        public bool major = false;
        public bool minor = false;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            if(random)
            {

            }
            if (minor)
            {

            }
            if (major)
            {

            }
            else
            {

            }
        }

        private void rbMinor_Checked(object sender, RoutedEventArgs e)
        {
            random = false;
            major = false;
            minor = true;
        }

        private void rbRandom_Checked(object sender, RoutedEventArgs e)
        {
            random = true;
            major = false;
            minor = false;
        }

        private void rbMajor_Checked(object sender, RoutedEventArgs e)
        {
            random = false;
            major = true;
            minor = false;
        }
    }
}
