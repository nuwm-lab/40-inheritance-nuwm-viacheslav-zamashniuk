using LabWork.Models;
using System;

namespace LabWork
{
    // Даний проект є шаблоном для виконання лабораторних робіт
    // з курсу "Об'єктно-орієнтоване програмування та патерни проектування"
    // Необхідно змінювати і дописувати код лише в цьому проекті
    // Відео-інструкції щодо роботи з github можна переглянути 
    // за посиланням https://www.youtube.com/@ViktorZhukovskyy/videos 
    class Program
    {
        static void Main()
        {
            // 5 Варіант
            // Масив обєктів (поліморфізм)
            Sphere[] arr = new Sphere[3];

            var s = new Sphere();
            s.SetCoefficients(0, 0, 0, 2);
            arr[0] = s;

            var e1 = new Ellipsoid();
            e1.SetCoefficients(1, -1, 0, 2, 3, 1);
            arr[1] = e1;

            var e2 = new Ellipsoid();
            e2.SetCoefficients(0, 0, 0, 1, 1, 1); // це куля R=1
            arr[2] = e2;

            // Вивід і обєми
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"\n[{i}] {arr[i].GetType().Name}");
                arr[i].PrintCoefficients();
                Console.WriteLine($"Об’єм = {arr[i].Volume():F4}");
            }
        }
    }
}
