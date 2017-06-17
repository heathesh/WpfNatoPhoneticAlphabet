namespace MobileDevCoZa.NatoPhoneticAlphabet.Interface.BusinessLogic
{
    /// <summary>
    /// Conversion service interface
    /// </summary>
    public interface IConversionService
    {
        /// <summary>
        /// Converts the text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        string ConvertText(string text);
    }
}
