namespace FacadePattern_Example
{
    class CreateMonitorInterface
    {
        private string monInterface = "";

        public CreateMonitorInterface(string _interface)
        {
            monInterface = _interface;
        }

        public string getMonitorInterface()
        {
            return monInterface;
        }
    }
}
