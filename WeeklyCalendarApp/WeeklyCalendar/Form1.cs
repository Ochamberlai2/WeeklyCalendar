using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WeeklyCalendar
{
    public partial class Calendar : Form
    {

        private List<List<Entry>> week = new List<List<Entry>> { };

        private List<Entry> mondayEntries = new List<Entry> { };
        private List<Entry> tuesdayEntries = new List<Entry> { };
        private List<Entry> wednesdayEntries = new List<Entry> { };
        private List<Entry> thursdayEntries = new List<Entry> { };
        private List<Entry> fridayEntries = new List<Entry> { };
        private List<Entry> saturdayEntries = new List<Entry> { };
        private List<Entry> sundayEntries = new List<Entry> { };



        public Calendar()
        {
            InitializeComponent();
            //add all of the days to the list (in the most atrocious way possible)
            week.Add(mondayEntries);
            week.Add(tuesdayEntries);
            week.Add(wednesdayEntries);
            week.Add(thursdayEntries);
            week.Add(fridayEntries);
            week.Add(saturdayEntries);
            week.Add(sundayEntries);

        }

        private void AddEntry()
        {
            //create the add entry form
            var addEntry = new AddEntryForm();
            //then if it's dialog result is ok
            if (addEntry.ShowDialog() == DialogResult.OK)
            {
                //create a new entry object (This will be used for JSON exporting in the future)
                //this information is populated from the add entry form's fields
                Entry newEntry = new Entry()
                {
                    Name = addEntry.getTitle(),
                    Day = addEntry.getDay().ToLower(),
                    Time = addEntry.getTime(),
                    AdditionalInfo = addEntry.getAddInfo()
                };
                #region add the entry to the correct day's tab + list container
                //find out what day it should be attributed to and file the entry into the correct list
                switch (newEntry.Day)
                {
                    //first add the name of the entry to the list
                    //then append the info box with the time and any additional info
                    //then add it to the day's list of entries
                    case "monday":
                        MondayList.Items.Add(newEntry.Name);
                        mondayEntries.Add(newEntry);
                        break;

                    case "tuesday":
                        TuesdayList.Items.Add(newEntry.Name);
                        tuesdayEntries.Add(newEntry);
                        break;

                    case "wednesday":
                        WednesdayList.Items.Add(newEntry.Name);
                        wednesdayEntries.Add(newEntry);
                        break;

                    case "thursday":
                        ThursdayList.Items.Add(newEntry.Name);
                        thursdayEntries.Add(newEntry);
                        break;

                    case "friday":
                        FridayList.Items.Add(newEntry.Name);
                        fridayEntries.Add(newEntry);
                        break;

                    case "saturday":
                        SaturdayList.Items.Add(newEntry.Name);
                        saturdayEntries.Add(newEntry);
                        break;

                    case "sunday":
                        SundayList.Items.Add(newEntry.Name);
                        sundayEntries.Add(newEntry);
                        break;

                }
                #endregion  add the entry to the correct day's list


            }
        }
        //updates the text box corresponding to the correct list with the information required by the selected index
        void selectedListItem(object sender, MouseEventArgs e)
        {
            
            //check every day in the week
            foreach (var dayEntry in week)
            {
                //and every entry in the day
                foreach (var entry in dayEntry)
                {
                    //then check what day the entry is for
                    //and update the correct textbox
                    switch (DaysTab.SelectedTab.Text.ToLower())
                    {
                        case "monday":
                            {
                                int index = MondayList.IndexFromPoint(e.Location);
                                if (index != ListBox.NoMatches)
                                    if (entry.Name == MondayList.SelectedItem.ToString())
                                    {
                                        MondayInfo.Clear();
                                        MondayInfo.AppendText("Time: " + entry.Time);
                                        MondayInfo.AppendText("\r\n\r\n" + entry.AdditionalInfo);
                                    }
                            }
                            break;
                        case "tuesday":
                            {
                                int index = TuesdayList.IndexFromPoint(e.Location);
                                if (index != ListBox.NoMatches)
                                    if (entry.Name == TuesdayList.SelectedItem.ToString())
                                    {
                                        TuesdayInfo.Clear();
                                        TuesdayInfo.AppendText("Time: " + entry.Time);
                                        TuesdayInfo.AppendText("\r\n\r\n" + entry.AdditionalInfo);
                                    }
                            }
                            break;
                        case "wednesday":
                            { 
                                int index = WednesdayList.IndexFromPoint(e.Location);
                                if (index != ListBox.NoMatches)
                                    if (entry.Name == WednesdayList.SelectedItem.ToString())
                                    {

                                        WednesdayInfo.Clear();
                                        WednesdayInfo.AppendText("Time: " + entry.Time);
                                        WednesdayInfo.AppendText("\r\n\r\n" + entry.AdditionalInfo);
                                    } 
                            }
                            break;
                        case "thursday":
                            {
                                int index = ThursdayList.IndexFromPoint(e.Location);
                                if (index != ListBox.NoMatches)
                                    if (entry.Name == ThursdayList.SelectedItem.ToString())
                                {
                                    ThursdayInfo.Clear();
                                    ThursdayInfo.AppendText("Time: " + entry.Time);
                                    ThursdayInfo.AppendText("\r\n\r\n" + entry.AdditionalInfo);
                                }
                            }
                            break;
                        case "friday":
                            {
                                int index = FridayList.IndexFromPoint(e.Location);
                                if (index != ListBox.NoMatches)
                                    if (entry.Name == FridayList.SelectedItem.ToString())
                                    {
                                        FridayInfo.Clear();
                                        FridayInfo.AppendText("Time: " + entry.Time);
                                        FridayInfo.AppendText("\r\n\r\n" + entry.AdditionalInfo);
                                    }
                            }
                            break;
                        case "saturday":
                            {
                                int index = SaturdayList.IndexFromPoint(e.Location);
                                if (index != ListBox.NoMatches)
                                    if (entry.Name == SaturdayList.SelectedItem.ToString())
                                    {
                                        SaturdayInfo.Clear();
                                        SaturdayInfo.AppendText("Time: " + entry.Time);
                                        SaturdayInfo.AppendText("\r\n\r\n" + entry.AdditionalInfo);
                                    }
                            }
                            break;
                        case "sunday":
                            {
                                int index = SundayList.IndexFromPoint(e.Location);
                                if (index != ListBox.NoMatches)
                                    if (entry.Name == SundayList.SelectedItem.ToString())
                                    {
                                        SundayInfo.Clear();
                                        SundayInfo.AppendText("Time: " + entry.Time);
                                        SundayInfo.AppendText("\r\n\r\n" + entry.AdditionalInfo);
                                    }
                            }
                            break;

                        default:
                            break;
                    }

                }

            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEntry();
        }
      
      

        private void onFormOpen(object sender, EventArgs e)
        {
            #region date/time
            DateTime currentdatetime = DateTime.Now;
            switch(currentdatetime.ToString("dddd"))
            {
                case "Monday":
                    DaysTab.SelectedTab = Monday;
                    break;
                case "Tuesday":
                    DaysTab.SelectedTab = Tuesday;
                    break;
                case "Wednesday":
                    DaysTab.SelectedTab = Wednesday;
                    break;
                case "Thursday":
                    DaysTab.SelectedTab = Thursday;
                    break;
                case "Friday":
                    DaysTab.SelectedTab = Friday;
                    break;
                case "Saturday":
                    DaysTab.SelectedTab = Saturday;
                    break;
                case "Sunday":
                    DaysTab.SelectedTab = Sunday;
                    break;
            }
            #endregion date/time
            #region deserialisation
            Entry[] deserializedEntries = { };
            //get the filepath for the json file
            var filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CalendarApp\\weeklyInfo.json");
            if (File.Exists(filename))
            {
                //then deserialize it
              deserializedEntries  = JsonConvert.DeserializeObject<Entry[]>(File.ReadAllText(@filename));
            }

        if (deserializedEntries != null)
        { 
                    //and add them to the correct list
                    foreach (Entry entryInfo in deserializedEntries)
                    {
                        switch (entryInfo.Day.ToLower())
                        {
                            case "monday":
                                MondayList.Items.Add(entryInfo.Name);
                                mondayEntries.Add(entryInfo);
                                break;
                            case "tuesday":
                                TuesdayList.Items.Add(entryInfo.Name);
                                tuesdayEntries.Add(entryInfo);
                                break;
                            case "wednesday":
                                WednesdayList.Items.Add(entryInfo.Name);
                                wednesdayEntries.Add(entryInfo);
                                break;
                            case "thursday":
                                ThursdayList.Items.Add(entryInfo.Name);
                                thursdayEntries.Add(entryInfo);
                                break;
                            case "friday":
                                FridayList.Items.Add(entryInfo.Name);
                                fridayEntries.Add(entryInfo);
                                break;
                            case "saturday":
                                SaturdayList.Items.Add(entryInfo.Name);
                                saturdayEntries.Add(entryInfo);
                                break;
                            case "sunday":
                                SundayList.Items.Add(entryInfo.Name);
                                sundayEntries.Add(entryInfo);
                                break;
                            default:
                                break;

                        }//switch
                    }
                }//deserialized entries
            #endregion deserialisation
        }

        private void Calendar_FormClosed(object sender, FormClosedEventArgs e)
        {

            List<Entry> serializeList = new List<Entry> { };
            //loop through every list in the week list
            foreach(var day in week)
            {
                //to find every entry
                foreach(var entry in day)
                {
                    serializeList.Add(entry);
                }
            }
            string jsonFile = JsonConvert.SerializeObject(serializeList, Formatting.Indented);
            //then find the file name and add it to the correct file in the appdata folder
            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CalendarApp/weeklyInfo.json");

            if(serializeList.Count > 0)
            {
                //if the directory does not exist, create it
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CalendarApp"));
                //then write it to file
                File.WriteAllText(@fileName, jsonFile);

            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            switch(DaysTab.SelectedTab.Text.ToLower())
            {
                case "monday":
                    foreach(Entry entry in mondayEntries)
                    {
                        if(entry.Name == MondayList.SelectedItem.ToString())
                        {
                            MondayInfo.Clear();
                            mondayEntries.Remove(entry);
                            MondayList.Items.Remove(MondayList.SelectedItem);
                            break;
                        }
                    }
                    break;
                case "tuesday":
                  
                    foreach (Entry entry in tuesdayEntries)
                    {
                        if (entry.Name == TuesdayList.SelectedItem.ToString())
                        {
                            TuesdayInfo.Clear();
                            TuesdayList.Items.Remove(TuesdayList.SelectedItem);
                            tuesdayEntries.Remove(entry);
                                break;
                        }
                    }
                    break;
                case "wednesday":
                    foreach (Entry entry in wednesdayEntries)
                    {
                        if (entry.Name == WednesdayList.SelectedItem.ToString())
                        {
                            WednesdayInfo.Clear();
                            wednesdayEntries.Remove(entry);
                            WednesdayList.Items.Remove(WednesdayList.SelectedItem);
                            break;
                        }
                    }
                    break;
                case "thursday":
                    foreach (Entry entry in thursdayEntries)
                    {
                        if (entry.Name == ThursdayList.SelectedItem.ToString())
                        {
                            ThursdayInfo.Clear();
                            thursdayEntries.Remove(entry);
                            ThursdayList.Items.Remove(ThursdayList.SelectedItem);
                            break;
                        }
                    }
                    break;
                case "friday":
                    foreach (Entry entry in fridayEntries)
                    {
                        if (entry.Name == FridayList.SelectedItem.ToString())
                        {
                            FridayInfo.Clear();
                            fridayEntries.Remove(entry);
                            FridayList.Items.Remove(FridayList.SelectedItem);
                            break;
                        }
                    }
                    break;
                case "saturday":
                    foreach (Entry entry in saturdayEntries)
                    {
                        if (entry.Name == SaturdayList.SelectedItem.ToString())
                        {
                            SaturdayInfo.Clear();
                            saturdayEntries.Remove(entry);
                            SaturdayList.Items.Remove(SaturdayList.SelectedItem);
                            break;
                        }
                    }
                    break;
                case "sunday":
                    foreach (Entry entry in sundayEntries)
                    {
                        if (entry.Name == SundayList.SelectedItem.ToString())
                        {
                            SundayInfo.Clear();
                            sundayEntries.Remove(entry);
                            SundayList.Items.Remove(SundayList.SelectedItem);
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var addEntry = new AddEntryForm();
            string prevEntryName = "";
            //look for the entry in the correct list and set up the form ready to edit
            switch (DaysTab.SelectedTab.Text.ToLower())
            {
                case "monday":
                    foreach(Entry entry in mondayEntries)
                    {
                        if (entry.Name == MondayList.SelectedItem.ToString())
                        {
                            prevEntryName = entry.Name;
                            addEntry.setupEdit(entry);
                            break;
                        }
                    }
                    break;
                case "tuesday":
                    foreach (Entry entry in tuesdayEntries)
                    {
                        if (entry.Name == TuesdayList.SelectedItem.ToString())
                        {
                            prevEntryName = entry.Name;

                            addEntry.setupEdit(entry);
                            break;
                        }
                    }
                    break;
                case "wednesday":
                    foreach (Entry entry in wednesdayEntries)
                    {
                        if (entry.Name == WednesdayList.SelectedItem.ToString())
                        {
                            prevEntryName = entry.Name;

                            addEntry.setupEdit(entry);
                            break;
                        }
                    }
                    break;
                case "thursday":
                    foreach (Entry entry in thursdayEntries)
                    {
                        if (entry.Name == ThursdayList.SelectedItem.ToString())
                        {
                            prevEntryName = entry.Name;

                            addEntry.setupEdit(entry);
                            break;
                        }
                    }

                    break;
                case "friday":
                    foreach (Entry entry in fridayEntries)
                    {
                        if (entry.Name == FridayList.SelectedItem.ToString())
                        {
                            prevEntryName = entry.Name;

                            addEntry.setupEdit(entry);
                            break;
                        }
                    }
                    break;
                case "saturday":
                    foreach (Entry entry in saturdayEntries)
                    {
                        if (entry.Name == SaturdayList.SelectedItem.ToString())
                        {
                            prevEntryName = entry.Name;

                            addEntry.setupEdit(entry);
                            break;
                        }
                    }
                    break;
                case "sunday":
                    foreach (Entry entry in sundayEntries)
                    {
                        if (entry.Name == SundayList.SelectedItem.ToString())
                        {
                            prevEntryName = entry.Name;

                            addEntry.setupEdit(entry);
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
            //when this has all been confirmed
            if(addEntry.ShowDialog() == DialogResult.OK)
            {
                //check every list in order to remove the correct entry
                foreach(var day in week)
                {
                    foreach(Entry entry in day)
                    {
                        if(entry.Name == prevEntryName)
                        {
                            switch(entry.Day.ToString().ToLower())
                            {
                                case "monday":
                                    MondayInfo.Clear();
                                    MondayList.Items.Remove(entry.Name);
                                    break;
                                case "tuesday":
                                    TuesdayInfo.Clear();
                                    TuesdayList.Items.Remove(entry.Name);
                                    break;
                                case "wednesday":
                                    WednesdayInfo.Clear();
                                    WednesdayList.Items.Remove(entry.Name);
                                    break;
                                case "thursday":
                                    ThursdayInfo.Clear();
                                    ThursdayList.Items.Remove(entry.Name);
                                    break;
                                case "friday":
                                    FridayInfo.Clear();
                                    FridayList.Items.Remove(entry.Name);
                                    break;
                                case "saturday":
                                    SaturdayInfo.Clear();
                                    SaturdayList.Items.Remove(entry.Name);
                                    break;
                                case "sunday":
                                    SundayInfo.Clear();
                                    SundayList.Items.Remove(entry.Name);
                                    break;
                                default:
                                    break;
                            }
                            //then change the entry's information
                            entry.Name = addEntry.getTitle();
                            entry.Day = addEntry.getDay();
                            entry.Time = addEntry.getTime();
                            entry.AdditionalInfo = addEntry.getAddInfo();
                            
                            //then sloppily add it to the correct list
                            switch (entry.Day.ToString().ToLower())
                            {
                                case "monday":
                                    MondayList.Items.Add(entry.Name);
                                    break;
                                case "tuesday":
                                    TuesdayList.Items.Add(entry.Name);
                                    break;
                                case "wednesday":
                                    WednesdayList.Items.Add(entry.Name);
                                    break;
                                case "thursday":
                                    ThursdayList.Items.Add(entry.Name);
                                    break;
                                case "friday":
                                    FridayList.Items.Add(entry.Name);
                                    break;
                                case "saturday":
                                    SaturdayList.Items.Add(entry.Name);
                                    break;
                                case "sunday":
                                    SundayList.Items.Add(entry.Name);
                                    break;
                                default:
                                    break;
                                    
                            }
                            //and finally break out of the loop
                            break;
                        }
                    }
                }
            }
        }
    }

    public class Entry
    {
        public string Name { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string AdditionalInfo { get; set; }

    }
}
