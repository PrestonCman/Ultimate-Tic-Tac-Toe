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

using ChristmasTime.TicTacToeArchives;

namespace ChristmasTime
{
    public partial class TicTacToe : Window
    {
        private int Player = 0;
        private TicTacToeBoard[] boardssss = new TicTacToeBoard[9];
        private List<Button> buttons = new List<Button>();
        private List<Grid> boards = new List<Grid>();

        public TicTacToe()
        {
            InitializeComponent();

            boards.Add(Board1);
            boards.Add(Board2);
            boards.Add(Board3);
            boards.Add(Board4);
            boards.Add(Board5);
            boards.Add(Board6);
            boards.Add(Board7);
            boards.Add(Board8);
            boards.Add(Board9);
        }



        private void TicTacToe_Click(object sender, RoutedEventArgs e)
        {
            if (Player == 0)
                ((Button)sender).Content = "X";
            else
                ((Button)sender).Content = "O";

            Player = 1 - Player;
            ((Button)sender).IsEnabled = false;

            if(IsSingleWinner() != "")
            {
                Winner.Content = IsSingleWinner() + " is the winner!";
                Board1.IsEnabled = false;
            }
        }

        public String IsSingleWinner()
        {

            if (TopLeft.Content.Equals(TopMiddle.Content) && TopLeft.Content.Equals(TopRight.Content) && !TopLeft.Content.Equals("")) { return (String)TopLeft.Content; }
            else if (CenterLeft.Content.Equals(CenterMiddle.Content) && CenterLeft.Content.Equals(CenterRight.Content) && !CenterLeft.Content.Equals("")) { return (String)CenterLeft.Content; }
            else if (BottomLeft.Content.Equals(BottomMiddle.Content) && BottomLeft.Content.Equals(BottomRight.Content) && !BottomLeft.Content.Equals("")) { return (String)BottomLeft.Content; }

            else if (TopLeft.Content.Equals(CenterLeft.Content) && TopLeft.Content.Equals(BottomLeft.Content) && !TopLeft.Content.Equals("")) { return (String)TopLeft.Content; }
            else if (TopMiddle.Content.Equals(CenterMiddle.Content) && TopMiddle.Content.Equals(BottomMiddle.Content) && !TopMiddle.Content.Equals("")) { return (String)TopMiddle.Content; }
            else if (TopRight.Content.Equals(CenterRight.Content) && TopRight.Content.Equals(BottomRight.Content) && !TopRight.Content.Equals("")) { return (String)TopRight.Content; }

            else if (TopLeft.Content.Equals(CenterMiddle.Content) && TopLeft.Content.Equals(BottomRight.Content) && !TopLeft.Content.Equals("")) { return (String)TopLeft.Content; }
            else if (BottomLeft.Content.Equals(CenterMiddle.Content) && BottomLeft.Content.Equals(TopRight.Content) && !BottomLeft.Content.Equals("")) { return (String)BottomLeft.Content; }
            else return "";
        }

    }
}
