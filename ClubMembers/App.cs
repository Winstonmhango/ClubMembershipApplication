//March 24, 2012 at 12:58PM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace ClubMembers
{
    class App
    {
        public static string getConnectionString()
        {
            //This string will be different depending on what version of Windows,
            //and what version of MS Office you have.  This OleDb driver is for
            //Windows 7 (64 bit).  The driver is available for both 32 bit and 64 bit
            //versions of office.  If you are using the 32 bit version of office
            //you need to set the target processor property on the configuration 
            //property sheet of the BUILD menu to x86 before you build your solution.
            //you can find this OLEDB driver on line be doing a google search.
            //return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:/data/SportsClub.accdb";
            return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:/data/sportsclub.accdb";
        }

        public static DataTable getGenericData(string SQL)
        {
            //this is a generic method used to execute any SQL SELECT statement
            //and return the results as a datatable.  You will see the method
            //used several times in the employee class and this HR class.  You
            //are free to use this or any of my code in your solutions although
            //most of you are better coders than I am.

            DataSet ds = new DataSet();

            OleDbConnection dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = App.getConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(SQL, dbConnection);

            try
            {
                dbConnection.Open();
                da.Fill(ds, "GenericData");
            }
            catch (Exception err)
            {
                //catch any database error
                string errmessage = err.Message;
                Debug.WriteLine("getGenericData error:" + errmessage);
            }
            finally
            {
                //close the connection in case an error kept
                //the prior line of code to close the database from executing
                dbConnection.Close();
            }

            DataTable dt = ds.Tables["GenericData"];
            return dt;
        }

        public static string runDML(string strDML)
        {
            //this is a generic method to run an UPDATE, INSERT, OR DELETE statement
            //where the SQL statement is passed in as a string
            OleDbConnection dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = App.getConnectionString();
            OleDbCommand cmd = new OleDbCommand(strDML, dbConnection);

            try
            {
                dbConnection.Open();
                int intRowsUpdated = 0;
                intRowsUpdated = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                string errmessage = err.Message;
                Debug.WriteLine("runDML(string) error:" + errmessage);
                return "error executing: " + strDML;
            }
            finally
            {
                //comment here
                dbConnection.Close();
            }
            return "Success";

        }

        public static string runDML(OleDbCommand cmdDML)
        {
            //this is a generic method to run an UPDATE, INSERT, OR DELETE statement
            //where the SQL statement is passed in as a parameterized command
            //this provides better protection against SQL injection attacks
            OleDbConnection dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = App.getConnectionString();
            cmdDML.Connection = dbConnection;

            try
            {
                dbConnection.Open();
                int intRowsUpdated = 0;
                intRowsUpdated = cmdDML.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                string errmessage = err.Message;
                Debug.WriteLine("runDML(oleDbComman) error:" + errmessage);
                return "Error executing: " + cmdDML.CommandText;
            }
            finally
            {
                //comment here
                dbConnection.Close();
                Debug.WriteLine("database commit and close");
            }
            return "Success";

        }

        public static DataTable getSemesterList()
        {
            //this returns a list of the semesters (from newest to oldest) which is used to
            //populate the choices in the semesters drop down list

            string SQL;
            SQL = "Select semester from semesters order by sortorder asc";

            DataTable dt = App.getGenericData(SQL);

            return dt;
        }

        public static DataTable getMemberList()
        {
            //this returns a list of club member usernames which is used to
            //populate the dropdown lists in the GUI

            string SQL;
            SQL = "Select c.username, firstname, lastname, nickname, status, sum(amount) as balanceDue";
            SQL = SQL + " from ClubMembers c left outer join Transactions t";
            SQL = SQL + " on c.username = t.username";
            SQL = SQL + "group by lastname, firstname, c.username, c.nickname, c.status";
            SQL = SQL + "order by lastname, firstname";

            DataTable dt = App.getGenericData(SQL);

            return dt;
        }

        public static DataTable getUsernames()
        {
            string SQL;
            SQL = "Select username from ClubMembers";

            DataTable dt = App.getGenericData(SQL);

            return dt;
        }

        public static DataTable getMembersAndBalance()
        {
            //this returns a list of club members and current balance

            string SQL;
            SQL = " select c.username, firstname, lastname, nickname, homephone, cellphone, email, status, ";
            SQL = SQL + " sum(amount) as balance ";
            SQL = SQL + " from ClubMembers c left outer join Transactions t ";
            SQL = SQL + " on c.username = t.username ";
            SQL = SQL + " group by c.username, firstname, lastname, nickname, homephone, cellphone, email, status ";
            SQL = SQL + " order by lastname, firstname";

            Debug.WriteLine(SQL);
            DataTable dt = App.getGenericData(SQL);

            return dt;
        }

        public static DataTable getActiveMembersAndBalance()
        {
            //this returns a list of club members and current balance

            string SQL;
            SQL = " select c.username, firstname, lastname, nickname, homephone, cellphone, email, status, ";
            SQL = SQL + " sum(amount) as balance ";
            SQL = SQL + " from ClubMembers c left outer join Transactions t ";
            SQL = SQL + " on c.username = t.username ";
            SQL = SQL + " where status = \"Active\"";
            SQL = SQL + " group by c.username, firstname, lastname, nickname, homephone, cellphone, email, status ";
            SQL = SQL + " order by lastname, firstname";

            Debug.WriteLine(SQL);
            DataTable dt = App.getGenericData(SQL);

            return dt;
        }

        public static DataTable getDepositList()
        {
            //this returns a list of deposits which is used to
            //populate the dropdown lists in the GUI

            string SQL;
            SQL = "Select DepositNumber, DepositDate from Deposits order by DepositNumber Desc";

            DataTable dt = App.getGenericData(SQL);

            return dt;
        }

        public static DataTable getDepositIds()
        {
            string SQL;
            SQL = "Select DepositNumber from Deposits order by DepositNumber Desc";

            DataTable dt = App.getGenericData(SQL);

            return dt;
        }

        public static DataTable getMemberTransactions(ClubMember member)
        {
            //this returns a list of transactions for one individual
            //club member

            string SQL;
            SQL = "SELECT * FROM transactions where username = '" + member.getUsername() + "'";
            Debug.WriteLine(SQL);
            DataTable dt = App.getGenericData(SQL);

            return dt;
        }

        public static DataTable getMemberTransactions(string username)
        {
            //this returns a list of transactions for one individual
            //club member

            string SQL;
            SQL = "SELECT * FROM transactions where username = '" + username + "'";
            Debug.WriteLine(SQL);
            DataTable dt = App.getGenericData(SQL);

            return dt;
        }

        public static DataTable getTransactions()
        {
            string SQL = "select t1.transno, t1.username, t1.type, t1.transdate, t1.depositnumber, t1.checknumber, t1.amount";
            SQL = SQL + " from transactions t1 inner join clubmembers t2";
            SQL = SQL + " on t1.username = t2.username";
            DataTable dt = App.getGenericData(SQL);
            return dt;
        }

        public static DataTable getAllTransColsForID(string transno)
        {
            string SQL = "select * from transactions where transno = " + transno;
            DataTable dt = App.getGenericData(SQL);
            Debug.WriteLine(SQL);

            return dt;
        }

        public static DataTable getActiveTransactions()
        {
            string SQL = "select t1.transno, t1.username, t1.type, t1.transdate, t1.depositnumber, t1.checknumber, t1.amount";
            SQL = SQL + " from transactions t1 inner join clubmembers t2";
            SQL = SQL + " on t1.username = t2.username";
            SQL = SQL + " where status='Active'";
            DataTable dt = App.getGenericData(SQL);
            return dt;
        }

        public static bool memberExists(string username_to_check)
        {
            string SQL;
            SQL = "Select * from ClubMembers where username = '" + username_to_check + "'";

            DataTable dt = App.getGenericData(SQL);

            if (dt.Rows.Count == 1)
                return true;
            else
                return false;
        }

        public static bool depositExists(string depositNumber_to_check)
        {
            string SQL;
            SQL = "Select * from Deposits where depositNumber = '" + depositNumber_to_check + "'";

            DataTable dt = App.getGenericData(SQL);

            if (dt.Rows.Count == 1)
                return true;
            else
                return false;
        }

        public static string CreateGroupCharge(string Semester, DateTime TransDate, string Description, decimal Amount)
        {
            string strDML;
            strDML = "INSERT INTO transactions ( Type, Semester, Username, TransDate, Description, Amount ) ";
            strDML = strDML + "select 'Charge', ?, username, ?, ?, ? from ClubMembers ";
            strDML = strDML + "where status = 'Active'";
            Debug.WriteLine(Semester);
            Debug.WriteLine(TransDate);
            Debug.WriteLine(Description);
            Debug.WriteLine(Amount);
            //Create a DML command  with parameters for each of the question marks above
            OleDbCommand cmd = new OleDbCommand(strDML);
            cmd.Parameters.Add(new OleDbParameter("semester", Semester));
            cmd.Parameters.Add(new OleDbParameter("transDate", TransDate.ToShortDateString()));
            cmd.Parameters.Add(new OleDbParameter("description", Description));
            cmd.Parameters.Add(new OleDbParameter("amount", Amount));

            Debug.WriteLine(strDML);
            string message = App.runDML(cmd);
            if (message == "Success")
            {
                Debug.WriteLine("Successful Group Transaction");
                return message;
            }
            else
            {
                Debug.WriteLine("Failure on Group Transaction");
                return message;
            }

        }

        public static string StringOrNull(string stringToCheck)
        {
            if (stringToCheck.Length == 0)
                return String.Empty;
            else
                return stringToCheck;
        }

        public static decimal MyDecParse(string string_to_parse)
        {
            //this method is used to parse a string to a decimal
            //It takes a string such as $10,000.00 and scrubs out
            //the dollar sign and commas in order to parse without errors

            //if zero length string change it to a zero
            if (string_to_parse.Length == 0)
            {
                string_to_parse = "0";
            }

            //get rid of any dollar sign or commas from the string
            if (string_to_parse.Contains('$'))
            {
                int symbol_location = string_to_parse.LastIndexOf("$");
                string_to_parse = string_to_parse.Substring(0, symbol_location) + string_to_parse.Substring(symbol_location + 1);
            }
            //get rid of any commas in the string
            while (string_to_parse.Contains(','))
            {
                int symbol_location = string_to_parse.LastIndexOf(",");
                string_to_parse = string_to_parse.Substring(0, symbol_location) + string_to_parse.Substring(symbol_location + 1);
            }
            //replace parenthesis with negative sign if needed
            if (string_to_parse.Substring(0, 1) == "(")
            {
                // replace the first character with negative sign
                string_to_parse = "-" + string_to_parse.Substring(1);
                int stringLength = string_to_parse.Length;
                // get rid of the final closing paren
                string_to_parse = string_to_parse.Substring(0, stringLength - 1);
                Debug.WriteLine(string_to_parse);
            }

            //now that the string is clear of special charcters use PARSE to create a decimal
            try
            {
                return decimal.Parse(string_to_parse);
            }
            catch
            {
                //must be a blank string or invalid string
                Debug.WriteLine("myParseFailure");
                return (Decimal)0.0;
            }
            finally
            {
                //comment here
            }

        }

        public static string addSemester(string semester)
        {
            string result = "";
            DataTable dt = App.getSemesterList();
            bool found = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Debug.WriteLine(dt.Rows[i][0].ToString());
                if (dt.Rows[i][0].Equals(semester))
                { 
                    found = true;
                    break;
                }

            }
            if (found)
            {
                result = "Semester already exists";
            }
            else
            {
                string SQL;
                string sort = "select max(sortorder)+1 as sortorder from semesters";


                DataTable dts = App.getGenericData(sort);
                SQL = "insert into semesters (semester, sortorder) values (\"" + semester + "\", " + dts.Rows[0][0].ToString() + ")";
                Debug.WriteLine(SQL);
                result = App.runDML(SQL);
            }
            return result;
        }
    }
}
