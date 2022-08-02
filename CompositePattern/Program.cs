using CompositePattern;

IComponent hardDisk = new Leaf("Hard Disk", 2000);
IComponent ram = new Leaf("RAM", 3000);
IComponent cpu = new Leaf("CPU", 2000);
IComponent mouse = new Leaf("Mouse", 2000);
IComponent keyboard = new Leaf("Keyboard", 2000);
IComponent headset = new Leaf("Headset", 300);


Composite motherBoard = new Composite("Peripherals");
Composite cabinet = new Composite("Cabinet");
Composite peripherals = new Composite("Peripherals");
Composite computer = new Composite("Computer");

motherBoard.AddComponent(cpu);
motherBoard.AddComponent(ram);

cabinet.AddComponent(motherBoard);
cabinet.AddComponent(hardDisk);

peripherals.AddComponent(mouse);
peripherals.AddComponent(keyboard);
peripherals.AddComponent(headset);

computer.AddComponent(cabinet);
computer.AddComponent(peripherals);

computer.GetPrice();
Console.WriteLine();

keyboard.GetPrice();
Console.WriteLine();

cabinet.GetPrice();
Console.Read();