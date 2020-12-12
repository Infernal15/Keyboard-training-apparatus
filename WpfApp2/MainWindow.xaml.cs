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
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<Key, Button> keys = new Dictionary<Key, Button>();
        private bool status = false;
        private DispatcherTimer timer = null;
        private int x = 0;
        private int count = 0;
        private int temp = 0;

        private void timerStart()
        {
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            int tmp = count - Convert.ToInt32(faills.Content);
            if(x != 0)
                temp = tmp * (60-x) / 60;
            speed.Content = temp.ToString();
            x++;
        }

        public MainWindow()
        {
            InitializeComponent();
            Caps();
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
            if(difficulty != null)
                difficulty.Content = Math.Round(((Slider)sender).Value).ToString();
            Slider();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            stop.IsEnabled = true;
            start.IsEnabled = false;
            timerStart();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            status = false;
            stop.IsEnabled = false;
            start.IsEnabled = true;
            faills.Content = "0";
            speed.Content = "0";
            Slider();
            timer.Stop();
            x = 0;
            count = 0;
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
                if (e.Key == Key.System)
                {
                    button55.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
                    button57.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
                }
                else if ((e.KeyboardDevice.Modifiers & ModifierKeys.Shift) != 0)
                {
                    Upper(1);
                }

                keys[e.Key].Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (status == true)
                {
                    if (e.Key.ToString().ToLower()[0] == check.Text[0])
                        check.Text = check.Text.Remove(0, 1);
                    else if (e.Key == Key.Space && check.Text[0] == ' ')
                        check.Text = check.Text.Remove(0, 1);
                    else if ((e.Key.ToString()[0] == check.Text[0]) && (Keyboard.IsKeyToggled(Key.CapsLock) || e.KeyboardDevice.Modifiers == ModifierKeys.Shift))
                        check.Text = check.Text.Remove(0, 1);
                    else
                        faills.Content = Convert.ToString(Convert.ToInt32(faills.Content) + 1);
                    count++;
                }
            }
            catch { }
            finally
            {
                Caps();
                if (!Keyboard.IsKeyToggled(Key.CapsLock))
                {
                    SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, 255, 64, 185));
                    button28.Background = brush;
                    if (e.KeyboardDevice.Modifiers != ModifierKeys.Shift)
                    {
                        Lower(0);
                    }
                }
                if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
                {
                    button41.Background = Brushes.Orange;
                    button52.Background = Brushes.Orange;
                }

                if (check.Text.Length == 0)
                {
                    MessageBox.Show($"Congratulations, your result - {temp}", "Congratulations!!!");
                    stop_Click(sender, e);
                }
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.LeftShift || e.Key == Key.RightShift))
            {
                if (Keyboard.IsKeyToggled(Key.CapsLock))
                {
                    Lower(1);
                    Upper(0);
                }
                else
                    Lower(1);

                SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, 255, 64, 185));
                button41.Background = brush;
                button52.Background = brush;
            }
        }

        private void Caps()
        {
            if (Keyboard.IsKeyToggled(Key.CapsLock))
            {
                button28.Background = Brushes.Orange;
                Upper(0);
            }
        }

        private void Upper(int chars)
        {
            button14.Content = "Q";
            button15.Content = "W";
            button16.Content = "E";
            button17.Content = "R";
            button18.Content = "T";
            button19.Content = "Y";
            button20.Content = "U";
            button21.Content = "I";
            button22.Content = "O";
            button23.Content = "P";
            button29.Content = "A";
            button30.Content = "S";
            button31.Content = "D";
            button32.Content = "F";
            button33.Content = "G";
            button34.Content = "H";
            button35.Content = "J";
            button36.Content = "K";
            button37.Content = "L";
            button42.Content = "Z";
            button43.Content = "X";
            button44.Content = "C";
            button45.Content = "V";
            button46.Content = "B";
            button47.Content = "N";
            button48.Content = "M";

            if(chars == 1)
            {
                button.Content = "~";
                button1.Content = "!";
                button2.Content = "@";
                button3.Content = "#";
                button4.Content = "$";
                button5.Content = "%";
                button6.Content = "^";
                button7.Content = "&";
                button8.Content = "*";
                button9.Content = "(";
                button10.Content = ")";
                button11.Content = "_";
                button12.Content = "+";
                button24.Content = "{";
                button25.Content = "}";
                button26.Content = "|";
                button38.Content = ":";
                button39.Content = "\"";
                button49.Content = "<";
                button50.Content = ">";
                button51.Content = "?";
            }
        }

        private void Lower(int chars)
        {
            button14.Content = "q";
            button15.Content = "w";
            button16.Content = "e";
            button17.Content = "r";
            button18.Content = "t";
            button19.Content = "y";
            button20.Content = "u";
            button21.Content = "i";
            button22.Content = "o";
            button23.Content = "p";
            button29.Content = "a";
            button30.Content = "s";
            button31.Content = "d";
            button32.Content = "f";
            button33.Content = "g";
            button34.Content = "h";
            button35.Content = "j";
            button36.Content = "k";
            button37.Content = "l";
            button42.Content = "z";
            button43.Content = "x";
            button44.Content = "c";
            button45.Content = "v";
            button46.Content = "b";
            button47.Content = "n";
            button48.Content = "m";

            if(chars == 1)
            {
                button.Content = "`";
                button1.Content = "1";
                button2.Content = "2";
                button3.Content = "3";
                button4.Content = "4";
                button5.Content = "5";
                button6.Content = "6";
                button7.Content = "7";
                button8.Content = "8";
                button9.Content = "9";
                button10.Content = "0";
                button11.Content = "-";
                button12.Content = "=";
                button24.Content = "[";
                button25.Content = "]";
                button26.Content = "\\";
                button38.Content = ";";
                button39.Content = "'";
                button49.Content = ",";
                button50.Content = ".";
                button51.Content = "/";
            }
        }

        private void Slider()
        {
            if (difficulty != null)
            {
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
    }
}
