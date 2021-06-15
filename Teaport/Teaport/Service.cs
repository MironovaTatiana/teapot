using System.Threading.Tasks;

namespace Teapot
{
    class Service
    {
        public void Work()
        {
            var person = new Person();
            var phone = new Phone();

            person.WakeUp();

            var task1 = Task.Factory.StartNew(() => person.TurnOnTeapot());
            var task2 = Task.Factory.StartNew(() => phone.Call());

            task1.Wait();
            person.MakeTea();
            task2.Wait();
        }
    }
}
