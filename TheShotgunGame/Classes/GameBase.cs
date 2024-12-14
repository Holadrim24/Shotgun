using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheShotgunGame.Classes
{
    public abstract class GameBase
    {
        protected int ammo;

        public virtual void Ammo()
        {
            if (ammo > 0)
            {
                ammo--;
            }
        }
        public void AddAmmo(int amount)
        {
            ammo += amount;
            DisplayAmmo();
        }
        public void RemoveAmmo(int amount)
        {
            ammo -= amount;
            DisplayAmmo();
        }
        public abstract void DisplayAmmo();
    }
}
