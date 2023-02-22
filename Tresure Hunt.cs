Tresure Hunt
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

List<string> tresure = Console.ReadLine()
    .Split('|',StringSplitOptions.RemoveEmptyEntries)
    .ToList() ;
string command = string.Empty;

while ((command=Console.ReadLine())!="Yohoho!")
{
    string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    if (commandArg[0]=="Loot")
    {
        for (int i = 1; i < commandArg.Length; i++)
        {
            if (!tresure.Contains(commandArg[i]))
            {
                tresure.Insert(0, commandArg[i]);
            }
        }
    }
    else if (commandArg[0]=="Drop")
    {
        int index = int.Parse(commandArg[1]);
        if (index>=0 && index<=tresure.Count-1)
        {
            string elementToMove = tresure[index];
            tresure.RemoveAt(index);
            tresure.Add(elementToMove);
        }

    }
    else if (commandArg[0]=="Steal")
    {
        int count = int.Parse(commandArg[1]);
        List<string> stealedEl = new List<string>();
        int indexOfTheStart = tresure.Count - count;

        if (count>tresure.Count)
        {
            count= tresure.Count;
            indexOfTheStart = 0;
        }
        for (int i = 1; i <=count; i++)
        {
            stealedEl.Add(tresure[indexOfTheStart]);
            tresure.RemoveAt(indexOfTheStart);
          
        }
            
        Console.WriteLine(String.Join(", ",stealedEl));
    }
}
double avarage = 0;
int sum = 0;

int countOfEl = tresure.Count;
foreach (var item in tresure)
{
    int itemValue = item.Length;
        sum += itemValue;

}
avarage = (double)sum / countOfEl;
if (tresure.Count!=0)
{
    Console.WriteLine($"Average treasure gain: {avarage:F2} pirate credits.");
}
else
{
    Console.WriteLine("Failed treasure hunt.");
}