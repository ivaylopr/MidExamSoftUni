Space Ship
string[] input = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();
int fuel = int.Parse(Console.ReadLine());
int amunition = int.Parse(Console.ReadLine());
bool isFailed=false;
for (int i = 0; i < input.Length; i++)
{
    string[] command = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
	if (command[0]=="Travel")
	{
		if (fuel >= int.Parse(command[1]))
		{
			fuel-=int.Parse(command[1]);
			Console.WriteLine($"The spaceship travelled {command[1]} light-years.");
		}
		else
		{
			Console.WriteLine("Mission failed");
			
			break;
			
		}
	}
	else if (command[0]=="Enemy")
	{
		int enemyArmour = int.Parse(command[1]);
		if (amunition>=enemyArmour)
		{
			amunition-=enemyArmour;
			Console.WriteLine($"An enemy with {enemyArmour} armour is defeated.");
		}
		else
		{
			if (fuel>=enemyArmour*2)
			{
				Console.WriteLine($"An enemy with {enemyArmour} armour is outmaneuvered");
			}
			else
			{
				Console.WriteLine("Mission failed");
				isFailed=true;
			}
		}
		if (isFailed)
		{
			break;
		}
	}
	else if (command[0]=="Repair")
	{
		int pointsAdded = int.Parse(command[1]);
		fuel+=pointsAdded;
		int munitionAdd = pointsAdded*2;
		amunition = munitionAdd;
		Console.WriteLine($"Ammunitions added: {munitionAdd}.");
		Console.WriteLine($"Fuel added: {pointsAdded}".);
	}
	else if (command[0]=="Titan")
	{
		Console.WriteLine("You have reached Titan, all passengers are safe.");
		break;
	}
}
