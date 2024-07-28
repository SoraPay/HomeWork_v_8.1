using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public enum Gender { men, women }
    public class FamilyMebers
    {
        public Gender gender { get; set; }

        public int Age { get; set; }

        public string FullName { get; set; }

        public FamilyMebers Mother { get; set; }

        public FamilyMebers Father { get; set; }

        public FamilyMebers Wife { get; set; }

        public FamilyMebers Husband { get; set; }

        public FamilyMebers[] Grandmother()
        {
            return new FamilyMebers[] { Mother?.Mother, Father?.Mother };
        }
        public FamilyMebers[] Grandfather()
        {
            return new FamilyMebers[] { Mother?.Father, Father?.Father };
        }


    }
}
