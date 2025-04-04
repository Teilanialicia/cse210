namespace week04
{
    class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(List<Product> products, Customer customer)
        {
            _products = products;
            _customer = customer;
        }


        public List<Product> GetProducts()
        {
            return _products;
        }

        public Customer GetCustomer()
        {
            return _customer;
        }

        public void GetProducts(List<Product> products)
        {
            _products = products;
        }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }

        public double getTotalPrice()
        {
            double total = 0;
            foreach (Product product in _products)
            {
                total = total + product.getTotalCost();
            }

            if (_customer.IsUsa())
                total = total + 5;
            else
                total = total + 35;
            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }

        public string GetPackingLabel()
        {
            string packingLabel = "";
            foreach (Product product in _products)
            {
                packingLabel = packingLabel + $"{product.GetName()} {product.GetId()}\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return $"{_customer.GetName()} - {_customer.GetAddress()}";
        }
    }
}