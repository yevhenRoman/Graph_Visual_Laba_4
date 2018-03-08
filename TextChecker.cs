using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Visual_Laba_3
{
    public static class TextChecker
    {
        public static bool CheckString(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            int len = str.Length;
            for (int i = 0; i < len; ++i)
            {
                char c = str[i];
                if ((c < '0' || c > '9') && c != ',')
                    return false;
            }
            return true;
        }

        public static List<Tuple<string, string>> CheckFile(string path)
        {
            bool check_str = false;
            List<Tuple<string, string>> XY = new List<Tuple<string, string>>();

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                bool readX = false, readY = false;
                string line;
                string X_value = "", Y_value = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (!CheckString(line))
                    {
                        check_str = true;
                        break;
                    }
                    if (readX && readY)
                    {
                        readX = false; readY = false;
                    }
                    if (!readX)
                    {
                        X_value = line;
                        readX = true;
                        continue;
                    }
                    else if (!readY)
                    {
                        Y_value = line;
                        readY = true;
                        // We got X and Y
                        XY.Add(new Tuple<string, string>(X_value, Y_value));
                    }
                }

            }

            if (check_str)
            {
                return null;
            }
            return XY;
        }

    }

}
