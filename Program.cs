using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTestTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultTask1 = Task1(_dataTask1);

            var resultTask2 = Task2(_dataTask2);

            var resultTask3 = Task3(_dataTask3);

            var resultTask4 = Task4(_dataTask4);

            var resultTask5 = Task5(_dataTask5);

            var resultTask6 = Task6(_dataTask6);

            var resultTask7 = Task7(_dataATask7, _dataBTask7);

            var resultTask9 = Task9(_dataATask9, _dataBTask9);

            var resultTask10 = Task10(_dataTask10);
        }

        #region Task #1
        
        static List<int> _dataTask1 = new List<int> { 3, 13, 12 , 157, 14, 77, 75, 13, 200, 156, 14, 21 };

        static List<int> Task1(List<int> data) =>
            data.Where(x => x % 2 == 1)
                .Distinct()
                .ToList();

        #endregion

        #region Task #2

        static List<int> _dataTask2 = new List<int> { -12, -33, 134, 12, 1, -3, 99, 199, 5, 17, -121, 10};

        static List<int> Task2(List<int> data) =>
            data.Where(x => x > 0 && x.ToString().Length == 2)
                .OrderBy(x => x)
                .ToList();

        #endregion

        #region Task #3

        static List<string> _dataTask3 = new List<string> { "ADJSLFKHJL", "FAJL", "ADJPLFKHJL", "FATL", "FD", "FAFADFSFDAFR", "FY"};

        static List<string> Task3(List<string> data) =>
            data.OrderBy(x => x.Length)
                .ThenBy(x => x)
                .ToList();

        #endregion

        #region Task #4

            static List<string> _dataTask4 = new List<string> { "asdf", "Rew", "trafa", "nadf", "Slos", "At", "new"};

            static List<char> Task4(List<string> data) =>
                data.Select(x => x[0])
                .Reverse()
                .ToList();
        
        #endregion

        #region Task #5

        static List<int> _dataTask5 = new List<int> { -12, -33, 134, 12, 1, -3, 99, 199, 5, 17, -121, 10};

        static List<int> Task5(List<int> data) =>
            data.Where(x => x > 0)
                .Select(x => x % 10)
                .Distinct()
                .ToList();

        #endregion

        #region Task #6

        static List<int> _dataTask6 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

        static List<int> Task6(List<int> data) =>
            data.Select((x, i) => i % 3 == 1 ? x * 2 : x)
                .Where((x, i) => i % 3 != 0)
                .ToList();

        #endregion

        #region Task #7
        
        static List<int> _dataATask7 = new List<int> { 1, 4, 3, 5, 7, 2, 10, 2, 5, 7};

        static List<int> _dataBTask7 = new List<int> { 1, 4, 3, 5, 7, 2, 10, 2, 5, 7};

        static List<int> Task7(List<int> dataA, List<int> dataB, int k1 = 6, int k2 = 4) =>
            dataA.Where(x => x > k1)
                .Concat(dataB.Where(x => x < k2))
                .OrderBy(x => x)
                .ToList(); 

        #endregion

        #region Task #9

        static List<int> _dataATask9 = new List<int> { 1, 2, 3 };

        static List<int> _dataBTask9 = new List<int> { 4, 5, 6 };

        static List<int> Task9(List<int> dataA, List<int> dataB) =>
            dataA.SelectMany(x => dataB.Select(y => x + y))
            .OrderBy(x => x)
            .ToList();

        #endregion

        #region Task #10

        class Customer
        {
            public int Id { get; set; }
            public int Year { get; set; }
            public int Month { get; set; }
            public int OverallTrainingTime {get; set; }
        }

        static List<Customer> _dataTask10 = new List<Customer>
        {
            new Customer {Id = 1, Year = 2019, Month = 10, OverallTrainingTime = 30 },
            new Customer {Id = 2, Year = 2019, Month = 11, OverallTrainingTime = 35 },
            new Customer {Id = 3, Year = 2019, Month = 11, OverallTrainingTime = 36 },
            new Customer {Id = 4, Year = 2019, Month = 12, OverallTrainingTime = 30 },
        };

        static string Task10(List<Customer> data) =>
            data.Where(x => x.OverallTrainingTime == data.Min(y => y.OverallTrainingTime))
                .Select(x => $"{x.OverallTrainingTime} {x.Year} {x.Month}")
                .Last();
        
        #endregion
    }
}
