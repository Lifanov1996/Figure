using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    public static class Maths
    {
        public const double PI = 3.1415926535897931;

        /// <summary>
        /// Возращает площадь треугольника по трем сторонам
        /// </summary>
        /// <param name="Xside">Сторона треугольника</param>
        /// <param name="Yside">Сторона треугольника</param>
        /// <param name="Zside">Сторона треугольника</param>
        /// <returns>Число х двойной точности с плавающей запятой, такое, что 0 ≤ x ≤System.Double.MaxValue</returns>
        public static double GetAreaTriangle(double Xside, double Yside, double Zside)
        {
            Math.Abs(Xside);
            Math.Abs(Yside);
            Math.Abs(Zside);

            double P = (Xside + Yside + Zside) / 2;
            return Math.Sqrt(P * (P - Xside) * (P - Yside) * (P - Zside));
        }

        /// <summary>
        /// Возращает площадь треугольника по основанию и высоте
        /// </summary>
        /// <param name="Xbase">Основание треугольника</param>
        /// <param name="height">Высота треугольника</param>
        /// <returns>Число х двойной точности с плавающей запятой, такое, что 0 ≤ x ≤System.Double.MaxValue</returns>
        public static double GetAreaTriangle(double Xbase, double height)
        {
            Math.Abs(Xbase);
            Math.Abs(height);

            return (Xbase * height) / 2;
        }

        /// <summary>
        ///  Определяет, является ли треугольник прямоугольным по трем сторонам, где Zside наибольшая сторона 
        /// </summary>
        /// <param name="Xside">Сторона треугольника</param>
        /// <param name="Yside">Сторона треугольника</param>
        /// <param name="Zside">Наибольшая сторона треугольника</param>
        /// <returns>Возращает true если треугольник прямоугольный, в противном случае false</returns>
        public static bool GetRightTriangle(double Xside, double Yside, double Zside)
        {
            Math.Abs(Xside);
            Math.Abs(Yside);
            Math.Abs(Zside);

            return Math.Pow(Zside, 2) == Math.Pow(Xside, 2) + Math.Pow(Yside, 2);                            
        }

        /// <summary>
        /// Возращает площадь круга 
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns>Число х двойной точности с плавающей запятой, такое, что 0 ≤ x ≤System.Double.MaxValue</returns>
        public static double GetAreaCircle(double radius)
        {
            Math.Abs(radius);
            return PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Возращает площадь квадрата
        /// </summary>
        /// <param name="Xside">Сторона квадрата</param>
        /// <returns>Число х двойной точности с плавающей запятой, такое, что 0 ≤ x ≤System.Double.MaxValue</returns>
        public static double GetArea(double Xside)
        {
            Math.Abs(Xside);

            return Math.Pow(Xside, 2);
        }

        /// <summary>
        /// Возращает площадь прямоугольника
        /// </summary>
        /// <param name="Xside">Сторона прямоугольника</param>
        /// <param name="Yside">Сторона прямоугольника</param>
        /// <returns>Число х двойной точности с плавающей запятой, такое, что 0 ≤ x ≤System.Double.MaxValue</returns>
        public static double GetArea(double Xside, double Yside)
        {
            Math.Abs(Xside);
            Math.Abs(Yside);

            return Xside * Yside;
        }

        /// <summary>
        /// Возращает площадь параллелограмма по двум сторонам и углом между ними
        /// </summary>
        /// <param name="Xside">Сторона параллелограммa </param>
        /// <param name="Yside">Сторона параллелограмма </param>
        /// <param name="angle">Острый угол</param>
        /// <returns>Число х двойной точности с плавающей запятой, такое, что 0 ≤ x ≤System.Double.MaxValue</returns>
        public static double GetArea(double Xside, double Yside, double angle)
        {
            Math.Abs(Xside);
            Math.Abs(Yside);
            Math.Abs(angle);

            return Xside * Yside * Math.Sin(angle);
        }
    }
}
