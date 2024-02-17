using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1. Создание переменных и вывод

            //Объявление имён для полей задания 1
            string fieldName = "Ф. И. О.";
            string fieldAge = "Возраст";
            string fieldEmail = "Электронная почта";
            string fieldProgram = "Баллы по программированию";
            string fieldMath = "Баллы по математике";
            string fieldPhysics = "Баллы по физике";

            //Объявление переменных и присваивание им значений данных учащегося
            string fullName = "Ярослав Владимирович Мудрый";
            byte age = 39;
            string email = "yar@rus.ru";
            double programScores = 10;
            double mathScores = 9.1;
            double physicsScores = 9.5;

            //Вывод данных в терминал
            Console.WriteLine("Данные учащегося:");
            Console.WriteLine($"{fieldName,25} {fullName}");
            Console.WriteLine($"{fieldAge,25} {age}");
            Console.WriteLine($"{fieldEmail,25} {email}");
            Console.WriteLine($"{fieldProgram,25} {programScores}");
            Console.WriteLine($"{fieldMath,25} {mathScores}");
            Console.WriteLine($"{fieldPhysics,25} {physicsScores}");

            //Задержка окна терминала до нажатия любой клавиши
            Console.ReadKey();

            #endregion

            #region Задание 2. Реализация подсчёта количества баллов по всем предметам

            //Объявление имён для полей задания 2
            string fieldTotal = "Сумма баллов";
            string fieldAverage = "Средний балл";

            //Объявление переменных и присваивание им вычисляемых итоговых значений
            double totalScore;
            totalScore = programScores + mathScores + physicsScores;
            double averageScore;
            averageScore = (programScores + mathScores + physicsScores) / 3;

            //Вывод итоговых значений в терминал
            Console.WriteLine("\nИтоговые результаты:");
            Console.WriteLine($"{fieldTotal,25} {totalScore}");
            Console.WriteLine($"{fieldAverage,25} {averageScore:0.0}");

            //Задержка окна терминала до нажатия любой клавиши
            Console.ReadKey();

            #endregion

        }
    }
}
