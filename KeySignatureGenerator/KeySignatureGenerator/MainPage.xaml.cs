using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
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

        public List<string> majors = new List<string>();
        public List<string> minors = new List<string>();
        public List<string> randoms = new List<string>();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            CreateLists();
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

        public void CreateLists()
        {
            int iminor = 0;
            int imajor = 0;
            AddToList("A major", "Ab major","A minor", "A# minor","B minor", 
                "B major"," major","C major","C# major","C minor","C# minor",
                "D major","D minor", "D# minor","E minor","E major","Eb major",
                "F minor", "F# minor","F major", "F# major","G minor", "G# minor",
                "G major");

            for (int i = 0; i < randoms.Count; i++)
            {

                if (randoms[i].Contains("major"))
                {
                    majors.Add(randoms[i]);
                    Debug.WriteLine("Added " + majors[imajor] + " To majors");
                    imajor++;
                }
                else
                {
                    
                    minors.Add(randoms[i]);
                    Debug.WriteLine("Added " + minors[iminor] + " To minors");
                    iminor++;
                }
            }

        }

        public void AddToList(params string[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                randoms.Add(list[i]);
                Debug.WriteLine(randoms[i]);
            }
            
        }
    }
}
