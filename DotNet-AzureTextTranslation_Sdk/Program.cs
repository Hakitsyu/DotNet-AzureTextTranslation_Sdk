using Azure;
using Azure.AI.Translation.Text;
using DotNet_AzureTextTranslation_Sdk;

var key = ConsoleReader.GetKey();
var region = ConsoleReader.GetRegion();

while (true)
{
    try
    {
        var language = ConsoleReader.GetLanguage();
        var text = ConsoleReader.GetText();

        var credential = new AzureKeyCredential(key);
        var client = new TextTranslationClient(credential, region);

        var translations = (await client.TranslateAsync(language, text)).Value;
        var translatedText = translations
            ?.FirstOrDefault()
            ?.Translations
            ?.FirstOrDefault()
            ?.Text;

        Console.WriteLine("Translated text: " + translatedText);
    } catch
    {
        Console.WriteLine("...");
    }
}