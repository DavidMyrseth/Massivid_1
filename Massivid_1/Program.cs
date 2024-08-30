// 1. Ülesanne: Loo juhuslikud arvud N ja M ning trüki nende ruudud

//using System; // standart lybrury

//class Program
//{
//    static void Main()
//    {
//        Random rand = new Random();
//        int N = rand.Next(-100, 101); // Juhuslik arv vahemikus -100 kuni 100
//        int M = rand.Next(-100, 101);

//        Console.WriteLine($"N = {N}, M = {M}");

//        int start = Math.Min(N, M);
//        int end = Math.Max(N, M);

//        Console.WriteLine("Arvude ruudud: ");
//        for (int i = start; i <= end; i++)
//        {
//            Console.WriteLine($"{i}^2 = {i * i}");
//        }
//    }
//}

// 2.Ülesanne: Kasutaja sisestab viis arvu, trüki nende summa, keskmine ja korrutis
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arvud = new int[5];
//        int summa = 0;
//        int korrutis = 1;

//        for (int i = 0; i < 5; i++)
//        {
//            Console.Write($"Sisesta {i + 1}. arv: ");
//            arvud[i] = int.Parse(Console.ReadLine()); // priobrzuem dannoe chislo v int (arvud)
//            summa += arvud[i];
//            korrutis *= arvud[i];
//        }

//        double keskmine = (double)summa / arvud.Length;

//        Console.WriteLine($"Summa: {summa}");
//        Console.WriteLine($"Aritmeetiline keskmine: {keskmine}");
//        Console.WriteLine($"Korrutis: {korrutis}");
//    }
//}

// 3. Ülesanne: Kasutajate nimed ja vanused, väljasta summaarne vanus, keskmine, vanim ja noorim.
//using System;
//class Program
//{
//    static void Main()
//    {
//        string[] nimed = new string[5];
//        int[] vanused = new int[5];
//        int summaarneVanus = 0;

//        for (int i = 0; i < 5; i++)
//        {
//            Console.Write($"Sisesta {i + 1}. nimi: ");
//            nimed[i] = Console.ReadLine();
//            Console.Write($"Sisesta {i + 1}. vanus: ");
//            vanused[i] = int.Parse(Console.ReadLine());
//            summaarneVanus += vanused[i];
//        }

//        double keskmineVanus = (double)summaarneVanus / vanused.Length;
//        int vanimVanus = vanused[0];
//        int noorimVanus = vanused[0];
//        string vanimNimi = nimed[0];
//        string noorimNimi = nimed[0];

//        for (int i = 1; i < 5; i++)
//        {
//            if (vanused[i] > vanimVanus)
//            {
//                vanimVanus = vanused[i];
//                vanimNimi = nimed[i];
//            }
//            if (vanused[i] < noorimVanus)
//            {
//                noorimVanus = vanused[i];
//                noorimNimi = nimed[i];
//            }
//        }

//        Console.WriteLine($"Summaarne vanus: {summaarneVanus}");
//        Console.WriteLine($"Keskmine vanus: {keskmineVanus}");
//        Console.WriteLine($"Vanim inimene: {vanimNimi}, vanus: {vanimVanus}");
//        Console.WriteLine($"Noorim inimene: {noorimNimi}, vanus: {noorimVanus}");
//    }
//}

//Second ex vanem

//using System;

//namespace PraktLineToo
//{
//    public class Kusitlus
//    {
//        int sum = 0;
//        int[] vanem = new int[2](-1, 0);
//        int[] noorem = new int[2](-1, 0);
//        string[] nimed = new string[5];
//        int[] vanused = new int[5];
//        public Kusitlus()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Mis nimi sul on?");
//                nimed[i] = Console.ReadLine();
//                Console.WriteLine("Kui vana sa oled?");
//                vanused[i] = int.Parse(Console.ReadLine());

//                sum += vanused[i];

//                if (vanem[0] == -1!! vanem[1] < vanused[i])
//                {
//                vanem[1] = vanused[i];
//                vanem[0] = i;
//                }
//                if (noorem[0] == -1!! noorem[1] > vanused[i])
//                {
//                noorem[1] = vanused[i];
//                noorem[0] = i;
//                }
            

//        }   
//    }
//}


// 4.Ülesanne: Korda küsimust, kuni kasutaja sisestab "elevant".

//using System;

//class Program
//{
//    static void Main()
//    {
//        string vastus = "";

//        while (vastus != "elevant")
//        {
//            Console.WriteLine("Osta elevant ära!");
//            vastus = Console.ReadLine();
//        }

//        Console.WriteLine("Aitäh, et ostsid elevandi!");
//    }
//}

// Second ex elevant

//public static void OstaElevant() 
//{
//    string kasutajaSisend;

//    do 
//    {
//        Console.WriteLine("Osta elevant ära");
    
//        kasutajaSisend = Console.ReadLine();
//    }
//    while (string.Equals(kasutajaSisend, "elevant", StringComparison.OrdinalIgnoreCase));

//    Console.WriteLine("Kasutaja sisestas Elevant, Program lõpetab.");
//}


// 5. Ülesanne: Arvuta, mis arv mõtles välja arvuti, kasutades 5 katset.

//using System;

//class Program
//{
//    static void Main()
//    {
//        Random rand = new Random();
//        int arvutiArv = rand.Next(1, 21); // Juhuslik arv vahemikus 1 kuni 20
//        int katseteArv = 5;

//        Console.WriteLine("Arvuti mõtles ühe arvu välja vahemikus 1 kuni 20. Arva ära!");

//        for (int i = 0; i < katseteArv; i++)
//        {
//            Console.Write($"Sisesta oma arvamus (katse {i + 1}/{katseteArv}): ");
//            int kasutajaArv = int.Parse(Console.ReadLine());

//            if (kasutajaArv == arvutiArv)
//            {
//                Console.WriteLine("Tubli! Arvasid õigesti!");
//                return;
//            }
//            else
//            {
//                Console.WriteLine("Vale arv! Proovi uuesti.");
//            }
//        }

//        Console.WriteLine($"Kahjuks ei arvanud õigesti. Arvuti mõtles arvu: {arvutiArv}");
//    }
//}

//6. Ülesanne: Kasutaja sisestab 4 arvu, trüki suurim neljakohaline arv. 

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] arvud = new int[4];

//        for (int i = 0; i < 4; i++)
//        {
//            Console.Write($"Sisesta {i + 1}. number: ");
//            arvud[i] = int.Parse(Console.ReadLine());
//        }

//        var suurimArv = string.Join("", arvud.OrderByDescending(x => x));

//        Console.WriteLine($"Suurim neljakohaline arv on: {suurimArv}");
//    }
//}

//7. Ülesanne: Korrutustabel

//using System;

//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            for (int j = 1; j <= 10; j++)
//            {
//                Console.Write($"{i * j,4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}