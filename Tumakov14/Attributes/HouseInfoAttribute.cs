using System;

namespace Tumakov14.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class HouseInfoAttribute : Attribute
    {
        public string DeveloperName;
        public string OrganizationName;

        public HouseInfoAttribute()
        {
            DeveloperName = "Unknow Person";
            OrganizationName = "Unknow Organization";
        }

        public HouseInfoAttribute(string developer, string organization)
        {
            DeveloperName = developer;
            OrganizationName = organization;
        }
    }
}
