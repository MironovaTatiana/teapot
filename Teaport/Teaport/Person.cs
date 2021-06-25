using System;
using System.Threading.Tasks;

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
        public async Task WakeUpAsync()
        {
            Console.WriteLine("Встать");
        }

        /// <summary>
        /// Сделать чай
        /// </summary>
        public async Task MakeTeaAsync()
        {
            Console.WriteLine("Поставили чайник");

            var teapot = new Teaport.Teapot();
            var isHotWater = Task.Factory.StartNew(() => teapot.BoilAsync());
            var phone = new Phone();
            var task = Task.Factory.StartNew(() => phone.CallAsync());

            if (await isHotWater.Result)
            {
                Console.WriteLine("Чай налит");
            }

            task.Wait();
        }
    }
}
