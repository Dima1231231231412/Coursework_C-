using System;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class FormMain : Form
    {
        DatabaseMain dbm = new DatabaseMain(@"Data Source=..\..\..\DatabaseMain.sdf");
        public FormMain()
        {
            InitializeComponent();
        }      

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGroups fg = new FormGroups(dbm);
            fg.ShowDialog();
        }

        private void детиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChildren fc = new FormChildren(dbm);
            fc.ShowDialog();
        }

        private void родителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParents fp = new FormParents(dbm);
            fp.ShowDialog();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSchedule fs = new FormSchedule(dbm);
            fs.ShowDialog();
        }

        private void учителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeachers ft = new FormTeachers(dbm);
            ft.ShowDialog();
        }       
    }
}
