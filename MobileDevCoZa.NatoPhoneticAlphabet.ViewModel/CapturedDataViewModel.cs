using System.ComponentModel;
using System.Runtime.CompilerServices;
using MobileDevCoZa.NatoPhoneticAlphabet.Interface.BusinessLogic;
using MobileDevCoZa.NatoPhoneticAlphabet.Model;
using MobileDevCoZa.NatoPhoneticAlphabet.Model.Annotations;

namespace MobileDevCoZa.NatoPhoneticAlphabet.ViewModel
{
    /// <summary>
    /// Captured data view model
    /// </summary>
    /// <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
    public class CapturedDataViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The conversion service
        /// </summary>
        private readonly IConversionService _conversionService;

        /// <summary>
        /// The captured data
        /// </summary>
        private readonly CapturedData _capturedData;

        /// <summary>
        /// Initializes a new instance of the <see cref="CapturedDataViewModel"/> class.
        /// </summary>
        /// <param name="conversionService">The conversion service.</param>
        public CapturedDataViewModel(IConversionService conversionService)
        {
            _conversionService = conversionService;
            _capturedData = new CapturedData();
        }

        /// <summary>
        /// Gets or sets the captured text.
        /// </summary>
        /// <value>
        /// The captured text.
        /// </value>
        public string CapturedText
        {
            get => _capturedData.CapturedText;
            set
            {
                if (_capturedData.CapturedText == value) return;
                _capturedData.CapturedText = value;
                OnPropertyChanged(nameof(CapturedText));

                Result = _conversionService.ConvertText(value);
            }
        }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public string Result
        {
            get => _capturedData.Result;
            set
            {
                if (_capturedData.Result == value) return;
                _capturedData.Result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Called when [property changed].
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
