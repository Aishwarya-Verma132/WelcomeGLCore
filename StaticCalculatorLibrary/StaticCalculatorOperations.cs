namespace StaticCalculatorLibrary
{
    public static class StaticCalculatorOperations
    {
        public static int result = 0;

        public static int resultProperty { get; set; }

        static StaticCalculatorOperations()
        {

        }
        public static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        
        public static int Subtract(int a, int b)
        {
            int c = a - b;
            return c;
        }
        
        public static int Multiply(int a, int b)
        {
            int c = a * b;
            return c;
        }
        
        public static int Divide(int a, int b)
        {
            int c = a / b;
            return c;
        }
        
    }
}