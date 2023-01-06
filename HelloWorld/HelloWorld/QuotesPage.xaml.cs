

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
    {
        private string[] _Quotes = new[]
        {
            "What is right is not always popular, and what is popular is not always right.",
            "Education is what remains after one has forgotten what one has learned in school.",
            "Not everything that can be counted counts and not everything that counts can be counted.",
            "Everybody is a genius. But if you judge a fish by its ability to climb a tree, it will live its whole life believing that it is stupid.",
            "You can’t blame gravity for falling in love.",
            "Common sense is the collection of prejudices acquired by age eighteen."
        };

        private int _QuoteIndex = 0;
		public QuotesPage ()
		{
			InitializeComponent ();
            QuotesLabel.Text = _Quotes[_QuoteIndex];
        }


        private void NextButton_OnClicked(object sender, EventArgs e)
        {
            QuotesLabel.Text = _Quotes[++_QuoteIndex];
        }
    }
}