using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheShotgunGame.Classes
{
    //Detta är en abstrakt basklass som Player och Computer-klasserna ska ärva från
    public abstract class GameBase
    {
        //visar att man int ska kunna ändra ammo manuellt
        protected int ammo;

        public virtual void Ammo()
        {
            //Om ammo är över noll så ska den kunna räkna nedåt
            if (ammo > 0)
            {
                ammo--;
            }
        }

        //Lägger till ammo och skickar vidare till DisplayAmmo
        public void AddAmmo(int amount)
        {
            ammo += amount;
            DisplayAmmo();
        }

        //Tar bort ammo och skickar vidare till DisplayAmmo
        public void RemoveAmmo(int amount)
        {
            ammo -= amount;
            DisplayAmmo();
        }

        //Denna abstrakta metoden ska kunna ärvas av Player och Computer
        public abstract void DisplayAmmo();
    }
}
