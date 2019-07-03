using System;
using System.IO;
using System.Linq;
using System.Reflection;

using NUnit.Framework;

namespace MenuCreator.Tests
{
    [TestFixture]
    public class MenuItemTests
    {
        [Test]
        public void Should_Test()
        {
            var menuText = "";
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith("MenuData-1.txt", StringComparison.CurrentCulture));

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                menuText = reader.ReadToEnd();
            }

            foreach (var s in menuText.Split(Environment.NewLine))
            {
                //s.ToCharArray().Where(char.IsControl).ToList().ForEach(c =>
                //{
                //    Console.Write(c);
                //});

                //var line = s.Trim().Trim('-');

                var indent = s.ToCharArray().Count(x => x == '\t');
                Console.WriteLine($"{indent}{s}");
                if (s[0] == '\t')
                {
                    //Console.WriteLine($"-tab{s}");
                }
            }
        }
    }
}
