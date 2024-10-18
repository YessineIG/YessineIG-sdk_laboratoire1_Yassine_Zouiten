using System;

namespace SDK_Laboratoire1
{
    public class ConversionAlphabetiqueToNote
    {
        public string Transformer(string lettre)
        {
            switch (lettre.ToUpper())
            {
                case "A": return "LA";
                case "B": return "SI";
                case "C": return "DO";
                case "D": return "RÉ";
                case "E": return "MI";
                case "F": return "FA";
                case "G": return "SOL";
                default: return "Note inconnue. Veuillez entrer une lettre de A à G.";
            }
        }
    }
}

namespace SDK_Laboratoire1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversionAlphabetiqueToNote conversion = new ConversionAlphabetiqueToNote();

            while (true)
            {
                Console.WriteLine("Entrez une lettre de A à G pour obtenir la note correspondante (ou 'exit' pour quitter) : ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                string result = conversion.Transformer(input);
                Console.WriteLine(result);
            }
        }
    }
}
