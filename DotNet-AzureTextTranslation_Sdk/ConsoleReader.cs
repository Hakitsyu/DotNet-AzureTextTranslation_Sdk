using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_AzureTextTranslation_Sdk
{
    public static class ConsoleReader
    {
        public static string GetKey()
        {
            Console.WriteLine("What's your translator key?");
            return ForceReadLine("Enter a valid key...");
        }

        public static string GetRegion()
        {
            Console.WriteLine("What's your translator region?");
            return ForceReadLine("Enter a valida region...");
        }

        public static string GetLanguage()
        {
            Console.WriteLine("Which language do you want to translate into?");
            return ForceReadLine("Enter a valid language...");
        }

        public static string GetText()
        {
            Console.WriteLine("What do you want to translate?");
            return ForceReadLine("Enter a valid text...");
        }

        private static string ForceReadLine(string? retryMessage = null)
        {
            string? content = null;

            do
            {
                content = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(retryMessage) && string.IsNullOrWhiteSpace(content))
                {
                    Console.WriteLine(retryMessage);
                }

            } while (string.IsNullOrWhiteSpace(content));

            return content;
        }
    }
}
