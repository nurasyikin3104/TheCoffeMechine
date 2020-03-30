using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;

        public CoffeMechine(CoffePowder powder, WaterGalon galon)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
        }

        public String makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is Empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your coffe is redy";
        }

        public String checkAvailability()
        {
            return $"The Water : {this.waterGalon.getVolume()} and the Coffe Powder powder : { this.coffePowder.getNetto()} ";
        }
    }
}
