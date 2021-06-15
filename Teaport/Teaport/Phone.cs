using System;
using System.Threading;

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
        public void Call()
        {
            Console.WriteLine("Начало звонка");
            Thread.Sleep(100);
            Console.WriteLine("Звонок завершен");
        }
    }
}
