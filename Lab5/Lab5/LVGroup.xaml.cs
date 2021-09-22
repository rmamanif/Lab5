using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LVGroup : ContentPage
    {

        private List<PersonList> _listOfPeople;
        public List<PersonList> ListOfPeople { get { return _listOfPeople; } set { _listOfPeople = value; base.OnPropertyChanged(); } }

        public LVGroup()
        {
            InitializeComponent();
        }



    }
}