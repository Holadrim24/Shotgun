using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TheShotgunGame.Classes
{
    public partial class Computer : GameBase
    {
        public FormShotgun form;
        public ActionOutcomes actionOutcomes;

        public Computer(FormShotgun form)
        {
            this.form = form;
        }

        public void SetActionOutcomes(ActionOutcomes actionOutcomes)
        {
            this.actionOutcomes = actionOutcomes;
        }

        int computerAmmo
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
          form.ComputerAmmoLabel.Text = $"{ammo}";
        }
        public string ComputerLogic()
        {
        Random cpu = new Random();
        string computerChoice = "";
        
        if (computerAmmo >= 3)
        {
            computerChoice = "Shotgun";
                Debug.WriteLine("Datorn har tillräckligt med skott och använder Shotgun!");
                return computerChoice;
        }
        
        int computerLogic = cpu.Next(1, 4);
        switch (computerLogic)
        {
            case 1:
                computerChoice = "Ladda";
                break;
            case 2:
                computerChoice = "Blocka";
                break;
            case 3:
                computerChoice = "Skjut";
                    if (computerAmmo > 0)
                    {
                        computerChoice = "Skjut";
                    }
                    else
                    {
                        Debug.WriteLine("Datorn kan inte skjuta eftersom den inte har några skott");
                        return ComputerLogic();
                    }
                    break;
            }

        Debug.WriteLine($"Datorn valde: {computerChoice}");

            string lastComputerMove = computerChoice;
            
            if (lastComputerMove == "Skjut")
            {
                if(computerAmmo == 0)
                { return ComputerLogic(); }
                else
                RemoveAmmo(1);
                DisplayAmmo();
            }
            else if (lastComputerMove == "Ladda")
            {
                AddAmmo(1);
                DisplayAmmo();
            }
            else if (lastComputerMove == "Blocka")
            {

            }
            else if (lastComputerMove == "Shotgun")
            {
                if (computerAmmo >= 3)
                {
                    if (lastComputerMove == "Shotgun")
                    {
                        RemoveAmmo(3);
                    }
                    return lastComputerMove;
                }
                else
                {
                    Debug.WriteLine("Datorn kan inte använda shotgun för den inte har tre skott");
                    return ComputerLogic();
                }
            }
            return lastComputerMove;
        }
    }
}
