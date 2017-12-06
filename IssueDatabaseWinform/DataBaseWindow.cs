using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueDatabaseWinform
{
    public partial class DataBaseWindow : Form
    {
        public DataBaseWindow()
        {
            InitializeComponent();
        }

        double i = 0;

        private void NewIssue_Button_Click(object sender, EventArgs e)
        {
            Ticket t;
            t = new Ticket(i, "This is a Test", 'A', TicketStatus.PENDING, "John Smith");

            AddIssue(t);
            i++;
            int tr = DatabaseDataGrid.ColumnCount;
        }
    }
}
