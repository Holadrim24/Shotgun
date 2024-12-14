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
            player = new Player(this);
            computer = new Computer(this);
            actionOutcomes = new ActionOutcomes(this, player, computer);
            player.SetActionOutcomes(actionOutcomes);
            computer.SetActionOutcomes(actionOutcomes);

            btnShoot.Enabled = false;
            btnReload.Enabled = false;
            btnDodge.Enabled = false;
            btnExitGameApp.Enabled = false;
            btnPlayAgain.Enabled = false;
            btnShotgun.Enabled = false;
        }

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
        private void bntReload_Click(object sender, EventArgs e)
        {
            string playerAction = "Ladda";
            string lastPlayerMove = player.PlayerLogic(playerAction);
            string lastComputerMove = computer.ComputerLogic();
            actionOutcomes.ActionsCollection(lastPlayerMove, lastComputerMove);
        }
        
        private void btnDodge_Click(object sender, EventArgs e)
        {
            string playerAction = "Blocka";
            string lastPlayerMove = player.PlayerLogic(playerAction);
            string lastComputerMove = computer.ComputerLogic();
            if (lastPlayerMove != null && lastComputerMove != null)
            {
                actionOutcomes.ActionsCollection(lastPlayerMove, lastComputerMove);
            }
        }

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
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void EndOfGame(string outcomePrompt)
        {
            lbxGameArea.Items.Add(outcomePrompt);  
            lbxGameArea.Items.Add("Spelet är över. Grattis till vinnaren! Tryck på 'Spela igen' om du vill starta en ny omgång.");
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
