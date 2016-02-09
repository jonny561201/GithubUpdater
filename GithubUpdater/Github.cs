using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GithubUpdater
{
    public class Github
    {
        string _commandArg;
        private string _workingDirectory;

        public object Clone()
        {
            throw new NotImplementedException();
        }


        public void ExecuteCommand()
        {
            using (var proc = new Process())
            {
                var processStartInfo = new ProcessStartInfo("Git.exe", _commandArg)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    WorkingDirectory = _workingDirectory
                };
            }
        }
    }
}
