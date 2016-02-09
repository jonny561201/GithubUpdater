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
        private string _githubURL = "https://github.com/jonny561201/GithubUpdater";
        private string _workingDirectory = "./";

        public string Clone()
        {
            var cmd = "clone " + _githubURL;
            return ExecuteCommand(cmd);
        }


        private string ExecuteCommand(string commandArg)
        {
            using (var proc = new Process())
            {
                var processStartInfo = new ProcessStartInfo("Git.exe", commandArg)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    WorkingDirectory = _workingDirectory
                };

                proc.StartInfo = processStartInfo;
                proc.Start();
                var result = proc.StandardOutput.ReadToEnd();
                var errorResult = proc.StandardError.ReadToEnd();

                return result + errorResult;
            }
        }
    }
}
