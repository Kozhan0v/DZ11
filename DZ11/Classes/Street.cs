using System;

namespace Tumakov13.Classes
{
    internal class Street
    {
        private House[] houses = new House[10];

        public Street()
        {

        }

        public Street(params House[] houses)
        {
            if (houses.Length > 10)
            {
                throw new ArgumentOutOfRangeException();
            }
            for(int i = 0; i < 10; i++)
            {
                this.houses[i] = houses[i];
            }
        }

        public House this[int index]
        {
            get
            {
                if (index < 0 || index > 10)
                {
                    throw new IndexOutOfRangeException();
                }

                return houses[index];
            }
        }
    }
}
