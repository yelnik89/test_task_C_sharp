using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Test_task
{
    class FileReader
    {
        private string FileName;

        public bool? OpenFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "text files *.txt|*.txt";
            bool? result = fileDialog.ShowDialog();
            if (result == true)
            {
                FileName = fileDialog.FileName;
            }
            return result;
        }

        public string ReadFile()
        {
            return File.ReadAllText(FileName, Encoding.GetEncoding(1251));
        }

        public List<string[]> SplitFileText()
        {
            List<string[]> result = new List<string[]>();

            string[] splitStrings = SplitString(ReadFile());
            foreach (string s in splitStrings)
            {
                AddStringToList(s, result);
            }

            return result;
        }

        private string[] SplitString(string s)
        {
            s = s.Trim();
            string[] result = s.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return result;
        }

        private void AddStringToList(string s, List<string[]> list)
        {
            if (!s[0].Equals('*') && !s[0].Equals('#') && !s.Equals("ТБ=01"))
            {
                string[] array = s.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                list.Add(array);
            }
        }
    }
}
