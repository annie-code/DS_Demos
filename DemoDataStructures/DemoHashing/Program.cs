using System;

namespace DemoHashing
{
    class Program
    {
      
            


            // Main Method 
            public static void Main(String[] args)
            {

                // Declaring the an string array 
                string[] values = new string[50];
                string str;

                // Values of the keys stored 
                string[] keys = new string[] {"Alphabets",
              "Roman", "Numbers", "Alphanumeric",
                                  "Tallypoints"};

                int hashCode;

                for (int k = 0; k < 5; k++)
                {

                    str = keys[k];

                    // calling HashFunction 
                    hashCode = HashFunction(str, values);

                    // Storing keys at their hashcode's index 
                    values[hashCode] = str;
                }

                // Displaying Hashcodes along with key values 
                for (int k = 0; k < (values.GetUpperBound(0)); k++)
                {

                    if (values[k] != null)
                        Console.WriteLine(k + " " + values[k]);
                }
            Console.Read();
            }

            // Defining the hash function 
            static int HashFunction(string s, string[] array)
            {
                int total = 0;
                char[] c;
                c = s.ToCharArray();

                // Summing up all the ASCII values  
                // of each alphabet in the string 
                for (int k = 0; k <= c.GetUpperBound(0); k++)
                    total += (int)c[k];

                return total % array.GetUpperBound(0);
            }
        }



    }
