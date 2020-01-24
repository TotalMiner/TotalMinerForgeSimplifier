using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TMF_Simplifier
{
    public static class FileSystem
    {
        private static string rootPath;

        public static string RootPath
        {
            get
            {
                return rootPath;
            }
            set
            {
                rootPath = value;
                if (rootPath != null && !rootPath.EndsWith("\\"))
                {
                    rootPath += '\\';
                }
            }
        }

        public static string CurrentDir
        {
            get
            {
                return Directory.GetCurrentDirectory();
            }
        }

        public static bool IsFileExist(string path)
        {
            return File.Exists(RootPath + path);
        }

        public static void DeleteFile(string path)
        {
            if (IsFileExist(path))
            {
                File.Delete(RootPath + path);
            }
        }

        public static Stream CreateFile(string path)
        {
            return File.Create(RootPath + path);
        }

        public static Stream OpenFile(string path, FileMode mode)
        {
            return File.Open(RootPath + path, mode);
        }

        public static Stream OpenFile(string path, FileMode mode, FileAccess access)
        {
            return File.Open(RootPath + path, mode, access);
        }

        public static Stream OpenFile(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return File.Open(RootPath + path, mode, access, share);
        }

        public static Stream OpenRead(string path)
        {
            return File.Open(RootPath + path, FileMode.Open, FileAccess.Read, FileShare.Read);
        }

        public static Stream OpenWrite(string path)
        {
            return File.Open(RootPath + path, FileMode.Create, FileAccess.Write, FileShare.Write);
        }

        public static T Deserialize<T>(string path)
        {
            using (Stream input = OpenRead(path))
            {
                using (XmlReader xmlReader = XmlReader.Create(input))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    return (T)xmlSerializer.Deserialize(xmlReader);
                }
            }
        }

        public static string RemoveRoot(string path)
        {
            if (rootPath != null && path.StartsWith(rootPath))
            {
                return path.Substring(rootPath.Length, path.Length - rootPath.Length);
            }
            return path;
        }

        public static void RemoveRoot(string[] paths)
        {
            if (rootPath != null)
            {
                for (int i = 0; i < paths.Length; i++)
                {
                    paths[i] = RemoveRoot(paths[i]);
                }
            }
        }

        public static bool IsDirExist(string path)
        {
            return Directory.Exists(RootPath + path);
        }

        public static void SetCurrentDir(string path)
        {
            Directory.SetCurrentDirectory(RootPath + path);
        }

        public static void CreateDir(string path)
        {
            if (!IsDirExist(path))
            {
                Directory.CreateDirectory(RootPath + path);
            }
        }

        public static void DeleteDir(string path)
        {
            if (IsDirExist(path))
            {
                EmptyDir(path, "*");
                Directory.Delete(RootPath + path);
            }
        }

        public static void DeleteDir(string path, bool recursive)
        {
            if (IsDirExist(path))
            {
                Directory.Delete(RootPath + path, recursive);
            }
        }

        public static void EmptyDir(string path, string pattern)
        {
            string[] files = GetFiles(path, pattern);
            foreach (string path2 in files)
            {
                DeleteFile(path2);
            }
        }

        public static string[] GetDirs(string path)
        {
            if (IsDirExist(path))
            {
                string[] directories = Directory.GetDirectories(RootPath + path);
                RemoveRoot(directories);
                return directories;
            }
            return new string[0];
        }

        public static string[] GetFiles(string path, string pattern)
        {
            if (IsDirExist(path))
            {
                string[] files = Directory.GetFiles(RootPath + path, pattern);
                RemoveRoot(files);
                return files;
            }
            return new string[0];
        }
    }
}
