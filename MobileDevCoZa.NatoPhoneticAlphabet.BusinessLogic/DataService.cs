using System.Collections.Generic;
using MobileDevCoZa.NatoPhoneticAlphabet.Interface.BusinessLogic;

namespace MobileDevCoZa.NatoPhoneticAlphabet.BusinessLogic
{
    /// <summary>
    /// Data service
    /// </summary>
    public class DataService : IDataService
    {
        /// <summary>
        /// Natoes the phonetic letters.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> NatoPhoneticLetters()
        {
            return new Dictionary<string, string>()
            {
                { "a", "alfa" },
                { "b", "bravo" },
                { "c", "charlie" },
                { "d", "delta" },
                { "e", "echo" },
                { "f", "foxtrot" },
                { "g", "golf" },
                { "h", "hotel" },
                { "i", "india" },
                { "j", "juliett" },
                { "k", "kilo" },
                { "l", "lima" },
                { "m", "mike" },
                { "n", "november" },
                { "o", "oscar" },
                { "p", "papa" },
                { "q", "quebec" },
                { "r", "romeo" },
                { "s", "sierra" },
                { "t", "tango" },
                { "u", "uniform" },
                { "v", "victor" },
                { "w", "whiskey" },
                { "x", "x-ray" },
                { "y", "yankee" },
                { "z", "zulu" },
                { "A", "ALFA" },
                { "B", "BRAVO" },
                { "C", "CHARLIE" },
                { "D", "DELTA" },
                { "E", "ECHO" },
                { "F", "FOXTROT" },
                { "G", "GOLF" },
                { "H", "HOTEL" },
                { "I", "INDIA" },
                { "J", "JULIETT" },
                { "K", "KILO" },
                { "L", "LIMA" },
                { "M", "MIKE" },
                { "N", "NOVEMBER" },
                { "O", "OSCAR" },
                { "P", "PAPA" },
                { "Q", "QUEBEC" },
                { "R", "ROMEO" },
                { "S", "SIERRA" },
                { "T", "TANGO" },
                { "U", "UNIFORM" },
                { "V", "VICTOR" },
                { "W", "WHISKEY" },
                { "X", "X-RAY" },
                { "Y", "YANKEE" },
                { "Z", "ZULU" },
                { " ", "[space]" }
            };
        }
    }
}
