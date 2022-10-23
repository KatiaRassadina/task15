//Программа принимает цифру, обозначающую день недели и проверяет, является ли этот день выходным
Console.WriteLine("Input number from 1 to 7");
int n = Convert.ToInt32(Console.ReadLine());
if(n<1 | n>7)
{
    Console.WriteLine("not suitable");
}
if(n>=1 & n<=5)
{
    Console.WriteLine("not weekend");
    }
if(n==6 | n==7)
    {
        Console.WriteLine("weekend");
    }        
