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
    public partial class Calendar : Form
    {

        private List<TabPage> week = new List<TabPage> { };
        private List<ListBox> listBoxes = new List<ListBox> { };


        public Calendar()
        {
            InitializeComponent();
            //add all of the listboxes to the list (in the most atrocious way possible)
            listBoxes.Add(MondayList);
            listBoxes.Add(TuesdayList);
            listBoxes.Add(WednesdayList);
            listBoxes.Add(ThursdayList);
            listBoxes.Add(FridayList);
            listBoxes.Add(SaturdayList);
            listBoxes.Add(SundayList);
        }

        private void AddEntry()
        {
            //create the add entry form
            var addEntry = new AddEntryForm();
            //then if it's dialog result is ok
            if(addEntry.ShowDialog() == DialogResult.OK)
            {
                //create a new entry object (This will be used for JSON exporting in the future)
                //this information is populated from the add entry form's fields
                Entry newEntry = new Entry()
                {
                    Name = addEntry.getTitle(),
                    Day = addEntry.getDay(),
                    Time = addEntry.getTime(),
                    AdditionalInfo = addEntry.getAddInfo()
                };
                //search through all of the tabs
                foreach(TabPage tab in DaysTab.TabPages)
                {
                    //and see if their name corresponds to the day from the entry
                    if(newEntry.Day == tab.Name)
                    {
                        //and then check through all of the listboxes to find the correct one
                        foreach(var listbox in listBoxes)
                        {
                            //and add the entry to the listbox
                            if(tab.Name + "List" == listbox.Name)
                            {
                                listbox.Items.Add(newEntry.Name);
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }








        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void MondayAdd_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void TuesdayAdd_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void WednesdayAdd_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void ThursdayAdd_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void FridayAdd_Click(object sender, EventArgs e)
        {
           AddEntry();
        }

        private void SaturdayAdd_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void SundayAdd_Click(object sender, EventArgs e)
        {
            AddEntry();
        }
    }
    public class Entry
    {
        public string Name { get; set; }
        public string Day { get; set; }
        public int[] Time { get; set; }
        public string AdditionalInfo { get; set; }

    }
}
