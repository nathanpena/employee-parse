using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace csv
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] csvArr = CSV.GetData(@"C:\Users\nathan\Desktop\Marathon\MHSourceFile.csv");
            csvArr = CSV.RemoveHeaders(csvArr);
            
            List<string> employees = new List<string>();

            string headers = "FirstName, MiddleName, LastName, Gender, SSN, DOB, Department, Occupation";
            CSV.AddHeaders(ref employees, headers);

            foreach (var line in csvArr)
            {
                Employee emp = new Employee(line);
                employees.Add(emp.ToString());
            }

            string filename = "Interview " + DateTime.Now.ToShortDateString().Replace("/", String.Empty) + ".psv";
            CSV.WriteToFile(@"C:\Users\nathan\Desktop\Marathon\" + filename, employees);
        }

    }
}
