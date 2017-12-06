using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueDatabaseWinform
{
    public enum TicketStatus
    {
        PENDING,    // Defualt status of a newly submitted Issue
        INPROGRESS, // Issue is being worked on
        RESOLVED    // Issue has been resolved
    }

    public class Ticket
    {
        public double m_isssue_IDnumber = 0;    // Identification Number set on Ticket creation by the Database denoting place in the Database
        public string m_summary;                // Description of Issue submitted
        public char m_severityGrade;            // Grade denoting severity of Issue 
        public TicketStatus m_ticketStatus;     // Current status of this ticket
        public string m_submittedByName;        // Name of user that submitted the ticket to the Database

        public Ticket() { }     // Defualt Constructor
        public Ticket(double arg1, string arg2, char arg3, TicketStatus arg4, string arg5)  // Custom Constructor 
        {
            m_isssue_IDnumber = arg1;
            m_summary = arg2;
            m_severityGrade = arg3;
            m_ticketStatus = arg4;
            m_submittedByName = arg5;
        }
        
    }
}
