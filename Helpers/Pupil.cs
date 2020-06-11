using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma2020.Helpers
{
    public class Pupil : Person
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
                addInfo = JsonConvert.DeserializeObject<PupilAddInfo>(AdditionalInformation);
            }
            catch (Exception ex)
            {
                Console.WriteLine(typeof(PupilAddInfo).Name + " :GetAddInfo: " + ex.Message);
                addInfo = new PupilAddInfo();
            }
        }

        public Pupil() : base()
        {

        }
        public Pupil(string Name) : base(Name)
        {

        }
        #endregion

        public string Class = null;
        private PupilAddInfo addInfo = null;
        public PupilAddInfo AddInfo
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
                        addInfo = new PupilAddInfo();
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
