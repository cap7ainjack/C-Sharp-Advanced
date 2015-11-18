using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_in_class
{

    
        public static class Extensions
        {
            public static string substring(this StringBuilder sb, int startIndex, int count)
        {
                StringBuilder substring = new StringBuilder();
                for (int i = 0; i <= count; i++)
                {
                    substring.Append(sb[startIndex+i]);
                }

                string output = substring.ToString();
                return output;

        }

    }
       
    }

