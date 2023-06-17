using BlazorServerApp.Models;

namespace BlazorServerApp.Pages
{
    public partial class Index
    {
        private List<Contact> contacts;
        private Dictionary<string, object> textBoxAttributes = new Dictionary<string, object>
    {
         { "disabled","disabled" },
         { "placeholder","First Name" },
    };

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(3500);
            contacts = new List<Contact>
        {
            new Contact
            {
                firstName = "John",
                lastName = "Smith",
                email = "john.smith@example.com"
            },
            new Contact
            {
                firstName = "Emma",
                lastName = "Johnson",
                email = "emma.johnson@example.com"
            },
            new Contact
            {
                firstName = "Michael",
                lastName = "Davis",
                email = "michael.davis@example.com"
            },
        };
            base.OnInitializedAsync();
        }

    }
}
