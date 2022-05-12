using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuperbalistApp
{

    public class Option
    {
        public string OptionItem { get; set; }

        public string Icon { get; set; }

        public Option(string optionItem, string icon)
        {
            OptionItem = optionItem;
            Icon = icon;
        }
    }


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {

        public ObservableCollection<Option> Options { get; set; }
        public ProfilePage()
        {
            InitializeComponent();

            Options = new ObservableCollection<Option>
            {
                new Option("Track my order", "trackIcon.png"),
                new Option("Log a Return or Exchange", "exchangeIcon.png"),
                new Option("Account", "profileIcon.png"),
                new Option("Help", "helpIcon.png"),
                new Option("Takealot.group", "takealotIcon.png"),
                new Option("    Sign Out", ""),
                new Option("    Rate the app", ""),
            };

            BindingContext = this;

        }
    }
}