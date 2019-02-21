namespace LinqLabExercises
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return CustomerID + "\t" + City;
        }
    }
}