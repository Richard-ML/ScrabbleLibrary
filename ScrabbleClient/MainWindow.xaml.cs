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
using ScrabbleLibrary;

namespace ScrabbleClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bag bag = new Bag();
        public MainWindow()
        {
            InitializeComponent();

            //Populate default current player options
            cbCurPlayer.Items.Add(1);
            cbCurPlayer.Items.Add(2);

            cbCurPlayer.SelectedIndex = 0;

            //Populate options for the number of players
            cbNumPlayers.Items.Add(2);
            cbNumPlayers.Items.Add(3);
            cbNumPlayers.Items.Add(4);

            cbNumPlayers.SelectedIndex = 0;
            bag.TopUp();
            tbRack.Text = bag.ToString();
            //bag.rack = new string[bag.numPlayers];
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you wish to exit?", "Confirmation", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();//Use confirmed that they wish to exit the application. Grant their wish by exiting the application.
            }
        }

        private void cbNumPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bag.numPlayers = (int)cbNumPlayers.SelectedValue;
           // bag.NewRack();

            bool done = false;
            while (!done)
                if (cbCurPlayer.Items.Count < (int)cbNumPlayers.SelectedValue)
                {
                    cbCurPlayer.Items.Add((int) 1+ cbCurPlayer.Items.Count);//magic
                }
            else if(cbCurPlayer.Items.Count > (int)cbNumPlayers.SelectedValue)
                {
                    cbCurPlayer.Items.RemoveAt(-1 + cbCurPlayer.Items.Count);
                }
                else
                {
                    done = true;
                }
            
        }

        private void cbCurPlayer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bag.currPlayer = (int)cbCurPlayer.SelectedValue;

            bag.TopUp();
            
            tbRack.Text = bag.ToString();
        }
    }
}
