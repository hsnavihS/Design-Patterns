using System;
using System.Collections.Generic;

interface IDisplayBehavior
{
	void display();
}

interface IFlyBehavior
{
		void fly();
}

interface IQuackBehavior
{
	void quack();
}

class SimpleDisplayBehavior : IDisplayBehavior
{
	public void display()
	{
		Console.WriteLine("Simply displaying behavior");
	}
}

class ComplexDisplayBehavior : IDisplayBehavior
{
	public void display()
	{
		Console.WriteLine("Complex displaying behavior");
	}
}

class SimpleFlyBehavior : IFlyBehavior
{
		public void fly()
		{
				Console.WriteLine("Simply flying behavior");
		}
}

class NoFlyBehavior : IFlyBehavior
{
		public void fly()
		{
				Console.WriteLine("No flying behavior");
		}
}

class SimpleQuackBehavior : IQuackBehavior
{
	public void quack()
	{
		Console.WriteLine("Simple quacking behavior");
	}
}

class NoQuackBehavior : IQuackBehavior
{
	public void quack()
	{
		Console.WriteLine("No quacking behavior");
	}
}

class Duck {
	IFlyBehavior flyBehavior;
	IQuackBehavior quackBehavior;
	IDisplayBehavior displayBehavior;

	public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, IDisplayBehavior displayBehavior) {
		this.flyBehavior = flyBehavior;
		this.quackBehavior = quackBehavior;
		this.displayBehavior = displayBehavior;
	}

	public void fly() {
		this.flyBehavior.fly();
	}

	public void quack() {
		this.quackBehavior.quack();
	}

	public void display() {
		this.displayBehavior.display();
	}

	public override string ToString() {
		return "Duck with " + this.flyBehavior + ", " + this.quackBehavior + ", " + this.displayBehavior;
	}
}


class Program {
	public static void Main(string[] args)
	{
		List<IFlyBehavior> flyBehaviors = new List<IFlyBehavior> {
			new SimpleFlyBehavior(),
			new NoFlyBehavior()
		};
		List<IQuackBehavior> quackBehaviors = new List<IQuackBehavior> {
			new SimpleQuackBehavior(),
			new NoQuackBehavior()
		};
		List<IDisplayBehavior> displayBehaviors = new List<IDisplayBehavior> {
			new SimpleDisplayBehavior(),
			new ComplexDisplayBehavior()
		};

		Random random = new Random();
		List<int> behaviourChoices = new List<int> { random.Next(0, 2), random.Next(0, 2), random.Next(0, 2) };

		Duck duck = new Duck(flyBehaviors[behaviourChoices[0]], quackBehaviors[behaviourChoices[1]], displayBehaviors[behaviourChoices[2]]);

		Console.WriteLine(duck);
	}
}
