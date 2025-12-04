using System;

namespace Tumakov14.Classes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=true)]
    internal class DeveloperInfoAttribute : Attribute
    {
        public string DeveloperName;
        public DateTime Date;

        public DeveloperInfoAttribute()
        {
            DeveloperName = "Sir Winston Leonard Spenser Cherchil";
            Date = DateTime.Parse("01.01.1936").Date;
        }

        public DeveloperInfoAttribute(string developerName, string date)
        {
            DeveloperName = developerName;

            if (DateTime.TryParse(date, out Date))
            {
                Date = DateTime.Parse(date).Date;
            }
            else
            {
                Date = DateTime.Parse("01.01.1936").Date;
            }
        }
    }
}
