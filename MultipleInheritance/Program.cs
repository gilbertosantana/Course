using MultipleInheritance.Devices;

Printer p = new Printer()
{
    SerialNumber = 1000
};
p.ProssecDoc("My letter");
p.Print("My letter");

Scanner s = new Scanner()
{
    SerialNumber = 2003
};
s.ProssecDoc("My email");
Console.WriteLine(s.Scan());

ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
c.ProssecDoc("My dessertation");
c.Print("My dissertation");
Console.WriteLine(c.Scan());