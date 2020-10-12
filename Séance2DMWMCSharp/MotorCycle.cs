using System;
using System.Collections.Generic;
using System.Text;

namespace Séance2DMWMCSharp
{
    class MotorCycle
    {
        public int driverIntensity;
        string name;
        public MotorCycle()
        {

        }
        //Logique redondante
        public MotorCycle(int driverIntensity) : this(driverIntensity, "")
        {



        }
        public MotorCycle(string name) : this(0, name)
        {


        }
        //Master constructor qui fait tout le travail
        public MotorCycle(int driverIntensity, string name)
        {
            if (driverIntensity > 10)
            {
                driverIntensity = 10;
            }
            //setIntensity(driverIntensity);
            this.driverIntensity = driverIntensity;
            this.name = name;

        }
        public void SetDriverName(string name)
        {
            this.name = name;
        }
        public void setIntensity(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
        }
    }
}
