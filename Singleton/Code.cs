using System;

class Singleton {
	private static Singleton instance = null;

	private Singleton() {
	}

	public static Singleton getInstance() {
		if (instance == null) {
			instance = new Singleton();
		}
		return instance;
	}

	public override string ToString() {
		return "Singleton instance";
	}
}

class Program {
	public static void Main() {
		Singleton singleton1 = Singleton.getInstance();
		Singleton singleton2 = Singleton.getInstance();
		Console.WriteLine("Singleton 1: " + singleton1);
		Console.WriteLine("Singleton 2: " + singleton2);
	}
}
