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
        // boolean checks for radio buttons
        public bool random = false;
        public bool major = false;
        public bool minor = false;

        //the master key, final result of the generation
        public int key;

        //lists for each type of key signature
        public List<string> majors = new List<string>();
        public List<string> minors = new List<string>();
        public List<string> randoms = new List<string>();

        //instance of random
        Random rand = new Random();

        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Method for when the generate button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            //Clear all lists so there is no duplicate data
            ClearLists();
            //then generate the lists
            CreateLists();

            //if the random radio button is selected
            if(random)
            {
                //picks a random number from the length of the lsit
                key = rand.Next(randoms.Count);
                //picks that key then send it to the text block
                tbkresults.Text = randoms[key];
            }

            //if the minor radio button is selected
            if (minor)
            {
                //same process as for randoms
                key = rand.Next(minors.Count);
                tbkresults.Text = minors[key];
            }

            //if the major radio button is selected
            if (major)
            {
                key = rand.Next(majors.Count);
                tbkresults.Text = majors[key];
            }
            
        }

        /// <summary>
        /// Clears all lists
        /// </summary>
        private void ClearLists()
        {
            //list get cleared
            randoms.Clear();
            majors.Clear();
            minors.Clear();
        }

        //boolean changed
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

        //Generates the lists
        public void CreateLists()
        {
            //ints for debugging later
            int iminor = 0;
            int imajor = 0;

            //this mthod will create the randoms list
            AddToList("A major", "Ab major","A minor", "A# minor","B minor", 
                "B major"," Bb major","C major","C# major","C minor","C# minor",
                "D major","D minor", "D# minor","E minor","E major","Eb major",
                "F minor", "F# minor","F major", "F# major","G minor", "G# minor",
                "G major");

            //for loop
            for (int i = 0; i < randoms.Count; i++)
            {
                //if the current item contains the string "major"
                if (randoms[i].Contains("major"))
                {
                    //add it to the majors list
                    majors.Add(randoms[i]);
                    //outputs what was just added ot the majors list
                    Debug.WriteLine("Added " + majors[imajor] + " To majors");
                    //increment the imajors int
                    imajor++;
                }
                //if not major it must be minor
                else
                {
                    //adds the current item to the minors list
                    minors.Add(randoms[i]);
                    //outputs the added item to the console
                    Debug.WriteLine("Added " + minors[iminor] + " To minors");
                    //increment the iminor int
                    iminor++;
                }
            }

        }

        /// <summary>
        /// Generates the randoms list
        /// </summary> 
        /// <param name="list">Items to be added to the randoms list</param>
        public void AddToList(params string[] list)
        {
            //for loop
            for(int i = 0; i < list.Length; i++)
            {
                //adds the current item in the list list to randoms
                randoms.Add(list[i]);

                //outputs what was just added to the list
                Debug.WriteLine(randoms[i]);
            }
            
        }
    }
}
