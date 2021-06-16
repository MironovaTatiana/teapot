using System.Threading.Tasks;

namespace Teapot
{
    class Service
    {
        public async Task WorkAsync()
        {
            var person = new Person();

            await person.WakeUpAsync();
            await person.MakeTeaAsync();
        }
    }
}
