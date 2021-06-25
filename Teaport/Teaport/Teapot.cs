using System;
using System.Threading.Tasks;

namespace Teaport
{
    /// <summary>
    /// Чайник
    /// </summary>
    public class Teapot
    {
        /// <summary>
        /// Вскипятить
        /// </summary>
        public async Task<bool> BoilAsync()
        {
            Task.Delay(60).Wait();
            Console.WriteLine("Чайник вскипел");

            return true;
        }
    }
}
