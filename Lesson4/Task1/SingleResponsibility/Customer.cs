namespace SingleResponsibility
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private decimal Balance { get; set; }

        public Customer(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void SaveToDatabase()
        {
            Console.WriteLine("Saved!");
        }

        public void UpdateBalance(decimal newBalance)
        {
            Balance = newBalance;
            SaveToDatabase();
        }
    }
}