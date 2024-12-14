using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TheShotgunGame.Classes
{
    public partial class Player : GameBase
    {
        public FormShotgun form;
        public ActionOutcomes actionOutcomes;
        
        public Player(FormShotgun form)
        {
            this.form = form;
        }

        public void SetActionOutcomes(ActionOutcomes actionOutcomes)
        {
            this.actionOutcomes = actionOutcomes;  
        }
        public int playerAmmo
        {
            get { return ammo; }
            set { ammo = value; }
        }
        public override void Ammo()
        {
            if (ammo > 0)
            {
                ammo--;
            }
        }
 
        public override void DisplayAmmo()
        {
            form.PlayerAmmoLabel.Text = $"{ammo}";
        }

        public string PlayerLogic(string playerAction)
        {
            Debug.WriteLine("PlayerLogic called with action: " + playerAction);
            string lastPlayerMove = playerAction;

            if (lastPlayerMove == "Skjut")
            {          
                RemoveAmmo(1);
                DisplayAmmo();
            }
            else if (lastPlayerMove == "Ladda")
            {
                AddAmmo(1);
                DisplayAmmo();
            }
            else if (lastPlayerMove == "Blocka")
            {
                
            }
            else if (lastPlayerMove == "Shotgun")
            {
                if (playerAmmo >= 3)
                {
                    return lastPlayerMove;
                }
                else
                {
                    MessageBox.Show("Du kan bara använda Shotgun om du har 3 skott");
                    return null;
                }
            }
                return lastPlayerMove;
        }
    }
}

