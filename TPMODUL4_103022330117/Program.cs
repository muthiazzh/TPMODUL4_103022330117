//using System;
//using System.Collections.Generic;

//public class KodePos
//{

//    private static Dictionary<string, string> kodePosTable = new Dictionary<string, string>
//    {
//        { "Batununggal", "40266" },
//        { "Kujangsari", "40287" },
//        { "Mengger", "40267" },
//        { "Wates", "40256" },
//        { "Cijaura", "40287" },
//        { "Jatisari", "40286" },
//        { "Margasari", "40286" },
//        { "Sekejati", "40286" },
//        { "Kebonwaru", "40272" },
//        { "Maleer", "40274" },
//        { "Samoja", "40273" }
//    };

//    public static string GetKodePos(string kelurahan)
//    {
//        if (kodePosTable.ContainsKey(kelurahan))
//        {
//            return kodePosTable[kelurahan];
//        }
//        else
//        {
//            return "Kode pos tidak ditemukan";
//        }
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Console.Write("Masukkan nama kelurahan: ");
//        string kelurahan = Console.ReadLine();

//        string kodePos = KodePos.GetKodePos(kelurahan);

//        Console.WriteLine($"Kode Pos untuk {kelurahan} adalah {kodePos}");
//    }
//}

using System;

public class DoorMachine
{
    public enum State { Terkunci, Terbuka }

    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void HandleCommand(string command)
    {
        switch (currentState)
        {
            case State.Terkunci:
                if (command == "BukaPintu")
                {
                    currentState = State.Terbuka;
                    Console.WriteLine("Pintu tidak terkunci");
                }
                break;

            case State.Terbuka:
                if (command == "KunciPintu")
                {
                    currentState = State.Terkunci;
                    Console.WriteLine("Pintu terkunci");
                }
                break;
        }
    }
}

public class Program
{
    public static void Main()
    {
        DoorMachine pintu = new DoorMachine();

        while (true)
        {
            Console.Write("Enter Command: ");
            string command = Console.ReadLine();

            if (command == "QUIT") break;

            pintu.HandleCommand(command);
        }

        Console.WriteLine("Program selesai.");
    }
}
