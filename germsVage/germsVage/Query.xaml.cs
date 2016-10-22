// (c) Khaled A Alwan .
// All other rights reserved.
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
using System.Windows.Shapes;

namespace germsVage
{
    /// <summary>
    /// Interaction logic for Query.xaml
    /// </summary>
    public partial class Query : Window
    {
        public Query()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            double gr;
            gVaitem gv = new gVaitem();
            if(string.IsNullOrWhiteSpace(zgr.Text) == false)
            {
                if( double.TryParse(zgr.Text, out gr) )
                {
                    gv.setAge(gr);
                    MessageBox.Show(gv.Age.ToString());
                }
            }
        }
    }
}
