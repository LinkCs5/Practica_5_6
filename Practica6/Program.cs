using System;

class TorresDeHanoi
{
    static void Main(string[] args)
    {
        System.Console.SetIn(new System.IO.StreamReader(Console.OpenStandardInput(8192)));

        Console.WriteLine("Ingrese el número de discos: ");
        int numDiscos = Convert.ToInt32(Console.ReadLine());

        MoverTorres(numDiscos, 'A', 'C', 'B');

        Console.ReadLine();
    }

    static void MoverTorres(int n, char origen, char destino, char auxiliar)
    {
        if (n == 1)
        {
            Console.WriteLine($"Mover disco 1 desde la torre {origen} a la torre {destino}");
            return;
        }

        MoverTorres(n - 1, origen, auxiliar, destino);
        Console.WriteLine($"Mover disco {n} desde la torre {origen} a la torre {destino}");
        MoverTorres(n - 1, auxiliar, destino, origen);
    }
}
