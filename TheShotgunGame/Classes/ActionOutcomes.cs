using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheShotgunGame.Classes
{
    public class ActionOutcomes
    {
        public FormShotgun form;
        public Player player;
        public Computer computer;

        public ActionOutcomes(FormShotgun form, Player player, Computer computer)
        {
            this.form = form;
            this.player = player;
            this.computer = computer;
        }

        //Här ligger all logik som har med händelser som använder båda valen som spelarna gjort
        public void ActionsCollection(string lastPlayerMove, string lastComputerMove)
        {
            Debug.WriteLine($"Du valde: {lastPlayerMove}");
            Debug.WriteLine($"Datorn valde: {lastComputerMove}");
            
            //Skapar en tom sträng för att varje if-sats ska kunna lägga till sin text som variabel att skicka vidare
            string outcomePrompt = "";

            if (lastPlayerMove == "Ladda" && lastComputerMove == "Ladda")
            {
                //Båda spelarna lägger till ett skott i sina räknare
                outcomePrompt = "Båda spelarna får ett skott.";
            }
            else if (lastPlayerMove == "Ladda" && lastComputerMove == "Blocka")
            {
                //Lägg till ett skott i spelarens räknare
                outcomePrompt = "Du får ett skott.";
            }
            else if (lastPlayerMove == "Blocka" && lastComputerMove == "Ladda")
            {
                //Lägg till ett skott i datorns räknare
                outcomePrompt = "Datorn får ett skott.";
            }
            else if (lastPlayerMove == "Blocka" && lastComputerMove == "Blocka")
            {
                outcomePrompt = "Båda spelarna blockar. Inget händer.";
            }
            else if (lastPlayerMove == "Blocka" && lastComputerMove == "Skjut")
            {
                //Tar bort ett skott från datorns räknare
                outcomePrompt = "Datorn förlorar ett skott.";
            }
            else if (lastPlayerMove == "Skjut" && lastComputerMove == "Blocka")
            {
                //Tar bort ett skott från spelarens räknare
                outcomePrompt = "Du förlorar ett skott.";
            }
            else if (lastPlayerMove == "Skjut" && lastComputerMove == "Skjut")
            {
                //TA BORT ETT SKOTT FÖR BÅDA SPELARNAS COUNTERS (playerAmmo & computerAmmo--)
                //Meddelandet i listboxen: "Båda spelarna förlorar ett skott"
                outcomePrompt = "Båda spelarna förlorar ett skott.";
            }
            else if (lastPlayerMove == "Skjut" && lastComputerMove == "Ladda")
            {
                //Spelaren vinner
                //Tar även bort ett skott från spelarens counter
                //Skickar det direkt till EndOfGame-metoden i formuläret
                outcomePrompt = "Du skjuter datorn medans den laddar! Du vinner!";
                form.EndOfGame(outcomePrompt);
                return;
            }
            else if (lastPlayerMove == "Ladda" && lastComputerMove == "Skjut" || lastComputerMove == "Shotgun")
            {
                //Datorn vinner
                //Tar även bort ett skott från datorns counter
                //Skickar direkt till EndOfGame-metoden i formuläret
                outcomePrompt = "Du laddar och datorn skjuter dig medans du gör det! Datorn vinner!";
                form.EndOfGame(outcomePrompt);
                return;
            }
            else if (lastPlayerMove == "Shotgun")
            {
                //Skickar strängen direkt till EndOfGame-metoden
                outcomePrompt = "Du laddar upp din Shotgun och skjuter datorn! Du vinner!";
                form.EndOfGame(outcomePrompt);
                return;
            }
            else if (lastComputerMove == "Shotgun")
            {
                //Skickar strängen direkt till EndOfGame-metoden
                //Datorn kommer vara tvungen att använda Shotgun om den har 3 skott men om båda har Shotgun så vinner spelaren
                outcomePrompt = "Datorn laddar upp sin Shotgun och skjuter dig! Datorn vinner!";
                form.EndOfGame(outcomePrompt);
                return;
            }

            //Formaterera varje move så det blir rätt böjning på orden i listboxen

            if (lastPlayerMove == "Skjut")
            {
                lastPlayerMove = "skjuter";
            }
            else if (lastPlayerMove == "Ladda")
            {
                lastPlayerMove = "laddar";

            }
            else if (lastPlayerMove == "Blocka")
            {
                lastPlayerMove = "blockar";
            }
            else if (lastPlayerMove == "Shotgun")
            {
                lastPlayerMove = "använder din Shotgun";
            }

            if (lastComputerMove == "Skjut")
            {
                lastComputerMove = "skjuter";

            }
            else if (lastComputerMove == "Ladda")
            {
                lastComputerMove = "laddar";
            }
            else if (lastComputerMove == "Blocka")
            {
                lastComputerMove = "blockar";
            }
            else if (lastComputerMove == "Shotgun")
            {
                lastPlayerMove = "använder sin Shotgun";
            }

            //Detta är vad som kommer skrivas ut i listboxen i formuläret
            string showAction = $"Du {lastPlayerMove} och datorn {lastComputerMove}.";
            form.ShowAction(showAction);

            form.ShowOutcome(outcomePrompt);
            return;
        }



    }
}
