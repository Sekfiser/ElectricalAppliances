namespace Lab1._1
{
    internal class Computer : ElectricalAppliance
    {
        public Computer()
        {
            this.Name = "Computer";
        }

        public int Calculate(int a, int b) {
            return a + b;
        }
    }
}
