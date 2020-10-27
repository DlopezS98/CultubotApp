using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CultuBotApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage_Page : TabbedPage
    {
        public TabbedPage_Page()
        {
            InitializeComponent();
            btnBailar.Clicked += BtnBailar_Clicked;
            btnHistoria.Clicked += BtnHistoria_Clicked;
            btnBailarGigan.Clicked += BtnBailarGigan_Clicked;
            btnHistoriaGigan.Clicked += BtnHistoriaGigan_Clicked;
            btnAboutUs.Clicked += BtnAboutUs_Clicked;
        }

        private void BtnAboutUs_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PageAboutUs());
        }

        private void BtnHistoriaGigan_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PageGigantona());
        }

        private void BtnBailarGigan_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PageBaile());
        }

        private void BtnHistoria_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PageGueguense());
        }

        private void BtnBailar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PageBaile());
        }
    }
}