namespace Teapot
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Service();

            person.WorkAsync();
        }
    }
}
