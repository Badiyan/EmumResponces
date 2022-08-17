using System;

namespace EmumResponses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EResponse response;

            response = EResponse.Continue;

            Console.WriteLine("RESPONSE: text: {0} code: {1}", response, (int)response);
            Console.ReadLine();

            // already exists HttpStatusCode Enum
        }
    }
}
