namespace MultipleInheritance.Devices
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }
        public override void ProssecDoc(string document)
        {
            Console.WriteLine("Combodevice processing " + document);
        }
        public string Scan()
        {
            return "Combodevice scan result";
        }
    }
}
