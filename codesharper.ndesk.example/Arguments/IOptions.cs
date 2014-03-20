using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NDesk.Options;

namespace codesharper.ndesk.example.Arguments
{
    public interface IOptions
    {
        OptionSet OptionSet { get; set; }

        string Parse(string[] arguments);

        bool ShowHelp { get; set; }

        void ShowHelpMessage(OptionSet optionSet);
    }
}
