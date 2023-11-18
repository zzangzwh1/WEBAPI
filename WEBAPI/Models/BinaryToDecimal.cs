using System.Text;

namespace WEBAPI.Models
{
    public class BinaryToDecimal
    {
       // public string Binary { get; set; } = string.Empty;
     
        public int BinaryToDec(string binary)
        {
            int decimalNumber = 0;
            int power = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    decimalNumber += (int)Math.Pow(2, power);
                }

                if (binary[i] != '1' && binary[i] != '0')
                {
                    decimalNumber = -1;
                }

                power++;
            }

            return decimalNumber;
        }
    }
}
