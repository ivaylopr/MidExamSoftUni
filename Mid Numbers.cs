Mid Numbers
List<int> inputSeq = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToList();
string command = string.Empty;
while ((command=Console.ReadLine())!="Finish")
{
    string[] commandArg = command
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    int value = int.Parse(commandArg[1]);

    if (commandArg[0]=="Add")
    {
        inputSeq.Add(value);
    }
    else if (commandArg[0]=="Remove")
    {
        inputSeq.Remove(value);
    }
    else if (commandArg[0]=="Replace")
    {
        int replaceV = int.Parse(commandArg[2]);
        bool isIn = inputSeq.Any(x=>x==value);
        if (isIn)
        {
            int indx = inputSeq.IndexOf(value);
            inputSeq.RemoveAt(indx);
            inputSeq.Insert(indx, replaceV);
        }
    }
    else if (commandArg[0]=="Collapse")
    {
        inputSeq.RemoveAll(x => x < value);
    }
}
Console.WriteLine(String.Join(" ",inputSeq));