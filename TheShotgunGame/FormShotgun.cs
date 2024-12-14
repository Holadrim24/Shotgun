using System.Diagnostics;
using System.Net.NetworkInformation;
using TheShotgunGame.Classes;

namespace TheShotgunGame
{
    public partial class FormShotgun : Form
    {
        public Player player;
        public Computer computer;
        public ActionOutcomes actionOutcomes;

        public FormShotgun()
        {
            InitializeComponent();
            //Skapar upp instanser av de klasser och metoder som ska kunna anropas
            player = new Player(this);
            computer = new Computer(this);
            actionOutcomes = new ActionOutcomes(this, player, computer);
            player.SetActionOutcomes(actionOutcomes);
            computer.SetActionOutcomes(actionOutcomes);

            //Dessa knappar ska inte går att klicka på när man startar programmet
            btnShoot.Enabled = false;
            btnReload.Enabled = false;
            btnDodge.Enabled = false;
            btnExitGameApp.Enabled = false;
            btnPlayAgain.Enabled = false;
            btnShotgun.Enabled = false;
        }

        //I den här två labels så visas spelarna nuvarande ammo
        public Label PlayerAmmoLabel
        {
            get { return lblPlayerAmmo; }
        }
        public Label ComputerAmmoLabel
        {
            get { return lblComputerAmmo; }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            player.AddAmmo(0);
            computer.AddAmmo(0);

            player.DisplayAmmo();
            computer.DisplayAmmo();

            string start = "Välkommen till Shotgun! Välj din första move.";
            lbxGameArea.Items.Add(start);
            //Aktiverar de flesta andra knappar med stänger av Start-knappen
            btnShoot.Enabled = true;
            btnReload.Enabled = true;
            btnDodge.Enabled = true;
            btnShotgun.Enabled = true;
            btnStart.Enabled = false;
        }
        public void ShowAction(string showAction)
        {
            lbxGameArea.Items.Add(showAction);
        }

        public void ShowOutcome(string outcomePrompt)
        {
            if (outcomePrompt.Contains("Du vinner!") || outcomePrompt.Contains("Datorn vinner!"))
            {
                EndOfGame(outcomePrompt);
                return;
            }
            else
            {
                lbxGameArea.Items.Add(outcomePrompt);
                player.DisplayAmmo();
                computer.DisplayAmmo();
            }

        }

        //När man trycker på knappen skapar man en playerAction "Skjut"
        //Sen initieras datorns Randomizer (den gör sin move efter spelaren, man har ju redan tryckt på knappen)
        //"Skjut" skickas sedan vidare till PlayerLogic-metoden i Player-klassen
        private void btnShoot_Click(object sender, EventArgs e)
        {
            if (player.playerAmmo == 0)
            {
                MessageBox.Show("Du kan bara skjuta om du har ett skott. Ladda om.");
                return;
            }
            string playerAction = "Skjut";
            string lastPlayerMove = player.PlayerLogic(playerAction);
            string lastComputerMove = computer.ComputerLogic();
            actionOutcomes.ActionsCollection(lastPlayerMove, lastComputerMove);

            if (playerAction == "Skjut" && player.playerAmmo > 0)
            {
                computer.ComputerLogic();
            }
        }

        //När man trycker på knappen skapar man en playerAction "Blocka"
        //Sen initieras datorns Randomizer (den gör sin move efter player)
        //"Blocka" skickas sedan vidare till PlayerLogic-metoden i Player-klassen
        private void bntReload_Click(object sender, EventArgs e)
        {
            string playerAction = "Ladda";
            string lastPlayerMove = player.PlayerLogic(playerAction);
            string lastComputerMove = computer.ComputerLogic();
            actionOutcomes.ActionsCollection(lastPlayerMove, lastComputerMove);
        }

        //När man trycker på knappen skapar man en playerAction "Blocka"
        //Sen initieras datorns Randomizer (den gör sin move efter player)
        //"Blocka" skickas sedan vidare till PlayerLogic-metoden i Player-klassen
        private void btnDodge_Click(object sender, EventArgs e)
        {
            string playerAction = "Blocka";
            string lastPlayerMove = player.PlayerLogic(playerAction);
            string lastComputerMove = computer.ComputerLogic();
            if (lastPlayerMove != null && lastComputerMove != null)
            {
                actionOutcomes.ActionsCollection(lastPlayerMove, lastComputerMove); // Pass both moves
            }
        }

        //När man trycker på knappen så gör den samma sak som i de tre övre men den kommer kolla om du har tillräckligt med skott för att använda Shotgun
        private void btnShotgun_Click(object sender, EventArgs e)
        {
            string playerAction = "Shotgun";
            string lastPlayerMove = player.PlayerLogic(playerAction);
            
            if (lastPlayerMove == null)
            { 
                return;
            }
            if (lastPlayerMove == "Shotgun")
            {
                player.RemoveAmmo(3);
            }
            string lastComputerMove = computer.ComputerLogic();
            actionOutcomes.ActionsCollection(lastPlayerMove, lastComputerMove);
            //I de fallen man inte kan trycka på knappen och den inte tar bort tre ammo
        }

        //Om du trycker på Spela Igen-knappen efter avslutad omgång
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Om du vill avsluta spelet trycker du på Avsluta-knappen
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Denna metoden anropas om någon av spelarna har vunnit (via shotgun eller varsin version av händelser)
        public void EndOfGame(string outcomePrompt)
        {
            lbxGameArea.Items.Add(outcomePrompt);  
            lbxGameArea.Items.Add("Spelet är över. Grattis till vinnaren! Tryck på 'Spela igen' om du vill starta en ny omgång.");
            //Tillåter att man kan använda vissa av knapparna och inte andra
            btnPlayAgain.Enabled = true;
            btnExitGameApp.Enabled = true;
            btnShoot.Enabled = false;
            btnReload.Enabled = false;
            btnDodge.Enabled = false;
            btnShotgun.Enabled = false;
            return;
        }
    }
}
