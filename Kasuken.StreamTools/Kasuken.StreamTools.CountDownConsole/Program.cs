using System;
using System.IO;
using System.Threading;

namespace Kasuken.StreamTools.CountDownConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var countdownWorker = new CountdownWorker();

            var seconds = ParseArgsForSeconds(args[0]);
            countdownWorker.Start(seconds);

            do
            {
                Thread.Sleep(1000);

                Console.Clear();
                Console.WriteLine(countdownWorker.FormatResult());

                WriteFile(countdownWorker.FormatResult());

                countdownWorker.Tick();

            } while (countdownWorker.TotalSeconds != 0);
        }

        private static int ParseArgsForSeconds(string arg)
        {
            return int.Parse(arg);
        }

        private static void WriteFile(string input)
        {
            File.WriteAllText("countdownToStart.txt", input);
        }
    }
}
