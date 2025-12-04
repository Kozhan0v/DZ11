using System;

namespace Tumakov14.Classes
{
    [DeveloperInfo()]
    [DeveloperInfo("Kirill", "27.11.2025")]
    internal class Rational
    {
        public long Numerator { get; private set; }
        public long Denominator { get; private set; }

        public Rational(long numerator)
        {
            Numerator = numerator;
            Denominator = 1;
        }

        public Rational(long numenator, long denominator)
        {
            Numerator = numenator;

            if (denominator == 0)
            {
                throw new ArgumentNullException();
            }
            else
            {
                Denominator = denominator;
            }
        }

        public override bool Equals(object obj)
        {
            Rational num = obj as Rational;

            if (num is not null)
            {
                return ((decimal)Numerator / Denominator) == ((decimal)num.Numerator / num.Denominator) ? true : false;
            }

            return false;
        }

        public static bool operator ==(Rational num1, Rational num2)
        {
            return ((decimal)num1.Numerator / num1.Denominator) == ((decimal)num2.Numerator / num2.Denominator) ? true : false;
        }

        public static bool operator !=(Rational num1, Rational num2)
        {
            return ((decimal)num1.Numerator / num1.Denominator) == ((decimal)num2.Numerator / num2.Denominator) ? false : true;
        }

        public static bool operator <(Rational num1, Rational num2)
        {
            return ((decimal)num1.Numerator / num1.Denominator) < ((decimal)num2.Numerator / num2.Denominator) ? true : false;
        }

        public static bool operator >(Rational num1, Rational num2)
        {
            return ((decimal)num1.Numerator / num1.Denominator) > ((decimal)num2.Numerator / num2.Denominator) ? true : false;
        }

        public static bool operator <=(Rational num1, Rational num2)
        {
            return ((decimal)num1.Numerator / num1.Denominator) <= ((decimal)num2.Numerator / num2.Denominator) ? true : false;
        }

        public static bool operator >=(Rational num1, Rational num2)
        {
            return ((decimal)num1.Numerator / num1.Denominator) >= ((decimal)num2.Numerator / num2.Denominator) ? true : false;
        }

        public static Rational operator +(Rational num1, Rational num2)
        {
            long numerator;
            long denominator;
            long index1 = 1;
            long index2;

            while ((num1.Denominator * index1) % num2.Denominator != 0)
            {
                index1++;
            }

            index2 = (num1.Denominator * index1) / num2.Denominator;
            numerator = (num1.Numerator * index1) + (num2.Numerator * index2);
            denominator = num1.Denominator * index1;

            return new Rational(numerator, denominator);
        }

        public static Rational operator -(Rational num1, Rational num2)
        {
            long numerator;
            long denominator;
            long index1 = 1;
            long index2;

            while ((num1.Denominator * index1) % num2.Denominator != 0)
            {
                index1++;
            }

            index2 = (num1.Denominator * index1) / num2.Denominator;
            numerator = (num1.Numerator * index1) - (num2.Numerator * index2);
            denominator = num1.Denominator * index1;

            return new Rational(numerator, denominator);
        }

        public static Rational operator ++(Rational num)
        {
            long numerator = num.Numerator + num.Denominator;

            return new Rational(numerator, num.Denominator);
        }

        public static Rational operator --(Rational num)
        {
            long numerator = num.Numerator - num.Denominator;

            return new Rational(numerator, num.Denominator);
        }

        public static Rational operator *(Rational num1, Rational num2)
        {
            return new Rational(num1.Numerator * num2.Numerator, num1.Denominator * num2.Denominator);
        }

        public static Rational operator /(Rational num1, Rational num2)
        {

            if (num2.Numerator == 0)
            {
                return null;
            }

            return new Rational(num1.Numerator * num2.Denominator, num1.Denominator * num2.Numerator);
        }

        public static Rational operator %(Rational num1, Rational num2)
        {
            var division1 = (decimal)num1.Numerator / num1.Denominator;
            var division2 = (decimal)num2.Numerator / num2.Denominator;

            return num1 - (num2 * (long)Math.Floor(division1 / division2));
        }

        public static implicit operator Rational(int num)
        {
            return new Rational(num);
        }

        public static explicit operator int(Rational num)
        {
            return (int)Math.Round((float)num.Numerator / num.Denominator);
        }

        public static implicit operator Rational(float num)
        {
            long numerator;
            long denominator = 1;
            int index = 1;

            while (num % 1 == 0)
            {
                num *= (float)Math.Pow(10, index);
                denominator *= (long)Math.Pow(10, index);
            }

            numerator = (long)num;

            return new Rational(numerator, denominator);
        }

        public static explicit operator float(Rational num)
        {
            return (float)num.Numerator / num.Denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public override int GetHashCode()
        {
            return ((float)Numerator / Denominator).GetHashCode();
        }
    }
}
