namespace FacadePattern_Example
{
    class CreateMonitorType
    {
        private string monType = "";

        public CreateMonitorType(string _type)
        {
            monType = _type;
        }

        public string getMonitorType()
        {
            return monType;
        }
    }
}
