using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class Class1
    {
       public static int GetCheck(string a)
        {     
            if(string.IsNullOrEmpty(a)) 
            {
                return 0;
            }
            int result = 0;

            if(Regex.Match(a, @"^(\+7|8)\d{10}$").Success) //номер телефона
            {
               result++;
            }

            if(Regex.Match(a, @"^([1-9])\d{5}$").Success) //индекс
            {
               result++;
            }

            if(Regex.Match(a, @"^[А-Я]([а-я])+(\-)?([А-Я]([а-я])+)*$").Success) //город
            {
              result++;
            }

            if(Regex.Match(a, @"^[А-Я]([а-я]+)(((\-)[А-Я]([а-я]+))|(\s([а-я]+)\s[А-Я]([а-я]+))?)$").Success) //фамилия
            {
              result++;
            }
             
            if(Regex.Match(a, @"^\d{3}(\-)\d{3}(\-)\d{3}\s\d{2}$").Success)//снилс
            {
               result++;
            }

            return result;
        }

    }
}
