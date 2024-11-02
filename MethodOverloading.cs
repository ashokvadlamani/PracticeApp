namespace PracticeApp
{
    internal class MethodOverloading
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
        public int AddNumbers(int a, int b, int c)
        {
            return AddNumbers(a,b) + c;
        }
        // public double AddNumbers(double a, double b)
        // {
        //     return a + b;
        // }
        public string AddNumbers(double a, double b)
        {
            return $"{a + b}";
        }
        public string AddNumbers(string a)
        {
            return a;
        }
        public virtual string GetAddress(string id)
        {
            //call db and query table by id to get address
            return "addresss";
        }
        public List<string> GetAddress(List<string> ids)
        {
            //call db and query table by id to get address
            return new List<string>(){"New York","Hyderabad"};
        }


    }
}