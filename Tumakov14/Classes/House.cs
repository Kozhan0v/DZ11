using System;
using Tumakov14.Attributes;

namespace Tumakov14.Classes
{
    [HouseInfo("Nikola Tesla", "Yandex")]
    internal class House
    {
        private static short staticHouseNum = 0;
        private short houseNum;
        private double height;
        private short numberOfFloors;
        private short numberOfFlats;
        private short numberOfEntrances;

        public House()
        {
            houseNum = CreateNewHouseNum();
            height = 0;
            numberOfFloors = 0;
            numberOfFlats = 0;
            numberOfEntrances = 0;
        }

        public House(double height, short numberOfFloors, short numberOfFlats, short numberOfEntrances)
        {
            houseNum = CreateNewHouseNum();
            this.height = height;
            this.numberOfFloors = numberOfFloors;
            this.numberOfFlats = numberOfFlats;
            this.numberOfEntrances = numberOfEntrances;
        }

        public short HouseNum
        {
            get => houseNum;
            set => houseNum = value;
        }

        public double Height
        {
            get => height;
            set => height = value;
        }

        public short NumberOfFloors
        {
            get => numberOfFloors;
            set => numberOfFloors = value;
        }

        public short NumberOfFlats
        {
            get => numberOfFlats;
            set => numberOfFlats = value;
        }

        public short NumberOfEntrances
        {
            get => numberOfEntrances;
            set => numberOfEntrances = value;
        }

        private short CreateNewHouseNum()
        {
            return ++staticHouseNum;
        }

        public double CalcHeightOfFloor()
        {
            double heightOfFloor = numberOfFloors == 0 ? 0 : height / numberOfFloors;
            return heightOfFloor;
        }

        public short CalcFlatsInEntrance()
        {
            short numberOfFlatsInEntrance = (short)(numberOfEntrances == 0 ? 0 : numberOfFlats / numberOfEntrances);
            return numberOfFlatsInEntrance;
        }

        public short CalcFlatsOnFloor()
        {
            short flatsOnFloor = (short)(numberOfFloors == 0 ? 0 : CalcFlatsInEntrance() / numberOfFloors);
            return flatsOnFloor;
        }

        public override string ToString()
        {
            return $"Номер дома: {houseNum}, Высота: {height}, Кол-во этажей: {numberOfFloors}, Кол-во квартир: {numberOfFlats}, Кол-во подъездов: {numberOfEntrances}";
        }
    }
}