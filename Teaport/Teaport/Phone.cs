using System;
using System.Threading.Tasks;

namespace Teapot
{
    /// <summary>
    /// Телефон
    /// </summary>
    class Phone
    {
        /// <summary>
        /// Звонок телефона
        /// </summary>
        public async Task CallAsync()
        {
            Console.WriteLine("Начало звонка");
            Task.Delay(100).Wait();
            Console.WriteLine("Звонок завершен");
        }
    }
}
