namespace LabWork.Models
{
    // Еліпсоїд (x - b1)^2/a1^2 + (y - b2)^2/a2^2 + (z - b3)^2/a3^2 = 1
    public class Ellipsoid : Sphere
    {
        public double A1 { get; private set; }
        public double A2 { get; private set; }
        public double A3 { get; private set; }

        // Перевантажене задання коефіцієнтів
        public void SetCoefficients(double b1, double b2, double b3,
                                    double a1, double a2, double a3)
        {
            base.SetCoefficients(b1, b2, b3, r: 1); // центр спільний
            A1 = a1; A2 = a2; A3 = a3;
        }

        public override void PrintCoefficients()
        {
            System.Console.WriteLine($"ЕЛІПСОЇД: C({B1}; {B2}; {B3}), a1={A1}, a2={A2}, a3={A3}");
            System.Console.WriteLine($"(x - {B1})^2/{A1}^2 + (y - {B2})^2/{A2}^2 + (z - {B3})^2/{A3}^2 = 1");
        }

        // Обєм еліпсоїда
        public override double Volume()
        {
            return 4.0 / 3.0 * System.Math.PI * A1 * A2 * A3;
        }
    }
}
