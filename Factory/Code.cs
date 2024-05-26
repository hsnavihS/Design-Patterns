using System;

class Asteroid {
	int size = 0;
	int speed = 0;
	int x = 0;
	int y = 0;

	public Asteroid(int size, int speed, int x, int y) {
		this.size = size;
		this.speed = speed;
		this.x = x;
		this.y = y;
	}

	public override string ToString() {
		return "Asteroid: size=" + this.size + ", speed=" + this.speed + ", x=" + this.x + ", y=" + this.y;
	}
}

interface IAsteroidFactory {
	Asteroid createAsteroid(int level);
}

class SimpleAsteroidFactory : IAsteroidFactory {
	private Random random = new Random();

	public Asteroid createAsteroid(int level) {
		return new Asteroid(
				size: level * random.Next(1, 3),
				speed: level * random.Next(1, 3),
				x: level * random.Next(1, 100),
				y: level * random.Next(1, 100)
			);
	}
}

class DifficultAsteroidFactory : IAsteroidFactory {
	private Random random = new Random();

	public Asteroid createAsteroid(int level) {
		return new Asteroid(
				size: level * random.Next(1, 10),
				speed: level * random.Next(1, 10),
				x: level * random.Next(1, 100),
				y: level * random.Next(1, 100)
			);
	}
}

class Program {
	public static void Main() {
		IAsteroidFactory simpleAsteroidFactory = new SimpleAsteroidFactory();
		IAsteroidFactory difficultAsteroidFactory = new DifficultAsteroidFactory();
		for (int i = 0; i < 5; i++) {
			Console.WriteLine("Creating 5 simple asteroids for level: " + (i + 1));
			for (int j = 0; j < 5; j++) {
				Asteroid asteroid = simpleAsteroidFactory.createAsteroid(i + 1);
				Console.WriteLine(asteroid);
			}
			Console.WriteLine("Creating 5 difficult asteroids for level: " + (i + 1));
			for (int j = 0; j < 5; j++) {
				Asteroid asteroid = difficultAsteroidFactory.createAsteroid(i + 1);
				Console.WriteLine(asteroid);
			}
			Console.WriteLine("\nLevel " + (i + 1) + " done\n");
		}
	}
}
