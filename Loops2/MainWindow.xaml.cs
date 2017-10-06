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

namespace Loops2
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

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            /*  int Score = int.Parse(tbxScore.Text);

              if (Score == 100 )
              {
                  MessageBox.Show("Well Done");
              }
              else
              {
                  MessageBox.Show("Hard Luck");
              }
              */
            // MessageBox.Show("Result: " + Score);
           /* try
            {
                string Score = tbxScore.Text.Trim();
                if (Score == "100")
                {
                    MessageBox.Show("Well Done");
                }
                else
                {
                    MessageBox.Show("Hard Luck");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Promblem With textbox");
            }*/

//check score through single if statements 
           /* try
            {
               int Score = Convert.ToInt16(tbxScore.Text);
                if (Score == 100)
                {
                    MessageBox.Show("Perfct Score");
                }
                if (Score >= 90 && Score <= 100)
                {
                    MessageBox.Show("You got an A");
                }
                if (Score >= 80 && Score < 90)
                {
                    MessageBox.Show("You got a B");
                }
                if (Score >= 70 && Score < 80)
                {
                    MessageBox.Show("You got a C");
                }
                if (Score >= 60 && Score < 70)
                {
                    MessageBox.Show("You got a D");
                }
                if (Score < 60)
                {
                    MessageBox.Show("You got an F");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Promblem With textbox");
            }*/

//checks through scores with else if 
            try
            {
                int Score = Convert.ToInt16(tbxScore.Text);
                if (Score == 100)
                {
                    MessageBox.Show("Perfct Score");
                }
                else if (Score >= 90)
                {
                    MessageBox.Show("You got an A");
                }
                else if (Score >= 80)
                {
                    MessageBox.Show("You got a B");
                }
                else if (Score >= 70)
                {
                    MessageBox.Show("You got a C");
                }
                else if (Score >= 60)
                {
                    MessageBox.Show("You got a D");
                }
                else if (Score < 60)
                {
                    MessageBox.Show("You got an F");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Promblem With textbox");
            }
        }
    }
}
