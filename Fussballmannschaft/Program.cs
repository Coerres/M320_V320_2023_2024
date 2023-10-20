using Fussballmannschaft;

class Program
{
    static void Main()
    {
        Mannschaft team1 = new Mannschaft();
        Mannschaft team2 = new Mannschaft();

        Spiel spiel = new Spiel();

        Resultat ergebnisSpiel = spiel.SpielResultat;

        /*Spiel spiel1 = new Spiel();
        Spiel spiel2 = new Spiel();

        Resultat ergebnisSpiel1 = spiel1.SpielResultat;
        Resultat ergebnisSpiel2 = spiel2.SpielResultat;

        team1.AddSpiel(spiel1);
        team2.AddSpiel(spiel1);
        team2.AddSpiel(spiel2);
        */


        //team 1
        Feldspieler spieler1Team1 = new Feldspieler("Spieler 1 Team 1");
        Feldspieler spieler2Team1 = new Feldspieler("Spieler 2 Team 1");
        Torwart torwartTeam1 = new Torwart("Torwart Team 1");

        team1.AddFeldspieler(spieler1Team1);
        team1.AddFeldspieler(spieler2Team1);
        team1.SetTorwart(torwartTeam1);


        //team 2
        Feldspieler spieler1Team2 = new Feldspieler("Spieler 1 Team 2");
        Feldspieler spieler2Team2 = new Feldspieler("Spieler 2 Team 2");
        Torwart torwartTeam2 =  new Torwart("Torwart Team 2");

        team2.AddFeldspieler(spieler1Team2);
        team2.AddFeldspieler(spieler2Team2);
        team2.SetTorwart(torwartTeam2);


        int ergebnisTeam1 = team1.Spielzug();
        int ergebnisTeam2 = team2.Spielzug();

        Console.WriteLine("Spielergebnis:");
        Console.WriteLine("Team 1: " + ergebnisTeam1);
        Console.WriteLine("Team 2: " + ergebnisTeam2);

        //safe result in 'Resultat'
        ergebnisSpiel.Team1Ergebnis = ergebnisTeam1;
        ergebnisSpiel.Team2Ergebnis = ergebnisTeam2;

        Console.WriteLine("Gesamtergebnis:");
        Console.WriteLine("Team 1: " + ergebnisSpiel.Team1Ergebnis);
        Console.WriteLine("Team 2: " + ergebnisSpiel.Team2Ergebnis); ;

        /*Console.WriteLine("Ergebnis des Spielzugs für Team 1: " + ergebnisTeam1);
        Console.WriteLine("Ergebnis des Spielzugs für Team 2: " + ergebnisTeam2);
        */

        spieler1Team1.MacheBlutgraetsche(); //calls method 
        torwartTeam1.Abstoss();

        spieler1Team2.DribbletGegnerSchwindlig();
        bool schussGehalten = torwartTeam2.HalteTor(); 
   
    }
}
