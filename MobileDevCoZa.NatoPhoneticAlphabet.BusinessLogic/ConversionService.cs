using System;
using System.Text;
using MobileDevCoZa.NatoPhoneticAlphabet.Interface.BusinessLogic;

namespace MobileDevCoZa.NatoPhoneticAlphabet.BusinessLogic
{
    /// <summary>
    /// Conversion service
    /// </summary>
    /// <seealso cref="MobileDevCoZa.NatoPhoneticAlphabet.Interface.BusinessLogic.IConversionService" />
    public class ConversionService : IConversionService
    {
        /// <summary>
        /// The data service
        /// </summary>
        private readonly IDataService _dataService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionService"/> class.
        /// </summary>
        /// <param name="dataService">The data service.</param>
        public ConversionService(IDataService dataService)
        {
            _dataService = dataService;
        }

        /// <summary>
        /// Converts the text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public string ConvertText(string text)
        {
            var data = _dataService.NatoPhoneticLetters();
            var returnValue = new StringBuilder();

            foreach (var character in text)
            {
                if (returnValue.Length > 0)
                    returnValue.AppendFormat(" ");

                var characterString = Convert.ToString(character);

                returnValue.Append(data.ContainsKey(characterString) ? data[characterString] : characterString);
            }

            return returnValue.ToString();
        }
    }
}
