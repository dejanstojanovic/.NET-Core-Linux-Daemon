using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Sample
{
    class Program
    {
        static CancellationTokenSource tokenSource = new CancellationTokenSource();
        static void Main(string[] args)
        {
            String outFolderPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "output");
            String outFilePath = Path.Combine(outFolderPath, $"{DateTime.Now.ToString("yyyy-MM-dd")}.txt");

            if(!Directory.Exists(outFolderPath))
            {
                Directory.CreateDirectory(outFolderPath);
            }

            Console.WriteLine($"Output file: {outFilePath}");

            File.AppendAllLines(outFilePath, new List<String>() { "------------------- SERVICE START ------------------ - " }, Encoding.UTF8);

            while (!tokenSource.Token.IsCancellationRequested)
            {
                File.AppendAllLines(outFilePath, new List<String>() { DateTime.Now.ToString() }, Encoding.UTF8);

                Console.WriteLine(DateTime.Now);

                Thread.Sleep(1000);
            }

            File.AppendAllLines(outFilePath, new List<String>() { "------------------- SERVICE STOP ------------------ - " }, Encoding.UTF8);
        }

    }
}
