using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___Harry_Potter
{
    public class Wizard
    {

        public string BloodStatus { get; set; }
        public bool DeathEater { get; set; }
        public bool DumbledoresArmy { get; set; }
        public string NameWizard { get; set; }

        Random random = new Random();

        public Wizard()
        {
            BloodStatus = GenerateBloodStatus();
            DeathEater = GenerateDeathEater();
            DumbledoresArmy = GenerateDumbledoresArmy();
        }

        public override string ToString()
        {
            return ($"{NameWizard}");
        }

        public string GenerateBloodStatus()
        {
            int odds = random.Next(1, 101);

            if (odds <= 60)
            {
                BloodStatus = "Halvblod";
            }
            else if (odds >= 61 && odds <= 85)
            {
                BloodStatus = "Mugglarfödd";
            }
            else if (odds >= 86 && odds <= 95)
            {
                BloodStatus = "Fullblod";
            }
            else
            {
                BloodStatus = "Okänd";
            }
            return BloodStatus;
        }

        public bool GenerateDeathEater()
        {
            int odds = random.Next(1, 101);

            if (BloodStatus == "Halvblod")
            {
                if (odds >= 0 && odds < 25)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (BloodStatus == "Mugglarfödd")
            {
                if (odds >= 0 && odds < 15)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (BloodStatus == "Fullblod")
            {
                if (odds >= 0 && odds < 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (BloodStatus == "Okänd")
            {
                if (odds >= 0 && odds < 25)
                {
                    return  true;
                }
                else
                {
                    return false;
                }
            }
            return DeathEater;
        }

        public bool GenerateDumbledoresArmy()
        {
            int odds = random.Next(1, 101);

            if (DeathEater == false)
            {
                if (odds <= 45)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (DeathEater == true)
            {
                if (odds <= 25)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            } return DumbledoresArmy;

        }
    }







}
    
