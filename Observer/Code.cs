using System;
using System.Collections.Generic;

interface IObserver {
	void update();
}

interface IObservable {
	void add(IObserver observer);
	void remove(IObserver observer);
	void notify();
	void setTemperature();
	int getTemperature();
}

class WindowDisplay : IObserver {
	private IObservable observable;

	public WindowDisplay(IObservable observable) {
		this.observable = observable;
	}

	public void update() {
		Console.WriteLine("WindowDisplay updated: " + observable.getTemperature());
	}
}

class PhoneDisplay : IObserver {
	private IObservable observable;

	public PhoneDisplay(IObservable observable) {
		this.observable = observable;
	}

	public void update() {
		Console.WriteLine("PhoneDisplay updated: " + observable.getTemperature());
	}
}

class WeatherStation : IObservable {
	private int temperature = 25;
	private List<IObserver> observers = new List<IObserver>();

	public void add(IObserver observer) {
		this.observers.Add(observer);
	}

	public void remove(IObserver observer) {
		this.observers.Remove(observer);
	}

	public void notify() {
		foreach (IObserver observer in observers) {
			observer.update();
		}
	}

	public void setTemperature() {
		Random random = new Random();
		this.temperature = random.Next(0, 50);
	}

	public int getTemperature() {
		return this.temperature;
	}
}

class Program {
	public static void Main(string[] args) {
		WeatherStation weatherStation = new WeatherStation();
		WindowDisplay windowDisplay = new WindowDisplay(weatherStation);
		PhoneDisplay phoneDisplay = new PhoneDisplay(weatherStation);

		weatherStation.add(windowDisplay);
		weatherStation.add(phoneDisplay);

		Console.WriteLine("Initial notify running:");
		weatherStation.notify();

		weatherStation.setTemperature();
		Console.WriteLine("Running notify post update:");
		weatherStation.notify();

		weatherStation.remove(windowDisplay);
		weatherStation.setTemperature();
		Console.WriteLine("Running notify post update and removal:");
		weatherStation.notify();
	}
}
