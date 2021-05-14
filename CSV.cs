using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace csv
{
    class CSV
    {
        internal static string[] GetData(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        internal static string[] RemoveHeaders(string[] data)
        {
            return data.Skip(1).ToArray();
        }

        internal static void WriteToFile(string filePath, List<string> lines)
        {
            File.WriteAllLines(filePath, lines);
        }

        internal static void AddHeaders(ref List<string> employees, string headers)
        {
            employees.Add(headers);
        }
    }
}
