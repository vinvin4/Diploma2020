using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Threading;

namespace Diploma2020.Helpers
{
    class Database
    {
        #region Constants
        private string dbName = AppConstants.DBFile;
        public static string teacherTable = "Teachers";
        public static string pupilTable = "Pupils";
        public static string subjectTable = "Subjects";
        public static string olympicTable = "COoP";
        public static string activitiesTable = "Activities";

        private static Database instance = null;
        private SQLiteConnection dbConn = null;
        private List<string> TeachersDBPoint = new List<string>()
        {
            "Name", "IsAdmin", "ConnClass", "Info"
        };

        private List<string> PupilsDBPoint = new List<string>()
        {
            "Name", "ClassName", "Info"
        };

        private List<string> SubjectsDBPoint = new List<string>()
        {
            "ClassName", "Info"
        };

        private List<string> OlympicDBPoint = new List<string>()
        {
            "TeacherName", "Info"
        };

        private List<string> ActivitiesDBPoint = new List<string>()
        {
            "TeacherName", "ActivityName", "Info"
        };
        #endregion

        #region Helpers
        /// <summary>
        /// Initialise Instance of Database file
        /// </summary>
        private Database()
        {
            string filePath = string.Join(@"\", AppConstants.DiskToDocs,
                AppConstants.ProjectDirectory, AppConstants.CustomFilesDirectory);
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath = string.Join(@"\", filePath, dbName);
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            try
            {
                dbConn = new SQLiteConnection("Data Source=" + filePath + ";Version=3;");
                dbConn.Open();
            }
            catch
            {
                dbConn = null;
                instance = null;
            }
        }

        /// <summary>
        /// Return instance to work
        /// </summary>
        /// <returns></returns>
        public static Database getInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        /// <summary>
        /// Support function to write in DB data
        /// </summary>
        /// <param name="pointName">Name of point in db</param>
        /// <returns></returns>
        private string SQLHelper(string pointName)
        {
            return $", {pointName} TEXT";
        }

        /// <summary>
        /// Support function to close connection
        /// </summary>
        public static void CloseCon()
        {
            instance?.dbConn?.Close();
            instance = null;
        }
        #endregion

        #region Registration
        /// <summary>
        /// Command to write tearcher's data into the DB
        /// </summary>
        /// <param name="tmList">List with all teachers information</param>
        public async Task WriteTeachers(List<Teacher> tmList)
        {
            var sqlCmd = new SQLiteCommand();
            sqlCmd.Connection = dbConn;
            string command = string.Join("",
                TeachersDBPoint.Select(item => SQLHelper(item)).ToList());
            sqlCmd.CommandText = $"CREATE TABLE IF NOT EXISTS {teacherTable} (id INTEGER PRIMARY KEY AUTOINCREMENT{command})";
            sqlCmd.ExecuteNonQuery();

            await Task.Run(() =>
            {
                foreach (var item in tmList)
                {
                    string formatedPoints = string.Join(", ",
                        TeachersDBPoint.Select(itemList => $"'{itemList}'").ToList());
                    string formatedValue = string.Format("'{0}', '{1}', '{2}', '{3}'",
                        item.FullName, item.IsAdmin ? "1" : "0",
                        item.Class, item.AdditionalInformation);
                    sqlCmd.CommandText = $"INSERT INTO {teacherTable} ({formatedPoints}) values " +
                        $"({formatedValue})";
                    sqlCmd.ExecuteNonQuery();
                }
            });
        }

        /// <summary>
        /// Command to write pupil's data into the DB
        /// </summary>
        /// <param name="classes">All pupils info</param>
        /// <returns></returns>
        public async Task WriteClasses(List<Pupil> classes)
        {
            var sqlCmd = new SQLiteCommand();
            sqlCmd.Connection = dbConn;
            string command = string.Join("",
                PupilsDBPoint.Select(item => SQLHelper(item)).ToList());
            sqlCmd.CommandText = $"CREATE TABLE IF NOT EXISTS {pupilTable} (id INTEGER PRIMARY KEY AUTOINCREMENT{command})";
            sqlCmd.ExecuteNonQuery();

            string formatedPoints = string.Join(", ",
                        PupilsDBPoint.Select(itemList => $"'{itemList}'").ToList());

            await Task.Run(() =>
            {
                foreach (var pupil in classes)
                {
                    string formatedValue = string.Format("'{0}', '{1}', '{2}'",
                        pupil.FullName, pupil.Class, pupil.AdditionalInformation);
                    sqlCmd.CommandText = $"INSERT INTO {pupilTable} ({formatedPoints}) values " +
                        $"({formatedValue})";
                    sqlCmd.ExecuteNonQuery();
                }
            });
        }

        /// <summary>
        /// Command to write subject's data into the DB
        /// </summary>
        /// <param name="subjects"></param>
        /// <returns></returns>
        public async Task WriteSubject(Dictionary<string, string> subjects)
        {
            var sqlCmd = new SQLiteCommand();
            sqlCmd.Connection = dbConn;
            string command = string.Join("",
                SubjectsDBPoint.Select(item => SQLHelper(item)).ToList());
            sqlCmd.CommandText = $"CREATE TABLE IF NOT EXISTS {subjectTable} (id INTEGER PRIMARY KEY AUTOINCREMENT{command})";
            sqlCmd.ExecuteNonQuery();

            string formatedPoints = string.Join(", ",
                        SubjectsDBPoint.Select(itemList => $"'{itemList}'").ToList());

            await Task.Run(() =>
            {
                foreach (var item in subjects)
                {
                    string formatedValue = string.Format("'{0}', '{1}'",
                        item.Key, item.Value);
                    sqlCmd.CommandText = $"INSERT INTO {subjectTable} ({formatedPoints}) values " +
                        $"({formatedValue})";
                    sqlCmd.ExecuteNonQuery();
                }
            });
        }
        #endregion

        /// <summary>
        /// Read info about Teachers
        /// </summary>
        /// <returns></returns>
        public async Task ReadTeachers()
        {
            var sqlCmd = new SQLiteCommand($"SELECT * FROM {teacherTable}");
            sqlCmd.Connection = dbConn;

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            await Task.Run(() =>
            {
                while(reader.Read())
                {
                    Teacher teacher = new Teacher(reader.GetString(reader.GetOrdinal("Name")));
                    teacher.AdditionalInformation = reader.GetString(reader.GetOrdinal("Info"));
                    teacher.Class = reader.GetString(reader.GetOrdinal("ConnClass"));
                    teacher.IsAdmin = reader.GetString(reader.GetOrdinal("IsAdmin")) == "1";

                    AppConstants.teacs.Add(teacher);
                }                
            });
        }

        /// <summary>
        /// Read info about Subjects
        /// </summary>
        /// <returns></returns>
        public async Task ReadSubjects()
        {
            var sqlCmd = new SQLiteCommand($"SELECT * FROM {subjectTable}");
            sqlCmd.Connection = dbConn;

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            await Task.Run(() =>
            {
                Dictionary<string, string> subjs = new Dictionary<string, string>();
                while (reader.Read())
                {
                    subjs.Add(reader.GetString(reader.GetOrdinal("ClassName")),
                        reader.GetString(reader.GetOrdinal("Info")));

                    AppConstants.AvailableSubjects = subjs;
                }
            });
        }

        /// <summary>
        /// Read info about Concrete class
        /// </summary>
        /// <returns></returns>
        public async Task ReadClass(string ClassName)
        {
            var sqlCmd = new SQLiteCommand($"SELECT * FROM {pupilTable} WHERE ClassName = {ClassName}");
            sqlCmd.Connection = dbConn;

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            await Task.Run(() =>
            {
                while (reader.Read())
                {
                    Pupil pupil = new Pupil(reader.GetString(reader.GetOrdinal("Name")));
                    pupil.AdditionalInformation = reader.GetString(reader.GetOrdinal("Info"));
                    pupil.Class = reader.GetString(reader.GetOrdinal("ClassName"));

                    AppConstants.pupils.Add(pupil);
                }
            });
        }

        /// <summary>
        /// Read info about all pupils
        /// </summary>
        /// <returns></returns>
        public async Task ReadClass()
        {
            var sqlCmd = new SQLiteCommand($"SELECT * FROM {pupilTable}");
            sqlCmd.Connection = dbConn;

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            await Task.Run(() =>
            {
                while (reader.Read())
                {
                    Pupil pupil = new Pupil(reader.GetString(reader.GetOrdinal("Name")));
                    pupil.AdditionalInformation = reader.GetString(reader.GetOrdinal("Info"));
                    pupil.Class = reader.GetString(reader.GetOrdinal("ClassName"));

                    AppConstants.pupils.Add(pupil);
                }
            });
        }

        #region OlympicProcess
        /// <summary>
        /// Command to write subject's data into the DB
        /// </summary>
        /// <param name="subjects"></param>
        /// <returns></returns>
        public async Task WriteOlympic(string TeacherName, string Result, bool IsAlreadyWritten = false)
        {
            var sqlCmd = new SQLiteCommand();
            sqlCmd.Connection = dbConn;
            string command = string.Join("",
                OlympicDBPoint.Select(item => SQLHelper(item)).ToList());
            sqlCmd.CommandText = $"CREATE TABLE IF NOT EXISTS {olympicTable} (id INTEGER PRIMARY KEY AUTOINCREMENT{command})";
            sqlCmd.ExecuteNonQuery();

            string formatedPoints = string.Join(", ",
                        OlympicDBPoint.Select(itemList => $"'{itemList}'").ToList());

            await Task.Run(() =>
            {
                if (IsAlreadyWritten)
                {
                    sqlCmd.CommandText = $@"UPDATE {olympicTable} SET 'Info' = '{Result}' WHERE [TeacherName] = '{TeacherName}'";
                }
                else
                {
                    string formatedValue = string.Format("'{0}', '{1}'",
                            TeacherName, Result);
                    sqlCmd.CommandText = $"INSERT INTO {olympicTable} ({formatedPoints}) values ({formatedValue})";
                }
                sqlCmd.ExecuteNonQuery();
                
            });
        }

        /// <summary>
        /// Read info about all pupils
        /// </summary>
        /// <returns></returns>
        public async Task<string> ReadTeacherOlympic(string TeacherName)
        {
            var sqlCmd = new SQLiteCommand($"SELECT * FROM {olympicTable} WHERE TeacherName = '{TeacherName}'");
            sqlCmd.Connection = dbConn;

            string result = string.Empty;
            try
            {
                SQLiteDataReader reader = sqlCmd.ExecuteReader();

                await Task.Run(() =>
                {
                    while (reader.Read())
                    {
                        result = reader.GetString(reader.GetOrdinal("Info"));
                    }
                });
            }
            catch (Exception ex)
            {
                //Do Nothing
            }
            return result;
        }

        /// <summary>
        /// Read all info about olympic
        /// </summary>
        /// <returns></returns>
        public async Task<Dictionary<string, string>> ReadOlympic()
        {
            var sqlCmd = new SQLiteCommand($"SELECT * FROM {olympicTable}");
            sqlCmd.Connection = dbConn;

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            Dictionary<string, string> dict = new Dictionary<string, string>();
            await Task.Run(() =>
            {
                while (reader.Read())
                {
                    string TeacherName = reader.GetString(reader.GetOrdinal("TeacherName"));
                    string Info = reader.GetString(reader.GetOrdinal("Info"));
                    try
                    {
                        dict.Add(TeacherName, Info);
                    }
                    catch(Exception ex)
                    {
                        dict[TeacherName] = Info;
                    }
                }
            });
            return dict;
        }
        #endregion

        #region YearActivities
        /// <summary>
        /// Command to write subject's data into the DB
        /// </summary>
        /// <param name="subjects"></param>
        /// <returns></returns>
        public async Task WriteActivity(string TeacherName, string ActivityName, string Result)
        {
            var sqlCmd = new SQLiteCommand();
            sqlCmd.Connection = dbConn;
            string command = string.Join("",
                ActivitiesDBPoint.Select(item => SQLHelper(item)).ToList());
            sqlCmd.CommandText = $"CREATE TABLE IF NOT EXISTS {activitiesTable} (id INTEGER PRIMARY KEY AUTOINCREMENT{command})";
            sqlCmd.ExecuteNonQuery();

            string formatedPoints = string.Join(", ",
                        ActivitiesDBPoint.Select(itemList => $"'{itemList}'").ToList());

            await Task.Run(() =>
            {
                string formatedValue = string.Format("'{0}', '{1}', '{2}'",
                        TeacherName, ActivityName, Result);
                sqlCmd.CommandText = $"INSERT INTO {activitiesTable} ({formatedPoints}) values ({formatedValue})";
                sqlCmd.ExecuteNonQuery();
            });
        }

        /// <summary>
        /// Command to write subject's data into the DB
        /// </summary>
        /// <param name="subjects"></param>
        /// <returns></returns>
        public async Task UpdateActivity(string TeacherName, string ActivityName, string Result)
        {
            var sqlCmd = new SQLiteCommand();
            sqlCmd.Connection = dbConn;

            await Task.Run(() =>
            {
                sqlCmd.CommandText = $@"UPDATE {activitiesTable} SET 'Info' = '{Result}' WHERE [TeacherName] = '{TeacherName}' AND [ActivityName] = '{ActivityName}'" ;
                sqlCmd.ExecuteNonQuery();
            });
        }

        /// <summary>
        /// Command to write subject's data into the DB
        /// </summary>
        /// <param name="subjects"></param>
        /// <returns></returns>
        public async Task<Dictionary<string, string>> ReadActivity(string TeacherName)
        {
            var sqlCmd = new SQLiteCommand($"SELECT * FROM {activitiesTable} WHERE TeacherName = '{TeacherName}'");
            sqlCmd.Connection = dbConn;

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            Dictionary<string, string> dict = new Dictionary<string, string>();
            await Task.Run(() =>
            {
                while (reader.Read())
                {
                    string ActivityName = reader.GetString(reader.GetOrdinal("ActivityName"));
                    string Info = reader.GetString(reader.GetOrdinal("Info"));
                    dict.Add(ActivityName, Info);
                }
            });
            return dict;
        }

        /// <summary>
        /// Command to write subject's data into the DB
        /// </summary>
        /// <param name="subjects"></param>
        /// <returns></returns>
        public async Task<List<Tuple<string, Tuple<string, string>>>> ReadActivity()
        {
            var sqlCmd = new SQLiteCommand($"SELECT * FROM {activitiesTable}");
            sqlCmd.Connection = dbConn;

            SQLiteDataReader reader = sqlCmd.ExecuteReader();

            List<Tuple<string, Tuple<string, string>>> dict = new List<Tuple<string, Tuple<string, string>>>();
            await Task.Run(() =>
            {
                while (reader.Read())
                {
                    string Teacher = reader.GetString(reader.GetOrdinal("TeacherName"));
                    string ActivityName = reader.GetString(reader.GetOrdinal("ActivityName"));
                    string Info = reader.GetString(reader.GetOrdinal("Info"));
                    dict.Add(new Tuple<string, Tuple<string, string>>(Teacher,
                        new Tuple<string, string>(ActivityName, Info)));
                }
            });
            return dict;
        }
        #endregion

    }
}
