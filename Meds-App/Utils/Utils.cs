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
        public static string pathLanguage = @"C:\Users\colde\source\repos\ColdCipri\Meds-App\Meds-App\Resources\language.txt";
        public static string pathTheme = @"C:\Users\colde\source\repos\ColdCipri\Meds-App\Meds-App\Resources\theme.txt";
        public static void Write_To_File_Language(bool value)
        {
            //value.true = English
            //value.false = Ro
            Console.WriteLine("Language = " + value.ToString());
            try
            {
                using (FileStream file = File.Create(pathLanguage))
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

        public static bool Read_From_File_Language()
        {
            //value.true = English
            //value.false = Ro
            try
            {
                using (StreamReader sr = File.OpenText(pathLanguage))
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

        public static void Write_To_File_Theme(bool value)
        {
            //value.true = White
            //value.false = Dark
            Console.WriteLine("Theme = " + value.ToString());
            try
            {
                using (FileStream file = File.Create(pathTheme))
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

        public static bool Read_From_File_Theme()
        {
            //value.true = White
            //value.false = Dark
            try
            {
                using (StreamReader sr = File.OpenText(pathTheme))
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
