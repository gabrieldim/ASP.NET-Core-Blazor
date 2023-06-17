namespace BlazorServerApp.Models
{
    [Serializable]
    public class Car
    {
        public string name { get; set; }
        public int year { get; set; }
        public int price { get; set; }
        public float km { get; set; }
    }
}
