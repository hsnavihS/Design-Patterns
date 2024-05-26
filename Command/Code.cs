using System;

interface ICommand {
	void execute();
	void unexecute();
}

class Light {
	private int brightness = 0;

	public void on() {
		this.brightness = 50;
		Console.WriteLine("Light is on");
	}

	public void off() {
		this.brightness = 0;
		Console.WriteLine("Light is off");
	}

	public void dim() {
		this.brightness -= 5;
		Console.WriteLine("Light is dimmed to " + this.brightness);
	}

	public void brighten() {
		this.brightness += 5;
		Console.WriteLine("Light is brightened to " + this.brightness);
	}
}

class LightOnCommand : ICommand {
	private Light light;

	public LightOnCommand(Light light) {
		this.light = light;
	}

	public void execute() {
		this.light.on();
	}

	public void unexecute() {
		this.light.off();
	}
}

class LightOffCommand : ICommand {
	private Light light;

	public LightOffCommand(Light light) {
		this.light = light;
	}

	public void execute() {
		this.light.off();
	}

	public void unexecute() {
		this.light.on();
	}
}

class LightDimCommand : ICommand {
	private Light light;

	public LightDimCommand(Light light) {
		this.light = light;
	}

	public void execute() {
		this.light.dim();
	}

	public void unexecute() {
		this.light.brighten();
	}
}

class LightBrightenCommand : ICommand {
	private Light light;

	public LightBrightenCommand(Light light) {
		this.light = light;
	}

	public void execute() {
		this.light.brighten();
	}

	public void unexecute() {
		this.light.dim();
	}
}

class RemoteControl {
	ICommand onCommand;
	ICommand offCommand;
	ICommand dimCommand;
	ICommand brightenCommand;

	public RemoteControl(ICommand onCommand, ICommand offCommand, ICommand dimCommand, ICommand brightenCommand) {
		this.onCommand = onCommand;
		this.offCommand = offCommand;
		this.dimCommand = dimCommand;
		this.brightenCommand = brightenCommand;
	}

	public void pressOnButton() {
		this.onCommand.execute();
	}

	public void pressOffButton() {
		this.offCommand.execute();
	}

	public void pressDimButton() {
		this.dimCommand.execute();
	}

	public void pressBrightenButton() {
		this.brightenCommand.execute();
	}
}

class Program {
	public static void Main() {
		Light light = new Light();
		RemoteControl remoteControl = new RemoteControl(
				onCommand: new LightOnCommand(light),
				offCommand: new LightOffCommand(light),
				dimCommand: new LightDimCommand(light),
				brightenCommand: new LightBrightenCommand(light)
			);

		remoteControl.pressOnButton();
		remoteControl.pressDimButton();
		remoteControl.pressBrightenButton();
		remoteControl.pressBrightenButton();
		remoteControl.pressDimButton();
		remoteControl.pressOffButton();
	}
}
