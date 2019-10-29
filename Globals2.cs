using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMF_Simplifier
{
    internal static class Globals2
    {
        public static string GetMapTypeDirName(MapType mapType)
        {
            switch (mapType)
            {
                default:
                    return "Maps";
                case MapType.System:
                    return "SystemMaps";
                case MapType.Avatar:
                    return "Avatars";
            }
        }
        public static string StripBadChars(string name)
        {
            return StripBadChars(name, false);
        }


        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }

        public static string StripBadChars(string name, bool isFileName)
        {
            return StripBadChars(name, isFileName, isFileName ? null : new char[25]
            {
                '\\',
                '<',
                '>',
                '!',
                '.',
                '?',
                '+',
                '*',
                '%',
                '|',
                '\'',
                '`',
                '~',
                '@',
                '#',
                '$',
                '^',
                '&',
                '(',
                ')',
                '"',
                '{',
                '}',
                ';',
                '/'
            });
        }

        public static string StripBadChars(string name, bool isFileName, char[] exceptions)
        {
            string text = "";
            if (name != null && name.Length > 0)
            {
                foreach (char c in name)
                {
                    if (IsValidChar(c, isFileName, exceptions))
                    {
                        text += c;
                    }
                }
            }
            return text;
        }

        private static bool IsValidChar(char c, bool isFileName, char[] exceptions)
        {
            if (c >= '0' && c <= '9')
            {
                return true;
            }
            if (c >= 'a' && c <= 'z')
            {
                return true;
            }
            if (c >= 'A' && c <= 'Z')
            {
                return true;
            }
            if (exceptions != null)
            {
                for (int i = 0; i < exceptions.Length; i++)
                {
                    if (c == exceptions[i])
                    {
                        return true;
                    }
                }
            }
            if (isFileName)
            {
                char c2 = c;
                if (c2 == ' ' || c2 == '_')
                {
                    return true;
                }
                return false;
            }
            switch (c)
            {
                case ' ':
                case ',':
                case '-':
                case ':':
                case '=':
                case '[':
                case ']':
                case '_':
                    return true;
                default:
                    return false;
            }
        }

        public static string GetFilePath(string dirname, int dirnumber)
        {
            string text = "00000" + dirnumber.ToString();
            return dirname + "\\" + text.Substring(text.Length - 6, 6) + "\\";
        }
        public static string GetMapFilePath(MapType mapType, int dirnumber)
        {
            return GetFilePath(GetMapTypeDirName(mapType), dirnumber);
        }
        public static string GetMapFilePath(MapType mapType, int dirnumber, bool isAutoSave)
        {
            string text = GetMapFilePath(mapType, dirnumber);
            if (isAutoSave)
            {
                text = text.Substring(0, text.Length - 1) + "_auto\\";
            }
            return text;
        }
    }
}
