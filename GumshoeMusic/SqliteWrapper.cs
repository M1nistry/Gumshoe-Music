using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace GumshoeMusic
{
    class SqliteWrapper
    {
        private readonly string _constring;
        private readonly string _dbFile;        

        public SqliteWrapper()
        {
            
            _dbFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\GumshoeMusic\MusicDB.sqlite";
            _constring = @"Data Source=" + _dbFile + @";Version=3";
            Setup();
        }

        public void Setup()
        {
            if (!File.Exists(_dbFile))
            {
                Directory.CreateDirectory(Directory.GetParent(_dbFile).ToString());
                SQLiteConnection.CreateFile(_dbFile);
            }
            try
            {
                using (var connection = new SQLiteConnection(_constring))
                {
                    const string createQuery = @"CREATE TABLE IF NOT EXISTS `directories` 
                    (`id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `title` TEXT NOT NULL UNIQUE, `song_count` INTEGER)";
                    connection.Open();
                    using (var cmd = new SQLiteCommand(createQuery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #region Generic SQL Methods

        /// <summary> Allows the programmer to interact with the database for purposes other than a query. </summary>
        /// <param name="sql">The SQL to be run.</param>
        /// <returns>An Integer containing the number of rows updated.</returns>
        public int ExecuteNonQuery(string sql)
        {
            using (var cnn = new SQLiteConnection(_constring))
            {
                cnn.Open();
                using (var cmd = new SQLiteCommand(cnn))
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary> Allows the programmer to retrieve single items from the DB. </summary>
        /// <param name="sql">The query to run.</param>
        /// <returns>A string</returns>
        public string ExecuteScalar(string sql)
        {
            using (var cnn = new SQLiteConnection(_constring))
            { 
                cnn.Open();
                using (var cmd = new SQLiteCommand(cnn))
                {
                    cmd.CommandText = sql;
                    var value = cmd.ExecuteScalar();
                    return value != null ? value.ToString() : "";
                }
            }
        }

        /// <summary> Allows the programmer to easily insert into the DB </summary>
        /// <param name="tableName">The table into which we insert the data.</param>
        /// <param name="data">A dictionary containing the column names and data for the insert.</param>
        /// <returns>Result as boolean</returns>
        public bool Insert(String tableName, Dictionary<String, String> data)
        {
            var columns = "";
            var values = "";
            var returnCode = true;
            foreach (var val in data)
            {
                columns += String.Format(" {0},", val.Key);
                values += String.Format(" '{0}',", val.Value);
            }
            columns = columns.Substring(0, columns.Length - 1);
            values = values.Substring(0, values.Length - 1);
            try
            {
                ExecuteNonQuery(String.Format("INSERT INTO {0}({1}) VALUESs({2});", tableName, columns, values));
            }
            catch (Exception fail)
            {
                //TODO: Error handling method/solution
                returnCode = false;
            }
            return returnCode;
        }

        /// <summary> Allows the programmer to easily update rows in the DB. </summary>
        /// <param name="tableName">The table to update.</param>
        /// <param name="data">A dictionary containing column names and their new values.</param>
        /// <param name="where">The where clause for the update statement.</param>
        /// <returns>Result as boolean</returns>
        public bool Update(String tableName, Dictionary<String, String> data, String where)
        {
            var vals = "";
            var returnCode = true;
            if (data.Count >= 1)
            {
                vals = data.Aggregate(vals, (current, val) => current + String.Format(" {0} = '{1}',", val.Key, val.Value));
                vals = vals.Substring(0, vals.Length - 1);
            }
            try
            {
                ExecuteNonQuery(String.Format("UPDATE {0} SET {1} WHERE {2};", tableName, vals, where));
            }
            catch
            {
                //TODO: Error handling method/solution
                returnCode = false;
            }
            return returnCode;
        }

        /// <summary> Allows the programmer to easily delete rows from the DB. </summary>
        /// <param name="tableName">The table from which to delete.</param>
        /// <param name="where">The where clause for the delete.</param>
        /// <returns>Result as boolean</returns>
        public bool Delete(String tableName, String where)
        {
            var returnCode = true;
            try
            {
                ExecuteNonQuery(String.Format("DELETE FROM {0} WHERE {1};", tableName, where));
            }
            catch (Exception fail)
            {
                //TODO: Error handling method/solution
                returnCode = false;
            }
            return returnCode;
        }

        /// <summary> Allows the user to easily clear all data from a specific table. </summary>
        /// <param name="table">The name of the table to clear.</param>
        /// <returns>Result as Boolean</returns>
        public bool ClearTable(String table)
        {
            try
            {
                ExecuteNonQuery(String.Format("DELETE FROM {0};", table));
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Custom SQL Methods

        //public int InsertDevice(string deviceSerial)
        //{
        //    using (var connection = new SQLiteConnection(_constring))
        //    {
        //        const string deviceCommand = @"INSERT INTO `Devices` (device_serial) VALUES(@serial)";
        //        connection.Open();
        //        try
        //        {
        //            using (var cmd = new SQLiteCommand(deviceCommand, connection))
        //            {
        //                cmd.Parameters.AddWithValue("@serial", deviceSerial);
        //                cmd.ExecuteScalar();
        //                var rowId = connection.LastInsertRowId;
        //                connection.Close();
        //                return (int)rowId;
        //            }
        //        }
        //        catch (SQLiteException ex)
        //        {
        //            //TODO: Error Handling
        //            return -1;
        //        }
        //    }
        //}

        public int CreateDirectory(string title)
        {
            try
            {
                using (var connection = new SQLiteConnection(_constring))
                {
                    const string directoryCreate = @"INSERT OR IGNORE INTO `directories` (title) VALUES (@title);";
                    connection.Open();

                    using (var cmd = new SQLiteCommand(directoryCreate, connection))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.ExecuteNonQuery();
                        var rowId = connection.LastInsertRowId;
                        return (int) rowId;

                    }
                }
            }
            catch (SQLiteException ex)
            {

                return -1;
            }
        }

        public int FetchDirectory(string title)
        {
            try
            {
                using (var connection = new SQLiteConnection(_constring))
                {
                    const string directoryFetch = @"SELECT id FROM `directories` WHERE title=@title";
                    connection.Open();

                    using (var cmd = new SQLiteCommand(directoryFetch, connection))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        var directoryId = cmd.ExecuteScalar();
                        return int.Parse(directoryId.ToString());

                    }
                }
            }
            catch (SQLiteException ex)
            {

                return -1;
            }
        }
        #endregion

        public string _ConString(SQLiteConnectionStringBuilder ConString)
        {
            return ConString.ToString();
        }
    }
}
