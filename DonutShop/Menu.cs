using System;

public class PlainChoco: PlainDoughnut
{
	public PlainChoco()
	{
		Console.WriteLine("PlainChoco");
		Console.WriteLine("Toppings: ");
		toppings[tCount++] = new ChocoGlaze();
	}
}

public class PlainStrawberry: PlainDoughnut
{
	public PlainStrawberry()
    {
		Console.WriteLine("PlainStrawberry");
		Console.WriteLine("Toppings: ");
		toppings[tCount++] = new StrawberryGlaze();
    }
}

public class ChocoCrunch : PlainChoco
{
	public ChocoCrunch()
    {
		Console.WriteLine("ChocoCrunch");
		Console.WriteLine("Toppings: ");
		toppings[tCount++] = new PeanutCrunch();
    }
}

public class StrawberrrySprinkles : PlainStrawberry
{
	public StrawberrrySprinkles()
    {
		Console.WriteLine("StrawberrySprinkles");
		Console.WriteLine("Toppings: ");
		toppings[tCount++] = new CandySprinkles();
    }
}

public class CinnamonCrunch : PlainDoughnut
{
	public CinnamonCrunch()
    {
		Console.WriteLine("CinnamonCrunch");
		Console.WriteLine("Toppings: ");
		toppings[tCount++] = new CinnamonDust();
		toppings[tCount++] = new PeanutCrunch();
    }
}