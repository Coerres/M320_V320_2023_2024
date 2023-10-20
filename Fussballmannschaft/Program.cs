using Fussballmannschaft;

class Program
{
    static void Main()
    {
        Mannschaft team = new Mannschaft();

        Feldspieler spieler1 = new Feldspieler("Spieler1");
        Feldspieler spieler2 = new Feldspieler("Spieler2");
        Torwart torwart = new Torwart();

        team.AddFeldspieler(spieler1);
        team.AddFeldspieler(spieler2);
        team.SetTorwart(torwart);

        int ergebnis = team.Spielzug();
        Console.WriteLine("Ergebnis des Spielzugs: " + ergebnis);

        spieler1.MacheBlutgraetsche(); //calls method 
        spieler1.DribbletGegnerSchwindlig();
    }
}
