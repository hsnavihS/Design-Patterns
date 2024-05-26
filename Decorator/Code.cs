using System;

abstract class Beverage {
	public abstract string getDescription();
	public abstract int cost();
}

class Decaf : Beverage {
	public override string getDescription() {
		return "Decaf";
	}

	public override int cost() {
		return 100;
	}
}

class Espresso : Beverage {
	public override string getDescription() {
		return "Espresso";
	}

	public override int cost() {
		return 200;
	}
}

abstract class CondimentDecorator : Beverage {
	public abstract override string getDescription();
	public abstract override int cost();
}

class Milk : CondimentDecorator {
	private Beverage beverage;

	public Milk(Beverage beverage) {
		this.beverage = beverage;
	}

	public override string getDescription() {
		return "Milk + " + this.beverage.getDescription();
	}

	public override int cost() {
		return 50 + this.beverage.cost();
	}
}

class Caramel : CondimentDecorator {
	private Beverage beverage;

	public Caramel(Beverage beverage) {
		this.beverage = beverage;
	}

	public override string getDescription() {
		return "Caramel + " + this.beverage.getDescription();
	}

	public override int cost() {
		return 70 + this.beverage.cost();
	}
}

class Soy : CondimentDecorator {
	private Beverage beverage;

	public Soy(Beverage beverage) {
		this.beverage = beverage;
	}

	public override string getDescription() {
		return "Soy + " + this.beverage.getDescription();
	}

	public override int cost() {
		return 40 + this.beverage.cost();
	}
}

public class Program {
	public static void Main() {
		Random random = new Random();
		int randomNumber = random.Next(0, 2);
		Beverage baseBeverage = null;
		switch (randomNumber) {
			case 0:
				baseBeverage = new Espresso();
				break;
			case 1:
				baseBeverage = new Decaf();
				break;
		}

		randomNumber = random.Next(0, 3);
		Beverage beverage = null;
		switch (randomNumber) {
			case 0:
				beverage = new Milk(baseBeverage);
				break;
			case 1:
				beverage = new Caramel(baseBeverage);
				break;
			case 2:
				beverage = new Caramel(new Soy(baseBeverage));
				break;
		}

		Console.WriteLine(beverage.getDescription());
		Console.WriteLine(beverage.cost());
	}
}
