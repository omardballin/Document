using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            string document;
            string documentContent;

            Console.WriteLine("Document - ");
            Console.Write("Please enter the name of the document: ");
            document = Console.ReadLine();

            while (document == null || document == "")
            {
                Console.Write("Name of the document cannot be blank");
                document = Console.ReadLine();
            }

            document = document.EndsWith(".txt") ? document.Substring(0, document.IndexOf('.')) : document + ".txt";

            Console.WriteLine("You entered '{0}'", document);
            Console.WriteLine("Please write the content you would like to add to the document");
            documentContent = Console.ReadLine();

            System.IO.File.WriteAllText(document, documentContent);

            Console.WriteLine(document + " has successfully been saved. Press enter to exit");
            Console.ReadLine();

        }
    }
}
