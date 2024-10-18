using System;
using LibrairieConversionNote;  // Ajouter la librairie

namespace SDK_Laboratoire1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Créer une instance du convertisseur
            ConversionAlphabetiqueToNote conversion = new ConversionAlphabetiqueToNote();

            while (true)  // Boucle infinie pour demander des conversions
            {
                Console.WriteLine("Quel type de conversion souhaitez-vous faire? Tapez 'NOTE' pour convertir une note alphabétique en note syllabe. Tapez 'CTRL+C' pour quitter.");

                string typeConversion = Console.ReadLine().ToUpper();  // Lire le type de conversion

                if (typeConversion == "NOTE")  // Conversion alphabétique vers note
                {
                    while (true)
                    {
                        Console.WriteLine("Entrez une lettre alphabétique (A à G) à convertir :");

                        string note = Console.ReadLine();  // Lire la note alphabétique

                        // Utiliser la méthode Transformer pour convertir la note
                        string resultat = conversion.Transformer(note);
                        Console.WriteLine(resultat);  // Afficher le résultat
                    }
                }
                else
                {
                    Console.WriteLine("Commande non reconnue. Tapez 'NOTE' ou utilisez 'CTRL+C' pour quitter.");
                }
            }
        }
    }
}
