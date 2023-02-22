Burger Bus
int numberOf = int.Parse(Console.ReadLine());   
string nameOfTheCity = string.Empty;
double profCity = 0;
double expensCity = 0;
double totalProfit = 0;

for (int i = 1; i <= numberOf; i++)
{
    nameOfTheCity = Console.ReadLine();
    profCity = double.Parse(Console.ReadLine());
    expensCity = double.Parse(Console.ReadLine());
    if (i % 5 == 0)
    {
        profCity -= profCity * 0.1;
    }
    else if (i%3==0 && i%5!=0)
    {
        expensCity += expensCity * 0.5;
    }
    profCity-=expensCity;
    totalProfit+=profCity;
    Console.WriteLine($"In {nameOfTheCity} Burger Bus earned {profCity:F2} leva.");
}
Console.WriteLine($"Burger Bus total profit: {totalProfit:F2} leva.");