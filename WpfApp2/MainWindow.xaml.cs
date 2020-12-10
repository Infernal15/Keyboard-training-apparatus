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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            check.Text = "jkkjk kjkkj jkjjk kkjkj jjkjk jkjkk kjkjj jkjkj kkjkj jjkjk";
        }

        private void Grid_TextInput(object sender, TextCompositionEventArgs e)
        {

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
    }
}
