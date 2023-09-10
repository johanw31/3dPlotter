using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Tinkerforge;

namespace _3D_Plotter.Classes
{
    internal class Motor
    {
        public int Current = 500;
        public int Velocity = 120000;
        public int RampingSlow = 0;
        public int RampingFast = 0;
        public bool enable = false;
        public byte StepConfig = BrickletSilentStepperV2.STEP_RESOLUTION_128;

        private BrickletSilentStepperV2 Stepper;
        private String Uid;
        private IPConnection ipcon;

        Motor(String Uid, IPConnection ipcon)
        {
            this.Uid = Uid;
            this.ipcon = ipcon;
            this.Stepper = new BrickletSilentStepperV2(this.Uid,this.ipcon);
            Config();
        }
        public static void setConfig()
        {
            
        }

        private void Config()
        {
            this.Stepper.SetMotorCurrent(this.Current);
            this.Stepper.SetStepConfiguration(StepConfig,true);
            this.Stepper.SetMaxVelocity(this.Velocity);
            this.Stepper.SetSpeedRamping(RampingSlow, RampingFast);
            this.Stepper.SetEnabled(enable);
        }
        
        public void Go()
        {
            this.Stepper.SetSteps();
        }

    }
}