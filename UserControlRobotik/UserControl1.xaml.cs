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

namespace UserControlRobotik
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        

        public string? UC_Description
        {
            get { return groupBox?.Header?.ToString(); }
            set { groupBox.Header = value; }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            slider.Value = 100;
            backSpdPrgBard.Value = 0;
            spdPrgBard.Value = 100;
            pctLabel.Content = "100%";
        }

        private void stopBtn_Click(object sender, RoutedEventArgs e)
        {
            slider.Value = 0;
            spdPrgBard.Value = 0;
            backSpdPrgBard.Value = 0;
            pctLabel.Content = "0%";
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            slider.Value = -100;
            backSpdPrgBard.Value = 100;
            spdPrgBard.Value = 0;
            pctLabel.Content = "-100%";
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(slider.Value > 0)
            {
                backSpdPrgBard.Value = 0;
                spdPrgBard.Value = slider.Value;
                pctLabel.Content = slider.Value.ToString() + "%";
            }
            else
            {
                backSpdPrgBard.Value = slider.Value * -1;
                spdPrgBard.Value = 0;
                pctLabel.Content = slider.Value.ToString() + "%";
            }
        }
    }
}