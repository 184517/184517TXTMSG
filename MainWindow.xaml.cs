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

namespace _184517TXTMSG
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

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            string textentered = txtInput.Text;

           

            textentered = txtInput.Text.ToUpper();

            textentered = textentered.Replace
                ("LOL", "Laughing out loud" + Environment.NewLine);
            textentered = textentered.Replace
                (":-)", "I'm happy" + Environment.NewLine);
            textentered = textentered.Replace
                (":-(", "I'm unhappy" + Environment.NewLine);
            textentered = textentered.Replace
                (";-)", "Wink" + Environment.NewLine);
            textentered = textentered.Replace
                (":-p", "Stick out my tongue" + Environment.NewLine);
            textentered = textentered.Replace
                ("(~.~)", "Sleepy" + Environment.NewLine);
            textentered = textentered.Replace
                ("TA", "Totally Awesome" + Environment.NewLine);
            textentered = textentered.Replace
                ("CCC", "Canadian Computing Competition" + Environment.NewLine);
            textentered = textentered.Replace
                ("CUZ", "Because" + Environment.NewLine);
            textentered = textentered.Replace
                ("YW", "You're Welcome" + Environment.NewLine);
            textentered = textentered.Replace
                ("TTYL", "Talk to you later" + Environment.NewLine);
            textentered = textentered.Replace
                ("CU", "See you" + Environment.NewLine);
            textentered = textentered.Replace
                ("TY", "Thank-you" + Environment.NewLine);
            textentered = textentered.Replace
                ("Laughing out loud", "LOL"  + Environment.NewLine);


            lblOutput.Content = "" + textentered;
            if (txtInput.Text.Contains("TTYL"))
            {
                Environment.Exit(0);
            }
        
            
        }
        
    
        
    }
}
