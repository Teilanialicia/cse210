namespace week04
{
    class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, string streetAddress, string city, string state, string country)
        {
            _name = name;
            _address = new Address(streetAddress, city, state, country);
        }

        public string GetName()
        {
            return _name;
        }

        public string GetAddress()
        {
            return _address.GetFullAddress();
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetAddress(Address address)
        {
            _address = address;
        }

        public bool IsUsa()
        {
            return _address.IsUsa();
        }
    }
}