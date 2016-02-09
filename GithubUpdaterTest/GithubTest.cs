using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GithubUpdater
{
    [TestFixture]
    public class GithubTest
    {
        private readonly Github github = new Github();
        [Test]
        public string ShouldPushToGithub()
        {
            var clone = github.Clone();
            return clone;
        }
    }
}
