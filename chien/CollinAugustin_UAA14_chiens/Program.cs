namespace CollinAugustin_UAA14_chiens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chien monChien = new Chien(2, 10, "Medor", "ChiWaWa");
            Console.WriteLine(monChien.AfficheCaractéristiques());
            Console.WriteLine(monChien.Aboyer());
            monChien.vieillir();
            Console.WriteLine(monChien.AfficheCaractéristiques());

            Chien[] mesChien = new Chien[3];
            mesChien[0] = new Chien(2, 5, "rex", "tekel");
            mesChien[1] = new Chien(3, 12, "spinner", "bouvier des flandres");
            mesChien[2] = new Chien(1, 10, "luna", "border collie");

            for (int iChien = 0; iChien < mesChien.Length; iChien++)
            {
                Console.WriteLine(mesChien[iChien].AfficheCaractéristiques());
                mesChien[iChien].vieillir();
            }

        }
    }
}
