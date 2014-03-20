using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NDesk.Options;

namespace codesharper.ndesk.example.Arguments
{
    public class Options : IOptions
    {
        public Options()
        {
            this.OptionSet = new OptionSet
                                 {
                                     {"speak", "say hello to you", s => this.SayHello = s != null},
                                     {"help", "show this help message then exit", s => this.ShowHelp = s != null}
                                 };
        }

        public string Parse(string[] arguments)
        {
            string message = string.Empty;

            try
            {
                message = string.Join(",", this.OptionSet.Parse(arguments));
            }
            catch (OptionException optionException)
            {
                var str = new StringBuilder();
                str.Append("NDesk Example Application");
                str.AppendLine(optionException.Message);
                message = str.ToString();
            }

            return message;
        }

        public void ShowHelpMessage(OptionSet optionSet)
        {
            Console.WriteLine("Usage: codesharper.ndesk.example.exe [OPTIONS]");
            Console.WriteLine("Example application demonstrating NDESK Options library");
            Console.WriteLine();
            Console.WriteLine("Options:");
            optionSet.WriteOptionDescriptions(Console.Out);
        }

        public void SayHelloMessage()
        {
            Console.WriteLine("Hello there - spoken at " + DateTime.UtcNow.TimeOfDay + " on " + DateTime.UtcNow.ToShortDateString());
        }
        public bool ShowHelp { get; set; }
        public bool SayHello { get; set; }
        public OptionSet OptionSet { get; set; }

    }
}
