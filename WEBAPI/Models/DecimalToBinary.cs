using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WEBAPI.Models
{
    public class DecimalToBinary
    {
        public int Number { get; set; }
        //1 2 3 4 5 6/7
        public string DecimalTOBina(int number)
        {
            string Result = string.Empty;
            while (number > 0)
            {
                Result = number % 2 + Result;
                number = number / 2;
            }
            return Result;
        }

     
    }
}
