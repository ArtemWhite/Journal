using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace Journal
{
    public partial class Directorн : Form
    {
        public Directorн()
        {
            InitializeComponent();
            btnUpdate_Click(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lBoxAud.Items.Clear();
            lBoxGroup.Items.Clear();
            lBoxStud.Items.Clear();
            lBoxSub.Items.Clear();
            lBoxTeach.Items.Clear();
            JournalDBDataContext db = new JournalDBDataContext();
            foreach (var item in db.GetTable<Subjects>())
                lBoxSub.Items.Add(item);
            foreach (var item in db.GetTable<Auditories>())
                lBoxAud.Items.Add(item);
            foreach (var item in db.GetTable<Groups>())
                lBoxGroup.Items.Add(item);
            foreach (var item in db.GetTable<Teacher>())
                lBoxTeach.Items.Add(item);
            foreach (var item in db.GetTable<Student>())
                lBoxStud.Items.Add(item);
        }

        private void btnAddAudit_Click(object sender, EventArgs e)
        {
            JournalDBDataContext db = new JournalDBDataContext();
            Table<Auditories> auditories = db.GetTable<Auditories>();
            Auditories auditories1 = new Auditories() { Number = Convert.ToInt32(tBoxAud.Text) };
            auditories.InsertOnSubmit(auditories1);
            db.SubmitChanges();
            btnUpdate_Click(sender, e);
            tBoxAud.Text = "";
        }

        private void btnAddSubj_Click(object sender, EventArgs e)
        {
            JournalDBDataContext db = new JournalDBDataContext();
            Subjects subjects = new Subjects() { Name = tBoxSub.Text };
            db.GetTable<Subjects>().InsertOnSubmit(subjects);
            db.SubmitChanges();
            btnUpdate_Click(sender, e);
            tBoxSub.Text = "";
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            JournalDBDataContext db = new JournalDBDataContext();
            Groups group = new Groups() { Name = tBoxGroup.Text };
            db.GetTable<Groups>().InsertOnSubmit(group);
            db.SubmitChanges();
            btnUpdate_Click(sender, e);
            tBoxGroup.Text = "";
        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            JournalDBDataContext db = new JournalDBDataContext();
            Teacher teac = new Teacher() { Name = tBoxTeach.Text };
            db.GetTable<Teacher>().InsertOnSubmit(teac);
            db.SubmitChanges();
            btnUpdate_Click(sender, e);
            tBoxTeach.Text = "";
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            JournalDBDataContext db = new JournalDBDataContext();
            Student student = new Student() { Name = tBoxStudName.Text, GroupId = Convert.ToInt32(tBoxStudId.Text) };
            db.GetTable<Student>().InsertOnSubmit(student);
            db.SubmitChanges();
            btnUpdate_Click(sender, e);
            tBoxStudName.Text = "";
            tBoxStudId.Text = "";
        }

































        ///---------------------------
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
