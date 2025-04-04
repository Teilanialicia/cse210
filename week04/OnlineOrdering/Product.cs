namespace week04
{
    class Product
    {
        private string _name;
        private int _id;
        private double _price;
        private int _quantity;

        public Product(string name, int id, double price, int quantity)
        {
            _name = name;
            _id = id;
            _price = price;
            _quantity = quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetId()
        {
            return _id;
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public double getTotalCost()
        {
            return _price * _quantity;
        }
    }
}