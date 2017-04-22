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
        public void setupEdit(Entry entry)
        {
            //set the title and day boxes to the correct info
            TitleBox.Text = entry.Name;
            DayBox.Text = entry.Day;
            //split the string for time
            string[] stringtime = entry.Time.Split(':');
            //then parse them to convert to ints
            int[] inttime = { Int32.Parse(stringtime[0]), Int32.Parse(stringtime[1]) };
            //and set the numericupdowns' values to the correct number
            HourNum.Value = inttime[0];
            minuteNum.Value = inttime[1];

            AdditionalInfoBox.Text = entry.AdditionalInfo;


        }


        public string getTitle()
        {
            return TitleBox.Text;
        }
        public string getDay()
        {
            return DayBox.Text;
        }
        public string getTime()
        {
            string time = HourNum.Value.ToString() + ":";
            if(minuteNum.Value > 9)
            {
                time += minuteNum.Value.ToString();
            }
            else
            {
                time += "0" + minuteNum.Value.ToString();
            }
            return time;
        }
        public string getAddInfo()
        {
            return AdditionalInfoBox.Text;
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
