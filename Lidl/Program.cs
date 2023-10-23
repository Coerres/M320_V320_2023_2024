namespace Lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person() {Vorname = "Max", Name = "Mustermann"};
            var kunde1 = new Kunde() {Vorname = "Fritz", Name = "Müller" };
            var lagerist1 = new Lagerist() { Vorname = "Hans", Name = "Meier",Groesse = 180 };

            person1.Esse();
            kunde1.Esse();
            kunde1.Kaufe();
            lagerist1.Esse();
            lagerist1.LagereEin();
        }
    }
}