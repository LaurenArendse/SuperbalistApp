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

        public string Image { get; set; }

        public Category(string name, string color, string image)
        {
            Name = name;
            Color = color;
            Image= image;
            
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
                new Category("OFFERS", "LightGreen",""),
                new Category("BRANDS", "lightgray",""),
                new Category("NEW IN", "lightgray",""),
                new Category("ACCESSORIES", "lightgray","accessories.jpg"),
                new Category("BEAUTY", "lightgray","beauty.jpg"),
                new Category("BOTTOMS", "lightgray","bottoms.jpg"),
                new Category("DRESSES", "lightgray","dress.jpg"),
                new Category("JACKETS & COATS", "lightgray","jacketscoats.jpg"),
                new Category("LINGERIE & SLEEPWEAR", "lightgray","lingeriesleepwear.jpg"),         
                new Category("PLUS SIZE", "lightgray","plussize.jpg"),
                new Category("SHOES", "lightgray","shoes.jpg"),
                new Category("SPORT", "lightgray","sport.jpg"),
                new Category("SWIMWEAR", "lightgray","swimwear.jpg"),
                new Category("TOPS", "lightgray","tops.jpg"),
                new Category("SALE", "lightgray",""),
            };

            BindingContext = this;
        }
    }
}