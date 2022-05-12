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
    public class Category
    {
        public string Name { get; set; }

        public string Color { get; set; }

        //public string Image { get; set; }

        public Category(string name, string color)
        {
            Name = name;
            Color = color;
            
        }

        
    }


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public ObservableCollection<Category> Categories { get; set; }

        public SearchPage()
        {
            InitializeComponent();

            Categories = new ObservableCollection<Category>
            {
                new Category("OFFERS", "LightGreen"),
                new Category("brands", "lightgray"),
                new Category("new in", "lightgray"),
                new Category("accessories", "lightgray"),
                new Category("beauty", "lightgray"),
                new Category("bottoms", "lightgray"),
                new Category("dresses", "lightgray"),
                new Category("jackets & coats", "lightgray"),
                new Category("lingerie & sleepwear", "lightgray"),
                new Category("maternity", "lightgray"),
                new Category("petite", "lightgray"),
                new Category("plus size", "lightgray"),
                new Category("shoes", "lightgray"),
                new Category("sport", "lightgray"),
                new Category("swimwear", "lightgray"),
                new Category("tops", "lightgray"),
                new Category("sale", "lightgray"),
            };

            BindingContext = this;
        }
    }
}