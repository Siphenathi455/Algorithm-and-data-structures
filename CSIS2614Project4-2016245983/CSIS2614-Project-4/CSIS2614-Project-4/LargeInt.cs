using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS2614_Project_4
{
    class LargeInt
    {
        private string largeInt;
        private string largeInt2;
        int n = 1;
        int m = 0;
        public LargeInt(string _largeInt)
        {
            if( n % 2 == 0)
            largeInt2 = _largeInt;
            else
            largeInt = _largeInt;
            n++;
        }
        public override string ToString()
        {
            if (m >= 2)
            {
                int j = largeInt.Length;
                if (largeInt.Length < largeInt2.Length)
                    j = largeInt2.Length;
                while (largeInt.Length != largeInt2.Length)
                {
                    if (j != largeInt.Length)
                        largeInt = "0" + largeInt;
                    else
                        largeInt2 = "0" + largeInt2;
                }
            }
            m++;
             if (m % 2 == 0)
            return  largeInt2;
            else
              return  largeInt;
           
        }

        public static LargeInt operator +(LargeInt _largeNumber1, LargeInt _largeNumber2)
        {
            string largeNumber1 = _largeNumber1.ToString();
            string largeNumber2 = _largeNumber2.ToString();

            int length = Math.Max(largeNumber1.Length, largeNumber2.Length);
            largeNumber1 = largeNumber1.PadLeft(length, '0');
            largeNumber2 = largeNumber2.PadLeft(length, '0');

            //Convert number1 to char[] with ones in chars[0]
            char[] chars = largeNumber1.ToCharArray();
            Array.Reverse(chars);
            largeNumber1 = new string(chars);

            //Convert number2 to char[]
            chars = largeNumber2.ToCharArray();
            Array.Reverse(chars);
            largeNumber2 = new string(chars);

            //Step through digits
            string sSum = "";
            int carryOver = 0;
            for (int c = 0; c < length; c++)
            {
                if (c > 0) 
                    carryOver = (carryOver + int.Parse(largeNumber1[c - 1].ToString()) + int.Parse(largeNumber2[c - 1].ToString())) / 10;
                int currentSum = int.Parse(largeNumber1[c].ToString()) + int.Parse(largeNumber2[c].ToString());
                int thisDigit = (carryOver + currentSum) % 10;
                sSum = thisDigit + sSum; 
            } 

            //Last carry over
            sSum = carryOver.ToString() + sSum;
            char[] chSum = sSum.ToCharArray();
            Array.Reverse(chSum);
         
            sSum = "";
            for (int i = 0; i < chSum.Length; i++)
            {
                if ( i % 3 == 0 && i != 0 )
                    sSum += "," + chSum[i] ;
                else
                    sSum += chSum[i];
            }
            chSum = sSum.ToCharArray();
            Array.Reverse(chSum);
            sSum = new string(chSum);
          
            return new LargeInt(sSum);
        }

        public static LargeInt operator -(LargeInt _largeNumber3, LargeInt _largeNumber4)
        {
            string sMsg = "";
            string largeNumber3 = _largeNumber3.ToString();
            string largeNumber4 = _largeNumber4.ToString();

            int j = largeNumber3.Length;
            if (largeNumber3.Length < largeNumber4.Length)
                j = largeNumber4.Length;
            while ( largeNumber3.Length != largeNumber4.Length)
            {
                if (j != largeNumber3.Length)
                    largeNumber3 = "0" + largeNumber3;
                else
                    largeNumber4 = "0" + largeNumber4;
            }

            int[] IntArray1 = new int[largeNumber3.Length];
            int[] IntArray2 = new int[largeNumber4.Length];
;

            //populate the int array
            for(int i = 0; i < largeNumber3.Length; i++)
            {
                IntArray1[i] = int.Parse(largeNumber3[i].ToString());
            }
            for (int i = 0; i < largeNumber4.Length; i++)
            {
                IntArray2[i] = int.Parse(largeNumber4[i].ToString());
            }
            Array.Reverse(IntArray1);
            Array.Reverse(IntArray2);
            for (int i = 0; i < largeNumber3.Length; i++)
            {
                int n = 1;
                if (IntArray2[i] > IntArray1[i])
                {
                    if(IntArray1[i+1] > 0)
                    {
                        IntArray1[i + 1] = IntArray1[i + 1] - 1;
                        IntArray1[i] = (IntArray1[i] + 10 - IntArray2[i]) % 10;
                    }
                    else
                    {
                        n++;
                        while(n != 0)
                        {
                            if (IntArray1[i + n] == 0)
                                IntArray1[i + n] = IntArray1[i + n] + 10;
                            else
                            {
                                IntArray1[i + n] = IntArray1[i + n] - 1;
                                IntArray1[i] = (IntArray1[i] + 10 - IntArray2[i]) % 10;
                                n = 0;
                            }
                        }
                    }

                }//End of if
                else
                {
                    IntArray1[i] = IntArray1[i] - IntArray2[i];
                }
            }//End of the for loop
            Array.Reverse(IntArray1);
            foreach (int s in IntArray1)
                sMsg += s;
            char[] chMsg = sMsg.ToCharArray();
            Array.Reverse(chMsg);

            sMsg = "";
            for (int i = 0; i < chMsg.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                    sMsg += "," + chMsg[i];
                else
                    sMsg += chMsg[i];
            }
            chMsg = sMsg.ToCharArray();
            Array.Reverse(chMsg);
            sMsg = new string(chMsg);
           

            return new LargeInt(sMsg);
        }
    }
}
