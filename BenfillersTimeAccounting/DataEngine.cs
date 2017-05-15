using System;
using System.Collections;
using System.Data.Common;
using System.Data.SQLite;
using System.Text;


using System.Windows.Forms;
//using System.Globalization;

namespace BenfillersTimeAccounting
{
    static class DataEngine
    {
        static readonly SQLiteConnection DbConnection;// = new SQLiteConnection("Data Source=AvonBenfillers.sqlite;Version=3;");
        static DataEngine()
        {
            try
            {
                DbConnection = new SQLiteConnection("Data Source=AvonBenfillers.sqlite;Version=3;");
                DbConnection.Open();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static public ArrayList GetAllButtons()
        {
            const string query = @"SELECT ButtonID AS 'Номер кнопки', MacAddress,  ButtonType AS 'Тип кнопки',  
              (SELECT LastName FROM Benfillers b WHERE b.BenfillerID = btns.BenfillerID)  AS 'Бенфиллер', (SELECT value FROM Segment b WHERE b.id = btns.Segment)  AS 'Кухня' FROM Buttons btns";
            var cmd = new SQLiteCommand(query, DbConnection);
            return TransferData(query);
        }
        static public ArrayList GetAllBenfillers()
        {
            const string query = @"SELECT BenfillerID AS 'Номер участка', LastName AS 'Фамилия', FirstName AS 'Имя' FROM Benfillers";
            return TransferData(query);
        }

        static public ArrayList GetReactionTimeByBenfillers(string benfiller, string datetime1text, string datetime2text, DateTime datetime1, DateTime datetime2)
        {


            //MessageBox.Show(datetime1);
            string query = @"SELECT 
                                strftime('%H:%M', CallTime) AS LastName,
                                abs((strftime('%s',AcceptTime)-strftime('%s',CallTime))/60) AS Calls
                                FROM CallEvents
            WHERE BenfillerID  = '" + benfiller + "'   AND strftime('%Y-%m-%d', AcceptTime) BETWEEN strftime('%Y-%m-%d', '" + datetime2text + "')  AND strftime('%Y-%m-%d', '" + datetime1text + "')";


            //MessageBox.Show("date('"+datetime1+"')");

            return TransferData(query);
        }


        static public ArrayList GetReaction()
        {


            string query = @"SELECT 
                                strftime('%d %H:%M', CallTime) AS LastName,
                                strftime('%s',AcceptTime)-strftime('%s',CallTime) AS Calls
                                FROM CallEvents";

            return TransferData(query);
        }

        static public ArrayList GetAcceptedEventCountsByBenfillers(string range)
        {
            string query = @"SELECT BenfillerID, 
                                (SELECT LastName FROM Benfillers b WHERE b.BenfillerID = e.BenfillerID) AS LastName, 
                                COUNT(BenfillerID) AS Calls 
                                FROM CallEvents e 
                                WHERE Accepted = 1 AND ";
            switch (range)
            {
                case "час":
                    query += @"strftime('%s', 'now', 'localtime') - strftime('%s', AcceptTime) < 3600 GROUP BY BenfillerID";
                    break;
                case "день":
                    query += @"date(AcceptTime) = date('now') GROUP BY BenfillerID";
                    break;
                case "неделя":
                    query += @"AcceptTime > datetime('now', 'start of day', 'weekday 6', '-6 day') GROUP BY BenfillerID";
                    break;
                case "месяц":
                    query += @"strftime('%Y-%m', AcceptTime) = strftime('%Y-%m', 'now') GROUP BY BenfillerID";
                    break;
            }
            return TransferData(query);
        }
        static public ArrayList GetAverageReactionTimeByBenfillers(string range)
        {
            string query = @"SELECT BenfillerID, 
                                (SELECT LastName FROM Benfillers b WHERE b.BenfillerID = e.BenfillerID) AS LastName, 
                                abs(((strftime('%s',AcceptTime)-strftime('%s',CallTime))/60)) AS AvgReactionTime 
                                FROM CallEvents e 
                                WHERE Accepted = 1 AND ";
            switch (range)
            {
                case "час":
                    query += @"strftime('%s', 'now', 'localtime') - strftime('%s', AcceptTime) < 3600 GROUP BY BenfillerID";
                    break;
                case "день":
                    query += @"date(AcceptTime) = date('now') GROUP BY BenfillerID";
                    break;
                case "неделя":
                    query += @"AcceptTime > datetime('now', 'start of day', 'weekday 6', '-6 day') GROUP BY BenfillerID";
                    break;
                case "месяц":
                    query += @"strftime('%Y-%m', AcceptTime) = strftime('%Y-%m', 'now') GROUP BY BenfillerID";
                    break;
            }
            return TransferData(query);
        }
        static public void DelButton(int buttonId)
        {
            string query = string.Format(@"DELETE FROM Buttons WHERE ButtonID = {0}", buttonId);
            TransferData(query);
        }
        static public void DelBenfiller(int benfillerId)
        {
            string query = string.Format(@"DELETE FROM Benfillers WHERE BenfillerID = {0}", benfillerId);
            TransferData(query);
        }
        static public ArrayList TransferData(string query)
        {
            ArrayList list = null;
            try
            {
                    var cmd = new SQLiteCommand(query, DbConnection);
                    if (query.StartsWith("SELECT"))
                    {
                        list = new ArrayList();
                        var dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            foreach (DbDataRecord rw in dr)
                            {
                                list.Add(rw);
                            }
                        }
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                    }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message, "Ошибка работы с БД!");
            }
            return list;
        }
        static public void AddButton(string macAddress, int buttonNumber, int lineNumber, int stationNumber, string buttonType, string side, int benfillerId, int SegmentId)
        {
            var query = string.Format(@"INSERT INTO Buttons VALUES('{0}','{1}','{2}','{3}','{4}','{5}', '{6}', '{7}')",
                buttonNumber, macAddress, stationNumber, buttonType, lineNumber, side, benfillerId, SegmentId);
            TransferData(query);
        }
        static public void AddCallEvent(int callButtonNumber)
        {
            var query = string.Format(@"INSERT INTO CallEvents(CallButtonID) VALUES('{0}')", callButtonNumber);
            TransferData(query);
        }
        static public int GetButtonIdByMacAddress(string macAddress)
        {
            var query = string.Format(@"SELECT ButtonID FROM Buttons WHERE MacAddress = '{0}'", macAddress);
            return Convert.ToInt32(new SQLiteCommand(query, DbConnection).ExecuteScalar());
        }
        static public bool IsCallButton(int buttonId)
        {
            var query = string.Format(@"SELECT ButtonType FROM Buttons WHERE ButtonID = {0}", buttonId);
            return new SQLiteCommand(query, DbConnection).ExecuteScalar().ToString().Contains("CALL");
        }
        static public void AddAcceptEvent(int acceptButtonNumber)
        {
            var query = string.Format(@"UPDATE CallEvents SET AcceptButtonID = '{0}', Accepted = 1, AcceptTime = DATETIME('now', 'localtime')
                                        WHERE Accepted = 0 AND 
                                        CallButtonID = (SELECT CallButtonID FROM vCallAcceptButtonPairs WHERE AcceptButtonID = {0})", 
                acceptButtonNumber);
            TransferData(query);
        }
        static public void AddBenfiller(int benfillerId, string firstName, string lastName)
        {
            var query = string.Format(@"INSERT INTO Benfillers VALUES('{0}','{1}','{2}')",
                benfillerId, lastName, firstName);
            TransferData(query);
        }
        static public void CloseDB()
        {
            try
            {
                DbConnection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public ArrayList GetAllSegments()
        {
            const string query = @"SELECT id AS 'Номер сегмента', value AS 'Название сегмента' FROM Segment ";
            return TransferData(query);
        }
        static public void AddSegment(int id, string value)
        {
            var query = string.Format(@"INSERT INTO Segment VALUES('{0}','{1}')",
                id, value);
            TransferData(query);
        }
        static public void DelSegment(int Id)
        {
            string query = string.Format(@"DELETE FROM Segment WHERE id = {0}", Id);
            TransferData(query);
        }

      //  static public void AddSegmentBase()
      //   {
      // 
      //        var query =
      //            string.Format("CREATE TABLE Segment (id INTEGER PRIMARY KEY, value TEXT);");
      //  
      //        TransferData(query);
      //   }

        /*
        --час
        --SELECT * FROM CallEvents WHERE strftime('%s', 'now', 'localtime') - strftime('%s', CallTime) < 3600;
        --последняя неделя
        --SELECT * FROM CallEvents WHERE CallTime > datetime('now', 'start of day', 'weekday 6', '-6 day');
        --месяц
        SELECT * FROM CallEvents WHERE strftime('%Y-%m', CallTime) = strftime('%Y-%m', 'now');
        --день
        --SELECT * FROM CallEvents WHERE date(CallTime) = date('now');
         */
    }
}
