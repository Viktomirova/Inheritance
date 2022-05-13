using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            MuseElf elf = new MuseElf("Elf", 152);
            Console.WriteLine(elf);

            SoulMaster master = new SoulMaster("Master", 32);
            Console.WriteLine(master);
        }
    }
}