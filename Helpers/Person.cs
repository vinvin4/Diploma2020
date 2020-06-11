using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma2020.Helpers
{
    public class Person
    {
        private string fullName = null;
        public string FullName
        {
            get => fullName;
            set
            {
                simpleName = null;
                fullName = value;
            }
        }

        private string simpleName = null;
        public string SimpleName
        {
            get
            {                
                if (!string.IsNullOrEmpty(fullName) && string.IsNullOrEmpty(simpleName))
                {
                    string[] name = FullName.Split(' ');
                    simpleName = string.Join(" ", name[0], name[1].Substring(0, 1) + ".", name[2].Substring(0, 1) + ".");
                }
                return simpleName;
            }
        }
        public string AdditionalInformation;

        public Person()
        {
            this.FullName = string.Empty;
        }

        /// <summary>
        /// Create new person
        /// </summary>
        /// <param name="Name"></param>
        public Person(string Name)
        {
            this.FullName = Name;
        }

        /// <summary>
        /// To Be Extended
        /// </summary>
        public virtual void FillAddInfo()
        {

        }

        /// <summary>
        /// To Be Extended
        /// </summary>
        public virtual void GetAddInfo()
        {

        }
    }
}
