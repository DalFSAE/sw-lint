using System;
using System.Text.RegularExpressions;

namespace SwLint.Core.Rules
{
    public static class FileNamePatternRules
    {
        public static void Run()
        {
            Demo();
        }

        public static void Demo()
        {

            string[] partNumbers =
            {
                "1298-673-4192",
                "A08Z-931-468a",
                "_A90-123-129X",
                "12345-KKA-1230",
                "0919-2893-1256"
            };

            string pattern = @"^[A-Z0-9]\d{2}[A-Z0-9](-\d{3}){2}[A-Z0-9]$";

            foreach (string partNumber in partNumbers)
            {
                try
                {
                    bool isMatch = Regex.IsMatch(
                        partNumber,
                        pattern,
                        RegexOptions.IgnoreCase,
                        TimeSpan.FromMilliseconds(500)
                    );

            Console.WriteLine(
                        $"{partNumber} {(isMatch ? "is" : "is not")} a valid part number."
                    );
                }
                catch (RegexMatchTimeoutException e)
                {
                    Console.WriteLine(
                        $"Timeout after {e.MatchTimeout} seconds matching {e.Input}."
                    );
                }
            }
        }
    }
}
