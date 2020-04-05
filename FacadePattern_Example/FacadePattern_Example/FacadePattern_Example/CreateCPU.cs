namespace FacadePattern_Example
{
    class CreateCPU
    {
        private string cpuType = "";
        
        public CreateCPU(string _cpu)
        {
            cpuType = _cpu;
        }

        public string getCPU()
        {
            return cpuType;
        }
    }
}
