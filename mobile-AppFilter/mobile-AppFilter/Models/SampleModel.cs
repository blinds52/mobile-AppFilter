using Windows.UI.Xaml.Controls;

namespace mobile_AppFilter.Models
{
    public class SampleModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Symbol Symbol { get; set; }

        public char SymbolAsChar
        {
            get { return (char)Symbol; }
        }
    }
}
