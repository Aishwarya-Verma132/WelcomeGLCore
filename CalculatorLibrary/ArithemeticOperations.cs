namespace CalculatorLibrary
{
    public class ArithemeticOperations 
    {
        public int firstNumberField; 
        public int secondNumberField;          
        //properties - readonly, writeonly
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }
        public string result = String.Empty;

        public ArithemeticOperations()
        {

        }
        public ArithemeticOperations(int firstNumberField)
        {
            this.firstNumberField = firstNumberField;   
        }
        public ArithemeticOperations( string result)
        {
            this.result = result;
        }
        public ArithemeticOperations(int firstNumberField, string result)
        {
            this.firstNumberField = firstNumberField;
            this.result = result;
        }
        public ArithemeticOperations(string result , int firstNumberField)
        {
            this.firstNumberField = firstNumberField;
            this.result = result;
        }
        public ArithemeticOperations(int firstNumberField, int secondNumberField)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            
        }
        public ArithemeticOperations(int firstNumberField, int secondNumberField, int firstNumber)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
        }
        public ArithemeticOperations(int firstNumberField, int secondNumberField, int firstNumber, int secondNumber)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }
        public ArithemeticOperations(int firstNumberField, int secondNumberField, int firstNumber, int secondNumber, string result)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.result = result;
        }
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public int Add(int a, int b, int c)
        {
            int d = a + b + c;
            return d;
        }
        public int Subtract(int a, int b)
        {
            int c = a - b;
            return c;
        }
        public int Subtract(int a, int b, int c)
        {
            int d = (a - b)-c;
            return d;
        }
        public int Multiply(int a, int b)
        {
            int c = a * b;
            return c;
        }
        public int Multiply(int a, int b, int c)
        {
            int d = (a * b)*c;
            return d;
        }
        public int Divide(int a, int b)
        {
            int c = a / b;
            return c;
        }
        public int Divide(int a, int b, int c)
        {
            int d = (a / b)/c;
            return d;
        }
    }
    
}