using BlazorServerApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Pages
{
    public partial class CarList : ComponentBase
    {
        private List<Car> carList;

        public CarList()
        {
            carList = new List<Car>
            {
                new Car
            {
                name = "Toyota",
                year = 2008,
                price = 6000,
                km = 205000
            },
            new Car
            {
                name = "Golf 5 Plus",
                year = 2009,
                price = 5000,
                km = 180000
            },
            new Car
            {
                name = "Citroen C4",
                year = 2006,
                price = 3800,
                km = 210000
            },
            new Car
            {
                name = "KIA",
                year = 2012,
                price = 5300,
                km = 165000
            },
            new Car
            {
                name = "Nissan",
                year = 2010,
                price = 4800,
                km = 170000
            },
            new Car
            {
                name = "Citroen C3",
                year = 2004,
                price = 3500,
                km = 193000
            },
           };
        }

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(3500);
            await base.OnInitializedAsync();
        }
    }
}