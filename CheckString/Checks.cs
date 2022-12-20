using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckString
{
    internal class Checks
    {
        public bool Alphanumeric(string word)
        {
            List<int> ints = new List<int>();
            if(word==""|| string.IsNullOrEmpty(word))
            {
                return false;
            }
            char[] chars = word.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                if (char.IsSeparator(chars[i])||char.IsSymbol(chars[i])|| char.IsPunctuation(chars[i]))
                {
                    return false;
                }                
                if (char.IsNumber(chars[i]))
                {                    
                    int temp= Convert.ToInt32(chars[i].ToString());                    
                    ints.Add(temp);
                    string combinedString = string.Join("", ints);
                    bool fka = int.TryParse(combinedString, out var fkajsf);
                    if (fkajsf < 0 || fkajsf > 9)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
