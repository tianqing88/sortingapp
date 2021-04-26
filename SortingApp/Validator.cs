using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingApp
{
    public class Validator
    {
        public bool IsValidName(List<string> nameList)
        {
            if(nameList.Any(o => o.Trim().Split(" ").Length < 2 || o.Trim().Split(" ").Length > 4))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
