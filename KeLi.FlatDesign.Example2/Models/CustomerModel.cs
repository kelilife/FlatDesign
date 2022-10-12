namespace KeLi.FlatDesign.Example2.Models
{
    public class CustomerModel
    {
        private static int _id;

        public CustomerModel()
        {
            _id++;

            Id = _id;
        }

        public int Id { get; set; }

        public string CustomerName { get; set; }

        public bool IsMale { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}