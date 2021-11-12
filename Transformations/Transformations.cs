using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Transformations
/*
  1.Pascal
  2.Title
*/
{

    class Transformations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            String Text = Console.ReadLine();
            Console.WriteLine(Camelcase(Text));
        }

        public static string Camelcase(String Newt)
        {
            if (Newt == null || Newt.Length == 0)
                return null;

            StringBuilder retVal = new StringBuilder(32);

            retVal.Append(char.ToLower(Newt[0]));
            for (int i = 1; i < Newt.Length; i++)
            {
                if (char.IsLower(Newt[i]))
                {
                    retVal.Append(Newt[i]);
                }
                else
                {
                    retVal.Append("");
                    retVal.Append(char.ToUpper(Newt[i]));
                }
            }

            return retVal.ToString();

        }
                 
    }
}
