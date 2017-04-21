using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeklyCalendar
{
    public partial class AddEntryForm : Form
    {
        public AddEntryForm()
        {
            InitializeComponent();
        }
        public string getTitle()
        {
            return TitleBox.Text;
        }
        public string getDay()
        {
            return DayBox.Text;
        }
        public int[] getTime()
        {
            int[] time = { (int)HourNum.Value, (int)minuteNum.Value };
            return time;
        }
        public string getAddInfo()
        {
            return AdditionalInfoBox.Text;
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
