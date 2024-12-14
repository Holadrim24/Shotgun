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

        public void ActionsCollection(string lastPlayerMove, string lastComputerMove)
        {
            Debug.WriteLine($"Du valde: {lastPlayerMove}");
            Debug.WriteLine($"Datorn valde: {lastComputerMove}");
            
            string outcomePrompt = "";

            if (lastPlayerMove == "Ladda" && lastComputerMove == "Ladda")
            {
                outcomePrompt = "Båda spelarna får ett skott.";
            }
            else if (lastPlayerMove == "Ladda" && lastComputerMove == "Blocka")
            {
                outcomePrompt = "Du får ett skott.";
            }
            else if (lastPlayerMove == "Blocka" && lastComputerMove == "Ladda")
            {
                outcomePrompt = "Datorn får ett skott.";
            }
            else if (lastPlayerMove == "Blocka" && lastComputerMove == "Blocka")
            {
                outcomePrompt = "Båda spelarna blockar. Inget händer.";
            }
            else if (lastPlayerMove == "Blocka" && lastComputerMove == "Skjut")
            {
                outcomePrompt = "Datorn förlorar ett skott.";
            }
            else if (lastPlayerMove == "Skjut" && lastComputerMove == "Blocka")
            {
                outcomePrompt = "Du förlorar ett skott.";
            }
            else if (lastPlayerMove == "Skjut" && lastComputerMove == "Skjut")
            {
                outcomePrompt = "Båda spelarna förlorar ett skott.";
            }
            else if (lastPlayerMove == "Skjut" && lastComputerMove == "Ladda")
            {
                outcomePrompt = "Du skjuter datorn medans den laddar! Du vinner!";
                form.EndOfGame(outcomePrompt);
                return;
            }
            else if (lastPlayerMove == "Ladda" && lastComputerMove == "Skjut" || lastComputerMove == "Shotgun")
            {
                outcomePrompt = "Du laddar och datorn skjuter dig medans du gör det! Datorn vinner!";
                form.EndOfGame(outcomePrompt);
                return;
            }
            else if (lastPlayerMove == "Shotgun")
            {
                outcomePrompt = "Du laddar upp din Shotgun och skjuter datorn! Du vinner!";
                form.EndOfGame(outcomePrompt);
                return;
            }
            else if (lastComputerMove == "Shotgun")
            {
                outcomePrompt = "Datorn laddar upp sin Shotgun och skjuter dig! Datorn vinner!";
                form.EndOfGame(outcomePrompt);
                return;
            }

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

            string showAction = $"Du {lastPlayerMove} och datorn {lastComputerMove}.";
            form.ShowAction(showAction);

            form.ShowOutcome(outcomePrompt);
            return;
        }
    }
}
