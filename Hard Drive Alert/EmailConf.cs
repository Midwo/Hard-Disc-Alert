using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_Drive_Alert
{
    class EmailConf
    {

        public static ArrayList ListEmail;
        private string stringList;

        public string StringListEmail()
        {
            if (ListEmail != null)
            {
                foreach (var item in ListEmail)
                {
                    stringList += item + ",";
                }
                stringList = stringList.Substring(0, stringList.Length - 1);
            }
           
            return stringList;
        }

      
    }
    
}
