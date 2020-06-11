using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma2020.Helpers
{
    public class Teacher : Person
    {
        #region Overridable
        public override void FillAddInfo()
        {
            base.FillAddInfo();
            AdditionalInformation = JsonConvert.SerializeObject(addInfo);
        }

        public override void GetAddInfo()
        {
            base.GetAddInfo();
            try
            {
                addInfo = JsonConvert.DeserializeObject<TeacherAddInfo>(AdditionalInformation);
            }
            catch (Exception ex)
            {
                Console.WriteLine(typeof(Teacher).Name + " :GetAddInfo: " + ex.Message);
                addInfo = new TeacherAddInfo();
            }
        }

        public Teacher() : base()
        {

        }
        public Teacher(string Name) : base(Name)
        {

        }
        #endregion

        public string Class = string.Empty;
        public bool IsAdmin = false;
        private List<string> respSubjects = null;
        public List<string> RespSubjects
        {
            get
            {
                if (respSubjects == null)
                {
                    if (string.IsNullOrEmpty(Class))
                    {
                        respSubjects = new List<string>();
                    }
                    else
                    {
                        respSubjects = AppConstants.AvailableSubjects[Class.Substring(0, Class.Length - 1)]
                                .Split(';')
                                .ToList();
                    }
                }                
                return respSubjects;
            }
        }

        public List<Pupil> ClassList
        {
            get
            {
                return AppConstants.pupils.Where(item => item.Class == Class).ToList();
            }
        }

        private TeacherAddInfo addInfo = null;
        public TeacherAddInfo AddInfo
        {
            get
            {
                if (addInfo == null)
                {
                    if (!string.IsNullOrEmpty(AdditionalInformation))
                    {
                        GetAddInfo();
                    }
                    else
                    {
                        addInfo = new TeacherAddInfo();
                    }
                }
                return addInfo;
            }
            set
            {
                addInfo = value;
                FillAddInfo();
            }
        }
    }
}
