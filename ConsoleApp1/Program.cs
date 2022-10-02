using System;

namespace MPT_Pianino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Клавиши при которых будет звучание:");
            Console.WriteLine("Q,W,E,R,T,Y,U");
            Console.WriteLine("A,S,D,F,G");
            Console.WriteLine("Z,X,C,B");
            Console.WriteLine("___________________________________________________");
        musika:
            int[] firstOctave = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493, 522, 554, 586, 622, 658 };
            ConsoleKeyInfo KeyInfo;
            KeyInfo = Console.ReadKey(true);
            switch (KeyInfo.Key)
            {
                case ConsoleKey.Q:
                    Console.Beep(firstOctave[0], 250);
                    break;
                case ConsoleKey.A:
                    Console.Beep(firstOctave[1], 250);
                    break;
                case ConsoleKey.W:
                    Console.Beep(firstOctave[2], 250);
                    break;
                case ConsoleKey.S:
                    Console.Beep(firstOctave[3], 250);
                    break;
                case ConsoleKey.E:
                    Console.Beep(firstOctave[4], 250);
                    break;
                case ConsoleKey.R:
                    Console.Beep(firstOctave[5], 250);
                    break;
                case ConsoleKey.D:
                    Console.Beep(firstOctave[6], 250);
                    break;
                case ConsoleKey.T:
                    Console.Beep(firstOctave[7], 250);
                    break;
                case ConsoleKey.F:
                    Console.Beep(firstOctave[8], 250);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(firstOctave[9], 250);
                    break;
                case ConsoleKey.G:
                    Console.Beep(firstOctave[10], 250);
                    break;
                case ConsoleKey.U:
                    Console.Beep(firstOctave[11], 250);
                    break;
                case ConsoleKey.Z:
                    Console.Beep(firstOctave[12], 250);
                    break;
                case ConsoleKey.X:
                    Console.Beep(firstOctave[13], 250);
                    break;
                case ConsoleKey.C:
                    Console.Beep(firstOctave[14], 250);
                    break;
                case ConsoleKey.V:
                    Console.Beep(firstOctave[15], 250);
                    break;
                case ConsoleKey.B:
                    Console.Beep(firstOctave[16], 250);
                    break;
            }
            goto musika;
        }
    }
}
//       C  C#  D   D# E    F   F#  G    G#   A   A#   B    C2    C2#   D2   D2#    E2
//       0  1   2   3  4    5   6   7    8    9   10   11   12    13    14   15     16