using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesharper.ndesk.example
{
    using codesharper.ndesk.example.Arguments;

    public class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();

            if (args == null || args.Length == 0)
            {
                options.ShowHelpMessage(options.OptionSet);
                Console.ReadLine();
                return;
            }

            var parseResult = options.Parse(args);

            if (!string.IsNullOrEmpty(parseResult))
            {
                Console.WriteLine("Error: Invalid option specified: " + parseResult);
                Console.WriteLine();
                options.ShowHelpMessage(options.OptionSet);
                Console.ReadLine();
                return;
            }

            if (options.SayHello)
            {
                options.SayHelloMessage();
                Console.ReadLine();
                return;
            }
        }
    }
}
