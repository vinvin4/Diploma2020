using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Res = Diploma2020.Properties.Resources;

namespace Diploma2020.Helpers
{
    class AppConstants
    {
        //Working constants
        private static List<string> cList = null;
        public static List<string> AvailableClassesList
        {
            get => cList;
            set => cList = value;
        }

        public static List<string> columnsTeacherList = new List<string>()
        {
            Res.BirthdayLbl, Res.AddressLbl, Res.PassportLbl, Res.SNILSLbl, Res.INNLbl,
                Res.AccountLbl, Res.BankAccountLbl, Res.PhoneLbl
        };

        public static List<string> columnsPupilList = new List<string>()
        {
            Res.BirthdayLbl, Res.AddressLbl, Res.PupilSexLbl
        };

        private static Dictionary<string, string> subject = null;
        public static Dictionary<string, string> AvailableSubjects
        {
            get => subject;
            set => subject = value;
        }

        private static Teacher currUser = null;
        public static Teacher CurrentUser
        {
            get => currUser;
            set => currUser = value;
        }

        public static List<Teacher> teacs = new List<Teacher>();
        public static List<Pupil> pupils = new List<Pupil>();

        public static string DiskToDocs = "D:";
        public static string ProjectDirectory = "Diploma2020";
        public static string TeachersFile = "TeacherList.doc";
        public static string PupilsList = "PupilList.doc";

        public static string ActivitiesFile = "Activities.doc";
        public static string ActivityDirectory = "Activities";
        public static string FiltersFile = "Filters.doc";
        public static string FiltersDirectory = "Filters";
        public static string ClassDataFile = "ClassData.doc";
        public static string ClassDataDirectory = "ClassData";
        public static string OlympicDirectory = "Olypics";
        public static string CustomFilesDirectory = "CustomData";
        public static string DBFile = "AppDB.mdb";
        public static string RegistationCompleted = "RegisterCompleted.txt";
    }
}
