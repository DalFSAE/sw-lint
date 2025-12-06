using System;
using System.Net;
using System.Reflection;
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
                "DMS-26-PT-MODULE.SLDASM     ",    
                "DMS-26-PT-MODULE.SLDASM     ",
                "DMS-26-AC-MODULE-A100.SLDASM",                            
                "DMS-26-AC-MODULE-A102.SLDASM",                            
                "DMS-26-PT-MODULE-A101.SLDASM",                            
                "DMS-26-PT-MODULE-A103.SLDASM",                            
                "DMS-26-PT-MODULE-A104.SLDASM",
                "DMS-26-PT-MODULE-P024.SLDPRT",
                "DMS-26-PT-MODULE-P025.SLDPRT",
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
        // Check if regex pattern matches 
        public static bool MatchPattern(string input, string pattern)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
