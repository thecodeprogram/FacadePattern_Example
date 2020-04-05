namespace FacadePattern_Example
{
    class CreateRAM
    {
        private string ramType = "";

        public CreateRAM(string _ram)
        {
            ramType = _ram;
        }

        public string getRAM()
        {
            return ramType;
        }
    }
}
