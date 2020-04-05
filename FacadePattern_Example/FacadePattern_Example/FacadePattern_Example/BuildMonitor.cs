using System;

namespace FacadePattern_Example
{
    class BuildMonitor
    {
        CreateMonitorInterface monInt = new CreateMonitorInterface("HDMI");
        CreateMonitorType monType = new CreateMonitorType("LED Monitor");

        public void fnc_BuildMonitor()
        {
            string monitor = "Created monitor is : " + Environment.NewLine;
            monitor += "--Monitor Interface is : " + monInt.getMonitorInterface() + Environment.NewLine;
            monitor += "--Monitor Type is : " + monType.getMonitorType() + Environment.NewLine;

            Console.WriteLine(monitor);
        }
    }
}
