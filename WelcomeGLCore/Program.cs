// See https://aka.ms/new-console-template for more information
using CalculatorLibrary;

CalculateOperations operations = new CalculateOperations(); 
ExtraOperations extraOps = new ExtraOperations();
int result = operations.Add(10, 10);
int sub = operations.Subtract(20, 10);
int multiply = operations.Multiply(10, 10);
int divide = operations.Divide(100, 10);
int squareRoot = extraOps.Sq(64);
int AddThree = extraOps.AddNum(5, 10, 15);
string Company = extraOps.Concat("Global", "Logic");
Console.WriteLine(result.ToString());
Console.WriteLine(sub.ToString());
Console.WriteLine(multiply.ToString());
Console.WriteLine(divide.ToString());
Console.WriteLine(squareRoot.ToString());
Console.WriteLine(AddThree.ToString());
Console.WriteLine(Company.ToString());
Console.ReadLine();
