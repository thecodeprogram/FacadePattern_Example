using System;

namespace FacadePattern_Example
{
    class BuildComputer
    {
        private CreateCPU CPU = new CreateCPU("Intel I7 6700U");
        private CreateRAM RAM = new CreateRAM("8GB 1600MHz");
        private CreateHDD HDD = new CreateHDD("2000GB SATA3");

        public void fnc_BuildComputer()
        {
            string comp = "Created Computer is : " + Environment.NewLine;
            comp += "--CPU is : " + CPU.getCPU() + Environment.NewLine;
            comp += "--RAM is : " + RAM.getRAM() + Environment.NewLine;
            comp += "--CPU is : " + HDD.getHDD() + Environment.NewLine;

            Console.WriteLine(comp);
        }
    }
}
