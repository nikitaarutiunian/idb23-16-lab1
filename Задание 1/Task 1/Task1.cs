using System;

namespace Task1
{
    public class Task1
    {
        private int _numerator;
        private int _denominator;

        public Task1(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("Делитель не может равняться нулю.\n");
                _numerator = 1234567890;
                return;
            }

            if (numerator == 0)
            {
                _numerator = numerator;
                _denominator = 0;
                return;
            }

            if (numerator * denominator >= 0)
            {
                _numerator = Math.Abs(numerator);
                _denominator = Math.Abs(denominator);
            }
            else
            {
                _numerator = -Math.Abs(numerator);
                _denominator = Math.Abs(denominator);
            }

            ReduceFraction();
        }

        private void ReduceFraction()
        {
            int gcd = ComputeGCD(Math.Abs(_numerator), Math.Abs(_denominator));
            _numerator /= gcd;
            _denominator /= gcd;
        }

        private static int ComputeGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            if (_numerator == 1234567890)
                return "Делитель не может равняться нулю.";

            if (_denominator == 1 || _numerator == 0)
                return _numerator.ToString();

            return $"{_numerator}/{_denominator}";
        }

        public static Task1 operator +(Task1 a, Task1 b)
        {
            return PerformOperation(a, b, (x, y) => x + y);
        }

        public static Task1 operator -(Task1 a, Task1 b)
        {
            return PerformOperation(a, b, (x, y) => x - y);
        }

        public static Task1 operator *(Task1 a, Task1 b)
        {
            a._numerator *= b._numerator;
            a._denominator *= b._denominator;
            return NormalizeFraction(a);
        }

        public static Task1 operator /(Task1 a, Task1 b)
        {
            a._numerator *= b._denominator;
            a._denominator *= b._numerator;
            return NormalizeFraction(a);
        }

        private static Task1 PerformOperation(Task1 a, Task1 b, Func<int, int, int> operation)
        {
            int newNumerator = operation(a._numerator * b._denominator, b._numerator * a._denominator);
            int newDenominator = a._denominator * b._denominator;
            return new Task1(newNumerator, newDenominator);
        }

        private static Task1 NormalizeFraction(Task1 fraction)
        {
            if (fraction._denominator < 0)
            {
                fraction._numerator *= -1;
                fraction._denominator *= -1;
            }
            fraction.ReduceFraction();
            return fraction;
        }

        public static bool operator <(Task1 a, Task1 b) => Compare(a, b) < 0;
        public static bool operator >(Task1 a, Task1 b) => Compare(a, b) > 0;
        public static bool operator <=(Task1 a, Task1 b) => Compare(a, b) <= 0;
        public static bool operator >=(Task1 a, Task1 b) => Compare(a, b) >= 0;

        public static bool operator ==(Task1 a, Task1 b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a._numerator == b._numerator && a._denominator == b._denominator;
        }

        public static bool operator !=(Task1 a, Task1 b) => !(a == b);

        private static int Compare(Task1 a, Task1 b)
        {
            int left = a._numerator * b._denominator;
            int right = b._numerator * a._denominator;
            return left.CompareTo(right);
        }

        public void Print() => Console.WriteLine(this);

        public override bool Equals(object obj) => this == obj as Task1;

        public override int GetHashCode() => HashCode.Combine(_numerator, _denominator);
    }
}