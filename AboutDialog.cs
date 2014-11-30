using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTGen
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();

            AboutTxt.Text =
                "Truth Table Generator v1.0 \n" +
                "By Lee Zhen Yong AKA bruceoutdoors \n\n" +
                "Built date: 30 Nov 2014 \n\n" +
                "Uses Dijkstra's Shunting Yard algorithm \n" +
                "and reverse polish notation. \n\n"
                ;
        }
    }
}
