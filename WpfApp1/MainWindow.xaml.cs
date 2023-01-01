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
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            
        }

       

       

        private void Button_Click()
        {
            string value = new DataTable().Compute(s.Text, null).ToString();
            s.Text = value;
        }

        private void key(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Q)
            {
                Q.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.W)
            {
                W.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.E)
            {
                E.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.R)
            {
                R.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.T)
            {
                T.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.Y)
            {
                Y.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.U)
            {
                U.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.I)
            {
                I.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.O)
            {
                O.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.P)
            {
                P.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.A)
            {
                A.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.S)
            {
                S.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.D)
            {
                D.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.F)
            {
                F.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.G)
            {
                G.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.H)
            {
                H.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.J)
            {
                J.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.K)
            {
                K.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.L)
            {
                L.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.Z)
            {
                Z.Background = new SolidColorBrush(Colors.Red);
            }


            else if (e.Key == Key.X)
            {
                X.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.C)
            {
                C.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.V)
            {
                V.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.B)
            {
                B.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.N)
            {
                N.Background = new SolidColorBrush(Colors.Red);
            }
            else if (e.Key == Key.M)
            {
                M.Background = new SolidColorBrush(Colors.Red);
            }



        }

        private void Grid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Q || e.Key == Key.W || e.Key == Key.E || e.Key == Key.R
                || e.Key == Key.T || e.Key == Key.Y || e.Key == Key.U || e.Key == Key.I || e.Key == Key.O
                || e.Key == Key.P || e.Key == Key.A || e.Key == Key.S || e.Key == Key.D || e.Key == Key.F
                || e.Key == Key.G || e.Key == Key.H || e.Key == Key.J || e.Key == Key.K || e.Key == Key.L
                || e.Key == Key.Z || e.Key == Key.X || e.Key == Key.C || e.Key == Key.V || e.Key == Key.B
                || e.Key == Key.N || e.Key == Key.M) 
            {
                
                Q.Background = new SolidColorBrush(Colors.Gray);
                W.Background = new SolidColorBrush(Colors.Gray);
                E.Background = new SolidColorBrush(Colors.Gray);
                R.Background = new SolidColorBrush(Colors.Gray);
                T.Background = new SolidColorBrush(Colors.Gray);
                Y.Background = new SolidColorBrush(Colors.Gray);
                U.Background = new SolidColorBrush(Colors.Gray);
                I.Background = new SolidColorBrush(Colors.Gray);
                O.Background = new SolidColorBrush(Colors.Gray);
                P.Background = new SolidColorBrush(Colors.Gray);
                A.Background = new SolidColorBrush(Colors.Gray);
                S.Background = new SolidColorBrush(Colors.Gray);
                D.Background = new SolidColorBrush(Colors.Gray);
                F.Background = new SolidColorBrush(Colors.Gray);
                G.Background = new SolidColorBrush(Colors.Gray);
                H.Background = new SolidColorBrush(Colors.Gray);
                J.Background = new SolidColorBrush(Colors.Gray);
                K.Background = new SolidColorBrush(Colors.Gray);
                L.Background = new SolidColorBrush(Colors.Gray);
                Z.Background = new SolidColorBrush(Colors.Gray);
                X.Background = new SolidColorBrush(Colors.Gray);
                C.Background = new SolidColorBrush(Colors.Gray);
                V.Background = new SolidColorBrush(Colors.Gray);
                B.Background = new SolidColorBrush(Colors.Gray);
                N.Background = new SolidColorBrush(Colors.Gray);
                M.Background = new SolidColorBrush(Colors.Gray);
               

            }
        }
    }
}
