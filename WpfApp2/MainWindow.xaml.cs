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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<Key, Button> keys = new Dictionary<Key, Button>();
        public MainWindow()
        {
            InitializeComponent();
            if (Keyboard.IsKeyToggled(Key.CapsLock))
                button28.Background = Brushes.Orange;
            check.Text = "jkkjk kjkkj jkjjk kkjkj jjkjk jkjkk kjkjj jkjkj kkjkj jjkjk";
            keys[Key.OemTilde] = button;
            keys[Key.D1] = button1;
            keys[Key.D2] = button2;
            keys[Key.D3] = button3;
            keys[Key.D4] = button4;
            keys[Key.D5] = button5;
            keys[Key.D6] = button6;
            keys[Key.D7] = button7;
            keys[Key.D8] = button8;
            keys[Key.D9] = button9;
            keys[Key.D0] = button10;
            keys[Key.OemMinus] = button11;
            keys[Key.OemPlus] = button12;
            keys[Key.D0] = button13;
            keys[Key.Q] = button14;
            keys[Key.W] = button15;
            keys[Key.E] = button16;
            keys[Key.R] = button17;
            keys[Key.T] = button18;
            keys[Key.Y] = button19;
            keys[Key.U] = button20;
            keys[Key.I] = button21;
            keys[Key.O] = button22;
            keys[Key.P] = button23;
            keys[Key.Oem4] = button24;
            keys[Key.Oem6] = button25;
            keys[Key.Oem5] = button26;
            keys[Key.Tab] = button27;
            keys[Key.CapsLock] = button28;
            keys[Key.A] = button29;
            keys[Key.S] = button30;
            keys[Key.D] = button31;
            keys[Key.F] = button32;
            keys[Key.G] = button33;
            keys[Key.H] = button34;
            keys[Key.J] = button35;
            keys[Key.K] = button36;
            keys[Key.L] = button37;
            keys[Key.OemSemicolon] = button38;
            keys[Key.OemQuotes] = button39;
            keys[Key.Enter] = button40;
            keys[Key.LeftShift] = button41;
            keys[Key.Z] = button42;
            keys[Key.X] = button43;
            keys[Key.C] = button44;
            keys[Key.V] = button45;
            keys[Key.B] = button46;
            keys[Key.N] = button47;
            keys[Key.M] = button48;
            keys[Key.OemComma] = button49;
            keys[Key.OemPeriod] = button50;
            keys[Key.Oem2] = button51;
            keys[Key.RightShift] = button52;
            keys[Key.LeftCtrl] = button53;
            keys[Key.LWin] = button54;
            keys[Key.Space] = button56;
            keys[Key.RWin] = button58;
            keys[Key.RightCtrl] = button59;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            if (difficulty != null)
            {
                difficulty.Content = Math.Round(((Slider)sender).Value).ToString();
                int tmp = Convert.ToInt32(difficulty.Content);
                switch (tmp)
                {
                    case 1:
                        check.Text = "jkkjk kjkkj jkjjk kkjkj jjkjk jkjkk kjkjj jkjkj kkjkj jjkjk";
                        break;

                    case 2:
                        check.Text = "dffdf fdffd dfddf ffdfd ddfdf dfdff fdfdd dfdfd ffdfd ddfdf";
                        break;

                    case 3:
                        check.Text = "dkfdj jdfkf kjdkf fkjdk fkdkj fkfdj kjdkf dfkfj kfkdj fjkjd";
                        break;

                    case 4:
                        check.Text = "djk kjd dfk kfdf jdfk jkjdj";
                        break;

                    case 5:
                        check.Text = "l;;l; ;l;;l l;ll; ;;l;l ll;l; l;l;; ;l;ll l;l;l ;;l;l ll;l;";
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
                        break;

                    case 10:
                        break;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            ColorAnimation animation;
            animation = new ColorAnimation();
            animation.From = Colors.Orange;
            animation.To = Color.FromArgb(255, 255, 64, 185);
            animation.Duration = new Duration(TimeSpan.FromSeconds(1));
            try
            {
                if(e.Key == Key.System)
                {
                    button55.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
                    button57.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
                }
                else
                    keys[e.Key].Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            catch { }
            finally
            {
                if (Keyboard.IsKeyToggled(Key.CapsLock))
                    button28.Background = Brushes.Orange;
                else if (!Keyboard.IsKeyToggled(Key.CapsLock))
                {
                    SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, 255, 64, 185));
                    button28.Background = brush;
                }
            }
        }
    }
}
