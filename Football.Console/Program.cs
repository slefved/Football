using Football.Domain.Repository;

namespace Football.Console
{
    //wot
    class Program
    {
        static void Main(string[] args)
        {
            PlayerRepository repo = new PlayerRepository();
            foreach (var item in repo.GetByName("ma"))
            {
                System.Console.WriteLine(item.Name);
                //test lagi
                System.Console.WriteLine("J");
                //test from git
                //test from local
            }
        }
    }
}
