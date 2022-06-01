namespace CustomerMicroservice2.Database.Entities
{
    public class Customer
    {
        public int id { get; set; }
        public string PhoneNumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }
    }
}
