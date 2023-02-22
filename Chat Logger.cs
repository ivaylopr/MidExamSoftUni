Chat Logger
using System;

List<string> chatList = new List<string>();
string command = string.Empty;


while ((command=Console.ReadLine())!= "end")
{
    string[] commandArg = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
    bool isIn = chatList.Contains(commandArg[1]);

    if (commandArg[0]=="Chat")
    {
        chatList.Add(commandArg[1]);
    }
    else if (commandArg[0]=="Delete")
    {
        if (isIn)
        {
            chatList.Remove(commandArg[1]);
        }
    }
    else if (commandArg[0]=="Edit")
    {
        if (isIn)
        {
            string edition = commandArg[2];
            int idexToReplace = chatList.IndexOf(commandArg[1]);
            chatList.RemoveAt(idexToReplace);
            chatList.Insert(idexToReplace, edition);
        }
    }
    else if (commandArg[0]=="Pin")
    {
        if (isIn)
        {
            string elementToMove = commandArg[1];
            chatList.Remove(elementToMove);
            chatList.Add(elementToMove);
        }
    }
    else if (commandArg[0]=="Spam")
    {
        for (int i = 1; i < commandArg.Length; i++)
        {
            chatList.Add(commandArg[i]);
        }
        
    }

}
foreach (var item in chatList)
{
    Console.WriteLine(item);
}