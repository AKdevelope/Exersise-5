using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exersise_5
{
    public class ValidateUserinput
    {
        public string Input;
        public bool Checkinput(string PathFile)
        {
            if (File.Exists(PathFile) == true)
            {
               return true;
            }
 
            else
            {
                return false;
            }

        }

    }
}
