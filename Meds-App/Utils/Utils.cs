using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace Meds_App.Utils
{
    public static class Utils
    {
        public static readonly Color ColorBackground = Color.FromArgb(0, 0, 18);
        public static readonly Color ColorButton = Color.FromArgb(40, 40, 50);
        public static readonly Color ColorMouseDownButtonLight = Color.FromArgb(255, 192, 128);
        public static readonly Color ColorMouseOverButtonLight = Color.FromArgb(255, 192, 192);
        public static readonly Color ColorMouseOverButtonDark = Color.FromArgb(50, 50, 50);
        public static readonly Color ColorMouseDownButtonDark = Color.FromArgb(50, 50, 80);
        public static readonly Color ColorButtonCRUD = Color.FromArgb(0, 15, 30);

        //colors for black theme
        public static readonly Color ColorTopBlack = Color.FromArgb(4, 16, 86);
        public static readonly Color ColorLeftBlack = Color.FromArgb(24, 24, 24);

        private const string pathLanguage = @"C:\Users\colde\source\repos\ColdCipri\Meds-App\Meds-App\Resources\language.txt";
        private const string pathTheme = @"C:\Users\colde\source\repos\ColdCipri\Meds-App\Meds-App\Resources\theme.txt";
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
