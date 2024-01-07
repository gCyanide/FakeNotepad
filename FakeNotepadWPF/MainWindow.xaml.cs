using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace FakeNotepadWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int LeftTwixCounter { get; set; }
        int RightTwixCounter { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Increases the LeftTwixCounter by 1. Updates the LeftTwixTB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftTwixButton_Click(object sender, RoutedEventArgs e)
        {
            LeftTwixCounter++;
            LeftTwixTB.Text = String.Format("Левая палочка Twix (выбрана {0} раз(а))", LeftTwixCounter);
        }

        /// <summary>
        /// Increases the RightTwixCounter by 1. Updates the RightTwixTB.
        /// </summary>
        /// <param name="sender">Default param (Button).</param>
        /// <param name="e"></param>
        private void RightTwixButton_Click(object sender, RoutedEventArgs e)
        {
            RightTwixCounter++;
            RightTwixTB.Text = String.Format("Правая палочка Twix (выбрана {0} раз(а))", RightTwixCounter);
        }

        /// <summary>
        /// Outputs the result in MessageBox.
        /// </summary>
        /// <param name="sender">Default param (Button).</param>
        /// <param name="e">Default param.</param>
        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            int sum = RightTwixCounter + LeftTwixCounter;
            if (sum < 10)
            {
                MessageBox.Show("Вы поучаствовали в выборе палочки Twix не более 10 раз. Решительные люди не колеблются в своих ответах. Так держать!");
            }
            else if (sum > 10 && sum < 50)
            {
                MessageBox.Show("Вы поучаствовали в выборе палочки Twix больше 10 раз. Интересно, как долго Вы колебались?");
            }
            else if (sum > 25 && sum < 50)
            {
                MessageBox.Show("Вы поучаствовали в выборе палочки Twix больше 25 раз! Круто!");
            }
            else if (sum > 50 && sum < 100)
            {
                MessageBox.Show("Вы поучаствовали в выборе палочки Twix больше 50 раз! Это так плохо, что даже хорошо!");
            }
            else if (sum > 100)
            {
                MessageBox.Show("Вы поучаствовали в выборе палочки Twix более 100 раз. У вас точно всё хорошо?");
            }
            else
            {
                // Technically, this case is possible, but nothing really leads to it.
                MessageBox.Show("???");
            }
        }
    }
}
