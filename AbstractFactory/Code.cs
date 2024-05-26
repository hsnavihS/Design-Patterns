using System;

interface IButton {
	void getDescription();
}

class WindowsButton : IButton {
	public void getDescription() {
		Console.WriteLine("Windows button");
	}
}

class MacButton : IButton {
	public void getDescription() {
		Console.WriteLine("Mac button");
	}
}

class LinuxButton : IButton {
	public void getDescription() {
		Console.WriteLine("Linux button");
	}
}

interface ICheckbox {
	void getDescription();
}

class WindowsCheckbox : ICheckbox {
	public void getDescription() {
		Console.WriteLine("Windows checkbox");
	}
}

class MacCheckbox : ICheckbox {
	public void getDescription() {
		Console.WriteLine("Mac checkbox");
	}
}

class LinuxCheckbox : ICheckbox {
	public void getDescription() {
		Console.WriteLine("Linux checkbox");
	}
}

interface IComponentFactory {
	IButton createButton();
	ICheckbox createCheckbox();
}

class WindowsComponentFactory : IComponentFactory {
	public IButton createButton() {
		return new WindowsButton();
	}

	public ICheckbox createCheckbox() {
		return new WindowsCheckbox();
	}
}

class MacComponentFactory : IComponentFactory {
	public IButton createButton() {
		return new MacButton();
	}

	public ICheckbox createCheckbox() {
		return new MacCheckbox();
	}
}

class LinuxComponentFactory : IComponentFactory {
	public IButton createButton() {
		return new LinuxButton();
	}

	public ICheckbox createCheckbox() {
		return new LinuxCheckbox();
	}
}

class Program {
	public static void Main() {
		Random random = new Random();
		int randomNumber = random.Next(0, 3);
		switch (randomNumber) {
			case 0:
				IComponentFactory windowsComponentFactory = new WindowsComponentFactory();
				Console.WriteLine("Creating Windows components");
				windowsComponentFactory.createButton().getDescription();
				windowsComponentFactory.createCheckbox().getDescription();
				break;
			case 1:
				IComponentFactory macComponentFactory = new MacComponentFactory();
				Console.WriteLine("Creating Mac components");
				macComponentFactory.createButton().getDescription();
				macComponentFactory.createCheckbox().getDescription();
				break;
			case 2:
				IComponentFactory linuxComponentFactory = new LinuxComponentFactory();
				Console.WriteLine("Creating Linux components");
				linuxComponentFactory.createButton().getDescription();
				linuxComponentFactory.createCheckbox().getDescription();
				break;
		}
	}
}
