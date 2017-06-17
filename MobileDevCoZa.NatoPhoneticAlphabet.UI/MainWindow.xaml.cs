using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MobileDevCoZa.NatoPhoneticAlphabet.Interface.BusinessLogic;
using MobileDevCoZa.NatoPhoneticAlphabet.Interface.UserInterface;
using MobileDevCoZa.NatoPhoneticAlphabet.ViewModel;

namespace MobileDevCoZa.NatoPhoneticAlphabet.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        /// <param name="conversionService">The conversion service.</param>
        public MainWindow(IConversionService conversionService)
        {
            InitializeComponent();

            LayoutRoot.DataContext = new CapturedDataViewModel(conversionService);
        }

        /// <summary>
        /// Handles the Click event of the buttonExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Handles the OnTextChanged event of the TextBoxCapturedText control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void TextBoxCapturedText_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var binding = ((TextBox)sender).GetBindingExpression(TextBox.TextProperty);
            binding?.UpdateSource();
        }

        /// <summary>
        /// Handles the OnMouseDoubleClick event of the TextBoxResult control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseButtonEventArgs"/> instance containing the event data.</param>
        private void TextBoxResult_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var textBox = (TextBox) sender;
            textBox.SelectAll();
            Clipboard.SetText(textBox.Text);
        }
    }
}
