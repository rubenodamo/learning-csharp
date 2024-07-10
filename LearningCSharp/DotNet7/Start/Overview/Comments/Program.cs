// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags
using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// This is the main sample application function
        /// </summary>
        /// <param name = 'args'> An array of string arguments fromt he command line </param>
        /// <returns>
        /// no return value
        /// </returns>
        static void Main(string[] args)
        {
            
            // Single line comments 
            /* Multi line comments */ 
            Console.WriteLine("Hello World!");

        }
    }
}
