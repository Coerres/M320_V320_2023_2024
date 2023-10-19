namespace Fussballmannschaft
{
    class Program
    {
        static void Main()
        {
            Mannschaft team = new Mannschaft();

            Feldspieler spieler1 = new Feldspieler();
            Feldspieler spieler2 = new Feldspieler();
            Torwart torwart = new Torwart();

            team.AddFeldspieler(spieler1);
            team.AddFeldspieler(spieler2);
            team.SetTorwart(torwart);
        }
    }
}