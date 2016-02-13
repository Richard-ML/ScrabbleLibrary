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

namespace ScrabbleClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Populate options for the number of players
            cbNumPlayers.Items.Add(2);
            cbNumPlayers.Items.Add(3);
            cbNumPlayers.Items.Add(4);

            //Populate default current player options
            cbCurPlayer.Items.Add(1);
            cbCurPlayer.Items.Add(2);
        }
    }
}
