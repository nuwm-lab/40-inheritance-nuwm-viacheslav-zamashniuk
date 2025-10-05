namespace LabWork.Models
{
    // Куля (x - b1)^2 + (y - b2)^2 + (z - b3)^2 = R^2
    public class Sphere
    {
        // Коєфіцієнти
        public double B1 { get; private set; }
        public double B2 { get; private set; }
        public double B3 { get; private set; }
        public double R { get; private set; }

        // Задання відповідних коефіцієнтів
        public virtual void SetCoefficients(double b1, double b2, double b3, double r)
        {
            B1 = b1; B2 = b2; B3 = b3; R = r;
        }

        // Виведення коефіцієнтів на екран
        public virtual void PrintCoefficients()
        {
            System.Console.WriteLine($"КУЛЯ: C({B1}; {B2}; {B3}), R = {R}");
            System.Console.WriteLine($"(x - {B1})^2 + (y - {B2})^2 + (z - {B3})^2 = {R}^2");
        }

        // Визначення об’єму кулі
        public virtual double Volume()
        {
            return 4.0 / 3.0 * System.Math.PI * R * R * R;
        }
    }
}
