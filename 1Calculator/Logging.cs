using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Calculator
{
    class Logging
    {
        private static async Task AddToFile(string message)
        {
            using StreamWriter file = new("WriteText.txt", append: true);
            await file.WriteLineAsync(message);
        }

        public async void LogNumberAnswer()
        {
            await AddToFile(NumberCalculation.PerformOneNumberCalculation());
        }

        public async void LogDateAnswer()
        {
            await AddToFile(DateCalculation.PerformOneDateCalculation());
        }
    }
}
