using System;
using System.Threading;

namespace Teapot
{
    /// <summary>
    /// Человек
    /// </summary>
    class Person
    {
        /// <summary>
        /// Человек
        /// </summary>
        public Person() { }

        /// <summary>
        /// Встать
        /// </summary>
        public void WakeUp()
        {
            Console.WriteLine("Встать");
        }

        /// <summary>
        /// Поставить чайник
        /// </summary>
        public void TurnOnTeapot()
        {
            Console.WriteLine("Поставили чайник");
            Thread.Sleep(60);
            Console.WriteLine("Чайник вскипел");
        }

        /// <summary>
        /// Сделать чай
        /// </summary>
        public void MakeTea()
        {
            Console.WriteLine("Чай налит");
        }
    }
}
