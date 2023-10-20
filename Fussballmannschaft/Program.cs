using Fussballmannschaft;
using System;

class Program
{
    static void Main()
    {
        Mannschaft team1 = new Mannschaft();
        Mannschaft team2 = new Mannschaft();

        Spiel spiel = new Spiel();

        Resultat ergebnisSpiel = spiel.SpielResultat;

        //team 1
        for (int i = 1; i <= 10; i++)
        {
            Feldspieler spieler = new Feldspieler($"Spieler {i} Team 1");
            team1.AddFeldspieler(spieler);
        }

        Torwart torwartTeam1 = new Torwart("Torwart Team 1");
        team1.SetTorwart(torwartTeam1);

        //team 2
        for (int i = 1; i <= 10; i++)
        {
            Feldspieler spieler = new Feldspieler($"Spieler {i} Team 2");
            team2.AddFeldspieler(spieler);
        }

        Torwart torwartTeam2 = new Torwart("Torwart Team 2");
        team2.SetTorwart(torwartTeam2);

        int ergebnisTeam1 = team1.Spielzug();
        int ergebnisTeam2 = team2.Spielzug();

        Console.WriteLine("Spielergebnis:");
        Console.WriteLine("Team 1: " + (ergebnisTeam1 > 0 ? "Tor erzielt" : "Kein Tor"));
        Console.WriteLine("Team 2: " + (ergebnisTeam2 > 0 ? "Tor erzielt" : "Kein Tor"));

        //save result in 'Resultat'
        ergebnisSpiel.Team1Ergebnis = ergebnisTeam1;
        ergebnisSpiel.Team2Ergebnis = ergebnisTeam2;

        //actions
        Console.WriteLine("Aktionen:");
        team1.Feldspieler[0].MacheBlutgraetsche();
        torwartTeam1.Abstoss();

        team2.Feldspieler[0].DribbletGegnerSchwindlig();
        bool schussGehalten = torwartTeam2.HalteTor();

        Console.WriteLine("Gesamtergebnis:");
        Console.WriteLine(ergebnisSpiel.GetErgebnisZusammenfassung());
    }
}
