// See https://aka.ms/new-console-template for more information




 Console.WriteLine("Please enter No1");
int no1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter No2");
int no2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nEnter 1 for Addition: " );
Console.WriteLine("\nEnter 2 for Subtraction: ");
Console.WriteLine("\nEnter 3 for Multiplication: ");
Console.WriteLine("\nEnter 4 for Division: ");
Console.WriteLine("\nPlease enter your choice:");
int op = Convert.ToInt32(Console.ReadLine());

Calculator calculator = new Calculator();

if (op >= 1 && op <= 4)
{
    switch (op)
    {
        case 1:
            Console.WriteLine("Addition is:  " + (no1 + no2)); break;
        case 2:
            Console.WriteLine("Subtraction is: " + (no1 - no2)); break;
        case 3:
            Console.WriteLine("Multiplication is : " + (no1 * no2)); break;
        case 4:
            Console.WriteLine("Division is : " + (no1 / no2)); break;
    }
}
else
{
    Console.WriteLine("Sorry!!!! Wrong choice");
}