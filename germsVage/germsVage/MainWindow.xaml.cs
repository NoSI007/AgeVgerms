// (c) Khaled A Alwan .
// All other rights reserved.
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace germsVage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Construct an instance of gVa and use it in this class ctor.
        /// <see cref="gVa"/>
        /// </summary>
        gVa lst = new gVa();
        ObservableCollection<KeyValuePair<double, double>> plot { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //
            //lst.stepByage(36,1, 200);

            ComputList();
        }

        private void ComputList()
        {
            double StartEnd;
            double inc;
            double upperLim;

            bool ret = double.TryParse(z_from.Text, out StartEnd);
            if (ret == false)
                return;
            ret = double.TryParse(z_inc.Text, out inc);
            if (ret == false)
                return;
            ret = double.TryParse(z_to.Text, out upperLim);
            if (ret == false)
                return;

            lst.stepByage(StartEnd, inc, upperLim);// Populate the list

            pg.DataContext = lst;     // Set data context
            showChart();
        }

        private void showChart()
        {
            if (plot == null)
                plot = new ObservableCollection<KeyValuePair<double, double>>();
            else
                plot.Clear();

            foreach(var x in lst.LIST)
            {
                KeyValuePair<double, double> kvp = new KeyValuePair<double, double>(x.Age, x.Ger);
                plot.Add(kvp);
            }

            avgChart.DataContext = plot;
        }

        private void Exp()
        {
            StringBuilder str = new StringBuilder();
            gVa age = new gVa();
            age.stepByger(1.0, 0.1, 30);

            foreach(var x in age.LIST)
            {
                str.AppendFormat("{0:F2},{1:F2}", x.Ger, x.Age);
                str.AppendLine();
            }

            Clipboard.Clear();
            Clipboard.SetText(str.ToString());
        }

        private void query_Click(object sender, RoutedEventArgs e)
        {
            Query nf = new Query();
            nf.ShowDialog();
        }
        
        private void zGo_Click(object sender, RoutedEventArgs e)
        {
            ComputList();
        }

        private bool validinput()
        {
            
            return true;
        }
    }
}
