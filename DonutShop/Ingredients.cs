using System;

public interface Topping
{
	double cost { get; }
}

public class PlainDoughnut
{
	protected Topping[] toppings = new Topping[5];
	protected int tCount;
	private double cost;

	public PlainDoughnut()
	{
		Console.WriteLine("PlainDoughnut");
		cost = 20.00;
		tCount = 0;
	}

	public double ComputeCost()
    {
		foreach(Topping t in toppings)
        {
			if (t != null) cost += t.cost;
        }
		return cost;
    }
}

public class ChocoGlaze: Topping
{
	public ChocoGlaze()
    {
		Console.WriteLine("...ChocoGlaze");
    }
	public double cost
    {
		get { return 5.00;  }
    }
}

public class StrawberryGlaze: Topping
{
	public StrawberryGlaze()
    {
		Console.WriteLine("..StrawberryGlaze");
    }
	public double cost
    {
		get { return 3.00;  }
    }
}

public class CandySprinkles: Topping
{
	public CandySprinkles()
    {
		Console.WriteLine("..CandySprinkles");
    }
	public double cost
    {
		get { return 1.50;  }
    }
}

public class PeanutCrunch: Topping
{
	public PeanutCrunch()
    {
		Console.WriteLine("...PeanutCrunch");
    }
	public double cost
    {
		get { return 1.75; }
    }
}

public class CinnamonDust : Topping
{
	public CinnamonDust()
    {
		Console.WriteLine("...CinnamonDust");
    }
	public double cost
    {
		get { return 1.25; }
    }
}