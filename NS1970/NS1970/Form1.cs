using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NS1970
{
    public partial class Form1 : Form
    // Example done by Jeremiah Stillings 1/20/2020

    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Initialize a date in the past.
            // This is Jan 1 1970
            /* Code sample from  https://www.dotnetperls.com/datetime-elapsed */
            string someDate = "01-01-1970";

         
            // Parse the date and put in DateTime object.
            DateTime startDate = DateTime.Parse(someDate);

            // Get the current DateTime.
            DateTime now = DateTime.Now;

      
            // Get the TimeSpan of the difference.
            TimeSpan elapsed = now.Subtract(startDate);

           
            // Get number of Seconds ago.
            double secondsAgo = (elapsed.TotalSeconds);
            label3.Text = someDate + " was " + secondsAgo.ToString("N0") + " Seconds Ago! Hit Go to refresh!";
            label3.Refresh();
            
        }
    }
}
