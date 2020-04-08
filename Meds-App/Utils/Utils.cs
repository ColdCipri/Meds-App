using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meds_App.Utils
{
    public static class Utils
    {
        public static string path = @"C:\Users\Cipri\source\repos\Meds-App\Meds-App\Resources\language.txt";
        public static void writeToFile(bool value)
        {
            //value.true = English
            //value.false = Ro
            try
            {
                using (FileStream file = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(value.ToString().ToLower());
                    file.Write(info, 0, value.ToString().Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static bool readFromFile()
        {
            //value.true = English
            //value.false = Ro
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    if ((s = sr.ReadLine()) != null)
                    {
                        return bool.Parse(s);
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return true;
            }
        }
    }
}
