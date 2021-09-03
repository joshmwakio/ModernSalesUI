using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesUI
{
    public partial class SalesDashForm : Form
    {
        public SalesDashForm()
        {
            InitializeComponent();
        }

        CultureInfo info = CultureInfo.GetCultureInfo("ke-KE");

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random salesRandomNumber = new Random();
            Random ssdSalespercentage = new Random();
            Random hddSalespercentage = new Random();
            Random gcSalespercentage = new Random();

            List<double> ssdListNumbers = new List<double>()
            {
               ssdSalespercentage.Next(21,55),
               ssdSalespercentage.Next(20,85),
               ssdSalespercentage.Next(40,55),
               ssdSalespercentage.Next(30,65),
               ssdSalespercentage.Next(51,55),
               ssdSalespercentage.Next(21,85),
            };
            List<double> hddListNumbers = new List<double>() {
               hddSalespercentage.Next(22,55),
              hddSalespercentage.Next(23,85),
              hddSalespercentage.Next(44,55),
              hddSalespercentage.Next(35,65),
              hddSalespercentage.Next(50,55),
              hddSalespercentage.Next(25,85),
            };
            List<double> gcListNumbers = new List<double>() {
              gcSalespercentage.Next(2,55),
              gcSalespercentage.Next(22,85),
              gcSalespercentage.Next(4,55),
              gcSalespercentage.Next(37,65),
              gcSalespercentage.Next(5,55),
              gcSalespercentage.Next(20,85),

            };
            salesBunifuLabel9.Text = String.Format(info," Ksh. {0} /=",salesRandomNumber.Next(250000, 630000).ToString("N0"));
            bunifuRadarChart1.Data = ssdListNumbers;
            bunifuRadarChart2.Data = hddListNumbers;
            bunifuRadarChart3.Data = gcListNumbers;

            bunifuChartCanvas1.Update();



        }
    }
}
