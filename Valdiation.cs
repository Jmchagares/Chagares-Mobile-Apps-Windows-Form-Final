using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    class Validate
    {
        public Validate() { }

        public bool canBePositiveInt(String s)
        {
            //verify that each char in the string is a digit
            //it is OK if the first char is a plus sign

            for (int n = 0; n < s.Length; n++)
            {
                if (n == 0 && s[n] == '+')
                    continue;

                if (s[n] < '0' || s[n] > '9')
                    return false;
            }

            if (Convert.ToDouble(s) > int.MaxValue)
                return false;

            return true;
        }//end canBePositiveInt()

        public bool canBeInt(String s)
        {
            //verify that each char in the string is a digit
            //it is OK if the first char is a plus sign or a minus sign

            for (int n = 0; n < s.Length; n++)
            {
                if (n == 0 && (s[n] == '+' || s[n] == '-'))
                    continue;

                if (s[n] < '0' || s[n] > '9')
                    return false;
            }

            if (Convert.ToDouble(s) > int.MaxValue || Convert.ToDouble(s) < int.MinValue)
                return false;

            return true;
        }//end canBeInt()

        public bool canBePositiveDouble(String s)
        {
            //verify that each char in the string is a digit
            //it is OK if the first char is a plus sign
            //it is OK if the string contains only one decimal point
            //the decimal point cannot come before a sign

            bool foundDecimalPoint = false;

            //loop through every char in s
            for (int n = 0; n < s.Length; n++)
            {
                //if no decimal has been found and you find a decimal
                if (!foundDecimalPoint && s[n] == '.')
                {
                    //toggle foundDecimalPoint so this code can never execute again
                    foundDecimalPoint = true;
                    continue;//do not process this char any further
                }

                //allow a plus sign if it is in position [0]
                if (n == 0 && s[n] == '+')
                    continue;//do not process this char any further

                //return false if the char is not a digit
                if (s[n] < '0' || s[n] > '9')
                    return false;
            }

            return true;
        }//end canBePositiveDouble()

        public bool canBeDouble(String s)
        {
            //verify that each char in the string is a digit
            //it is OK if the first char is a plus sign
            //it is OK if the string contains only one decimal point
            //the decimal point cannot come before a sign

            bool foundDecimalPoint = false;

            //loop through every char in s
            for (int n = 0; n < s.Length; n++)
            {
                //if no decimal has been found and you find a decimal
                if (!foundDecimalPoint && s[n] == '.')
                {
                    //toggle foundDecimalPoint so this code can never execute again
                    foundDecimalPoint = true;
                    continue;//do not process this char any further
                }

                //allow a plus sign if it is in position [0]
                if (n == 0 && (s[n] == '+' || s[n] == '-'))
                    continue;//do not process this char any further

                //return false if the char is not a digit
                if (s[n] < '0' || s[n] > '9')
                    return false;
            }

            return true;
        }//end canBeDouble()
    }
}
