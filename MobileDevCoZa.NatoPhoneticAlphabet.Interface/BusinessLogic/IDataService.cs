using System.Collections.Generic;

namespace MobileDevCoZa.NatoPhoneticAlphabet.Interface.BusinessLogic
{
    /// <summary>
    /// Data service interface
    /// </summary>
    public interface IDataService
    {
        /// <summary>
        /// Natoes the phonetic letters.
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> NatoPhoneticLetters();
    }
}
