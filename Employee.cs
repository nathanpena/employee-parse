using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace csv
{
    class Employee
    {
        public string FirstName, MiddleName, LastName, Gender, SSN, DOB, Department, Occupation;


        public Employee(string rowData)
        {
            string[] row = Regex.Split(rowData, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            ParseFullName(row[0]);
            ParseGender(row[1]);
            ParseSSN(row[2]);
            ParseDOB(row[3]);
            ParseDept(row[4]);
            ParseOccupation(row[5]);

        }

        private void ParseOccupation(string rowData)
        {
            this.Occupation = rowData.Trim();
        }

        private void ParseDept(string rowData)
        {
            this.Department = "Corporate";

            if (String.IsNullOrEmpty(rowData))
            {
                string dept = rowData.Trim().ToLower();

                if (dept != "corporate")
                {
                    this.Department = "Operations";
                }
            }
        }

        private void ParseSSN(string rowData)
        {
            this.SSN = rowData.Trim().Replace("-", string.Empty);
        }

        private void ParseDOB(string rowData)
        {
            DateTime dateTime = DateTime.Parse(rowData.Trim());
            this.DOB = dateTime.ToString("yyyy-MM-dd");
        }

        private void ParseGender(string rowData)
        {
            string gender = rowData.Trim()[0].ToString().ToUpper();
            if( gender == "M" || gender == "F")
            {
                this.Gender = gender;
            } else
            {
                this.Gender = "U";
            }
        }

        private void ParseFullName(string rowData)
        {
            string[] parsedName = rowData.Trim().Split(" ");
            if(parsedName.Length == 2)
            {
                this.FirstName = parsedName[0];
                this.MiddleName = String.Empty;
                this.LastName = parsedName[1];
            } else
            {
                this.FirstName = parsedName[0];
                this.MiddleName = parsedName[1];
                this.LastName = parsedName[2];
            }
        }

        public override string ToString()
        {
            var d = '|';
            return $"{FirstName}{d}{MiddleName}{d}{LastName}{d}{Gender}{d}{SSN}{d}{DOB}{d}{Department}{d}{Occupation}";
        }
    }
}
