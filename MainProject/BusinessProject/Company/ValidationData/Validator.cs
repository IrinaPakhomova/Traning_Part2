using System;
using System.Collections.Generic;
using System.Text;

namespace Company.ValidationData
{
   public static class Validator
    {
        public static bool isCorrectStringData(object value, int min_length_data)
        {
            if (value != null)
            {
                string data = value.ToString().Trim();
                if (data.Length >= min_length_data)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public static bool isCorrectIntegerData(object value, int min_restriction)
        {
            if (value != null)
            {
                bool check = int.TryParse(value.ToString(), out int numData);
                if (check && numData >= min_restriction)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public static bool isCorrectIntegerData(object value, int min_restriction, int max_restriction)
        {
            if (value != null)
            {
                bool check = int.TryParse(value.ToString(), out int numData);
                if (check && numData >= min_restriction && numData <= max_restriction)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public static bool isCorrectDecimalData(object value, decimal min_restriction)
        {
            if (value != null)
            {
                bool check = decimal.TryParse(value.ToString(), out decimal numData);
                Console.WriteLine(numData);
                if (check && numData >= min_restriction)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public static bool isCorrectDecimalData(object value, decimal min_restriction, decimal max_restriction)
        {
            if (value != null)
            {
                bool check = decimal.TryParse(value.ToString(), out decimal numData);
                if (check && numData >= min_restriction && numData <= max_restriction)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
