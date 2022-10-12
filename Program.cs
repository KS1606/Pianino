namespace Пианинок
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BASE();
        }
        static void BASE()
        {
            Console.WriteLine(" Ведите номер актавы ");
            Console.WriteLine(" Переключение между октавами F1,F2,F3");
            Console.WriteLine(" Для переключением между октавами нажмите 2 раза на желаемую октаву");
            Console.WriteLine(" Для выхода из программы нажмите два раза на Enter");
            SwitchingOctaves();
        }
        static void SwitchingOctaves()
        {
            do
            {
                ConsoleKeyInfo oktave = Console.ReadKey();
                if (oktave.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("Вы включили 1 октаву");
                    One();
                }
                if (oktave.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("Вы включили 2 октаву");
                    Two();
                }
                if (oktave.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("Вы включили 3 октаву");
                    Three();
                }
                if (oktave.Key == ConsoleKey.Enter)
                {
                    break;
                }
            } while(true);
        }
        static void One()
        {
            OneOctave();
        }
        static void Two()
        {
            TwoOctave();
        }
        static void Three()
        {
            ThreeOctave();
        }
        static void OneOctave()
        {
            do
            {
                ConsoleKeyInfo pianino = Console.ReadKey();
                if (pianino.Key == ConsoleKey.Z)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[0], 500);
                }
                if (pianino.Key == ConsoleKey.S)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[1], 500);
                }
                if (pianino.Key == ConsoleKey.X)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[2], 500);
                }
                if (pianino.Key == ConsoleKey.D)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[3], 500);
                }
                if (pianino.Key == ConsoleKey.C)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[4], 500);
                }
                if (pianino.Key == ConsoleKey.V)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[5], 500);
                }
                if (pianino.Key == ConsoleKey.G)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[6], 500);
                }
                if (pianino.Key == ConsoleKey.B)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[7], 500);
                }
                if (pianino.Key == ConsoleKey.H)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[8], 500);
                }
                if (pianino.Key == ConsoleKey.N)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[9], 500);
                }
                if (pianino.Key == ConsoleKey.J)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[10], 500);
                }
                if (pianino.Key == ConsoleKey.M)
                {
                    int[] oktave6 = SixOktave();
                    Console.Beep(oktave6[11], 500);
                }
                if (pianino.Key == ConsoleKey.F2)
                {
                    break;
                }
                if (pianino.Key == ConsoleKey.F3)
                {
                    break;
                }
                if (pianino.Key == ConsoleKey.Enter)
                {
                    break;
                }
                Console.Clear();
            } while (true);
        }
        static void TwoOctave()
        {
            do
            {
                ConsoleKeyInfo pianino = Console.ReadKey();
                if (pianino.Key == ConsoleKey.Z)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[0], 500);
                }
                if (pianino.Key == ConsoleKey.S)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[1], 500);
                }
                if (pianino.Key == ConsoleKey.X)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[2], 500);
                }
                if (pianino.Key == ConsoleKey.D)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[3], 500);
                }
                if (pianino.Key == ConsoleKey.C)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[4], 500);
                }
                if (pianino.Key == ConsoleKey.V)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[5], 500);
                }
                if (pianino.Key == ConsoleKey.G)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[6], 500);
                }
                if (pianino.Key == ConsoleKey.B)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[7], 500);
                }
                if (pianino.Key == ConsoleKey.H)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[8], 500);
                }
                if (pianino.Key == ConsoleKey.N)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[9], 500);
                }
                if (pianino.Key == ConsoleKey.J)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[10], 500);
                }
                if (pianino.Key == ConsoleKey.M)
                {
                    int[] oktave7 = SevenOktave();
                    Console.Beep(oktave7[11], 500);
                }
                if (pianino.Key == ConsoleKey.F1)
                {
                    break;
                }
                if (pianino.Key == ConsoleKey.F3)
                {
                    break;
                }
                if (pianino.Key == ConsoleKey.Enter)
                {
                    break;
                }
                Console.Clear();
            } while (true);
            
        }
        static void ThreeOctave()
        {
            do
            {
                ConsoleKeyInfo pianino = Console.ReadKey();
                if (pianino.Key == ConsoleKey.Z)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[0], 500);
                }
                if (pianino.Key == ConsoleKey.S)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[1], 500);
                }
                if (pianino.Key == ConsoleKey.X)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[2], 500);
                }
                if (pianino.Key == ConsoleKey.D)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[3], 500);
                }
                if (pianino.Key == ConsoleKey.C)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[4], 500);
                }
                if (pianino.Key == ConsoleKey.V)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[5], 500);
                }
                if (pianino.Key == ConsoleKey.G)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[6], 500);
                }
                if (pianino.Key == ConsoleKey.B)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[7], 500);
                }
                if (pianino.Key == ConsoleKey.H)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[8], 500);
                }
                if (pianino.Key == ConsoleKey.N)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[9], 500);
                }
                if (pianino.Key == ConsoleKey.J)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[10], 500);
                }
                if (pianino.Key == ConsoleKey.M)
                {
                    int[] oktave8 = EightOktave();
                    Console.Beep(oktave8[11], 500);
                }
                if (pianino.Key == ConsoleKey.F1)
                {
                    break;
                }
                if (pianino.Key == ConsoleKey.F2)
                {
                    break;
                }
                if (pianino.Key == ConsoleKey.Enter)
                {
                    break;
                }
                Console.Clear();
            } while (true);
            

        }
        static int[] SixOktave()
        {
            int [] oktave6 = new[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976};
            return oktave6;
        }
        static int[] SevenOktave()
        {
            int [] oktave7 = new[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            return oktave7;
        }
        static int[] EightOktave()
        {
            int[] oktave8 = new[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
            return oktave8;
        }
    }
}