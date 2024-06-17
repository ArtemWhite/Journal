using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Journal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int countWeek = new GregorianCalendar().GetWeekOfYear(new DateTime(2022, 12, 31), CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            for (int i = 0; i < countWeek; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedItem = new GregorianCalendar().GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            JournalDBDataContext db = new JournalDBDataContext();
            Table<Groups> groups = db.GetTable<Groups>();
            foreach (var item in groups)
                comBoxpn.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //JournalDBDataContext db = new JournalDBDataContext();
            //Table<Auditories> audithories = db.GetTable<Auditories>();
            //Auditories auditories = new Auditories() { Number = Convert.ToInt32(textBox1.Text) };
            //audithories.InsertOnSubmit(auditories);
            //db.SubmitChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //JournalDBDataContext db = new JournalDBDataContext();
            //Table<Auditories> audithories = db.GetTable<Auditories>();
            //foreach (var item in audithories)
            //    listBox1.Items.Add(item);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Directorн dir = new Directorн();
            dir.Show();
        }

        private void btnMond_Click(object sender, EventArgs e)
        {
            JournalDBDataContext db = new JournalDBDataContext();
            var coll = from tt in db.GetTable<TimeTable>() 
                       join subject in db.GetTable <Subjects>() 
                       on tt.SubjectId equals subject.Id
                       //where new GregorianCalendar().GetWeekOfYear(tt.Date_Time, CalendarWeekRule.FirstDay, DayOfWeek.Monday) == Convert.ToInt32(comboBox1.SelectedItem)
                       select tt;
            mn.Text = "";
            tu.Text = "";
            we.Text = "";
            th.Text = "";
            fr.Text = "";
            st.Text = "";
            su.Text = "";
            foreach (var item in coll)
            {
                if (new GregorianCalendar().GetWeekOfYear(item.Date_Time, CalendarWeekRule.FirstDay, DayOfWeek.Monday) == Convert.ToInt32(comboBox1.SelectedItem))
                {
                    if (item.Date_Time.DayOfWeek == DayOfWeek.Monday)
                        mn.Text += $"{item.Date_Time.ToShortTimeString()} | {item.Subjects}\n\r";

                    else if (item.Date_Time.DayOfWeek == DayOfWeek.Tuesday)
                        tu.Text += $"{item.Date_Time.ToShortTimeString()} | {item.Subjects}\n\r";

                    else if (item.Date_Time.DayOfWeek == DayOfWeek.Wednesday)
                        we.Text += $"{item.Date_Time.ToShortTimeString()} | {item.Subjects}\n\r";

                    else if (item.Date_Time.DayOfWeek == DayOfWeek.Thursday)
                        th.Text += $"{item.Date_Time.ToShortTimeString()} | {item.Subjects}\n\r";

                    else if (item.Date_Time.DayOfWeek == DayOfWeek.Friday)
                        fr.Text += $"{item.Date_Time.ToShortTimeString()} | {item.Subjects}\n\r";

                    else if (item.Date_Time.DayOfWeek == DayOfWeek.Saturday)
                        st.Text += $"{item.Date_Time.ToShortTimeString()} | {item.Subjects}\n\r";

                    else if (item.Date_Time.DayOfWeek == DayOfWeek.Sunday)
                        su.Text += $"{item.Date_Time.ToShortTimeString()} | {item.Subjects}\n\r";
                }
            }
            DateTime now = DateTime.Now;
            GregorianCalendar calendr = new GregorianCalendar();
            Console.WriteLine(calendr.GetWeekOfYear(now, CalendarWeekRule.FirstDay, DayOfWeek.Monday));
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = new GregorianCalendar().GetWeekOfYear(dateTimePicker1.Value, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }
    }
}
