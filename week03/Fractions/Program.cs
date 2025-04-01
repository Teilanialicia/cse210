namespace week03
{
    class Fraction 
    {
        private int _top;
        private int _bottom;

        Fraction(){
            _top = 1;
            _bottom = 1;
        }
        Fraction(int top){
            
            _top = top;
            _bottom = 1;
        }
        Fraction(int top, int bottom){
            _top = top;
            _bottom = bottom;
        }
        
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction();
            Fraction fractiona = new Fraction(5);
            Fraction fractionb = new Fraction(3,4);
            Fraction fractionc = new Fraction(1,3);

            Console.WriteLine(fraction.GetFractionString());
            Console.WriteLine(fraction.GetDecimalValue());

            Console.WriteLine(fractiona.GetFractionString());
            Console.WriteLine(fractiona.GetDecimalValue());

            Console.WriteLine(fractionb.GetFractionString());
            Console.WriteLine(fractionb.GetDecimalValue());

            Console.WriteLine(fractionc.GetFractionString());
            Console.WriteLine(fractionc.GetDecimalValue());
        }

        public int GetTop(){
            return _top;
        } 

        public void SetTop(int top){
            _top = top;
        }

        public int GetBottom(){
            return _bottom;
        }

        public void SetBottom(int bottom){
            _bottom = bottom;
        }
        
        public string GetFractionString(){
            return $"{_top}/{_bottom}";
        }

        public double GetDecimalValue(){
            return _top / (double)_bottom;
        }
    }
}