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

        //Konstruktor
        public Player(FormShotgun form)
        {
            this.form = form;
        }

        public void SetActionOutcomes(ActionOutcomes actionOutcomes)
        {
            this.actionOutcomes = actionOutcomes;  
        }

        //Skapar en lokal variabel som visar hur många skott man har så man kan använda det för att avgöra om man kan använda
        //Shotgun i PlayerLogic-metoden
        public int playerAmmo
        {
            get { return ammo; }
            set { ammo = value; }
        }

        //Gör en override på Ammo-metoden som ärvts från GameBase så den kan användas i denna klassen
        public override void Ammo()
        {
            if (ammo > 0)
            {
                ammo--;
            }
        }
 
        //Detta skickar det nuvarande DisplayAmmo för player till labeln i FormShotgun
        public override void DisplayAmmo()
        {
            form.PlayerAmmoLabel.Text = $"{ammo}";
        }

        //Detta är logiken för spelaren, den anropar button-click-events i FormShotgun
        //Sen kollar den vilket val man gjorde (vilken knapp man tryckt på)
        public string PlayerLogic(string playerAction)
        {
            Debug.WriteLine("PlayerLogic called with action: " + playerAction);
            string lastPlayerMove = playerAction;

            //Om senaste moven var "Skjut" så kommer det tas bort ett skott i räknaren för spelaren och sen uppdateras det i labeln på formuläret
            if (lastPlayerMove == "Skjut")
            {          
                RemoveAmmo(1);
                DisplayAmmo();
            }
            //Om senaste moven var "Ladda" så kommer det läggas till ett skott i räknaren
            else if (lastPlayerMove == "Ladda")
            {
                AddAmmo(1);
                DisplayAmmo();
            }
            //Om senaste move var "Block" så fortsätter bara variabeln vidare mot ActionOutcomes-klassen i slutet
            else if (lastPlayerMove == "Blocka")
            {
                
            }
            //Man ska bara kunna trycka på Shotgun-knappen om man har 3 skott
            else if (lastPlayerMove == "Shotgun")
            {
                //Om spelaren har 3 eller fler skott så kan man använda Shotgun
                if (playerAmmo >= 3)
                {
                    return lastPlayerMove;
                }
                //Annars visas detta meddelandet i en MessageBox
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

