namespace FacadePattern_Example
{
    class CreateHDD
    {
        private string hddType = "";

        public CreateHDD(string _hdd)
        {
            hddType = _hdd;
        }

        public string getHDD()
        {
            return hddType;
        }
    }
}
