using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectCodeLibrary
{
    public class CorrectCodeClass
    {
        /// <summary>
        /// Метод выполняет  проверку правильности  заполнения текстового поля (будет проверять является ли переданная строка является правильным “кодом”.).
        /// </summary>
        /// <param name="candidate">Метод принимает в качестве параметра строку. </param>
        /// <returns>Метод возвращает true, если входная строка соответствует условиям</returns>
        /// 
        public static bool IsCorrectCode(string candidate)
        {
            if(candidate.Length != 10 || string.IsNullOrEmpty(candidate))
            {
                return false;
            }

            for (int i = 0; i < candidate.Length; i++)
            {
                if (Char.IsDigit(candidate[i]) == false)
                {
                    return false;
                }
            }

            int sum = 0;
            
            for (int i = 0;i < candidate.Length - 1;i++)
            {
                sum += (int)Char.GetNumericValue(candidate[i]);
            }

            int lastNumber = (int)Char.GetNumericValue(candidate[candidate.Length-1]);
            int code = 0;

            if(sum % 10 == 0)
            {
                code = 0;

                if(code == lastNumber)
                {
                    return true;
                }
                return false;
            }

            if (sum % 3 == 0)
            {
                code = 1;

                if (code == lastNumber)
                {
                    return true;
                }
                return false;
            }

            
            code = 9;

            if (code == lastNumber)
            {
                    return true;
            }

            return false;
            

            
        }
    }
}
