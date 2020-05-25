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
        }

        #region Task1
        
        static List<int> _dataTask1 = new List<int> { 3, 13, 12 , 157, 14, 77, 75, 13, 200, 156, 14, 21 };

        static List<int> Task1(List<int> data) =>
            data.Where(x => x % 2 == 1)
                .Distinct()
                .ToList();

        #endregion
    }
}
