using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdHidden
{
    // ReSharper disable PossibleMultipleEnumeration
    class Program
    {
        public static void Main(params string[] args)
        {
            if (args.Length == 0) return;
            IEnumerable<string> src = args;
            if ((Path.GetExtension(args[0]) ?? "").ToLower() == ".exe")
                src = src.Skip(1);
            var scriptName = src.FirstOrDefault();
            if (string.IsNullOrEmpty(scriptName)) return;
            var argsStr = src.Skip(1).Aggregate("", (res, s) => res + " " + (s.Contains(" ") ? "\"" + s + "\"" : s)).Trim();
            var psi = new ProcessStartInfo(scriptName, argsStr)
            {
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(psi);
        }
    }
}
