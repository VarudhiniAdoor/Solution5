namespace MiscTopics
{
    struct Record
    {
        int id;
        string name;
        string dept;
        //public Record() { }
        //public Record (int id)
        //{

        //this.id = id;}

        public Record(int id, string name, string dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
           
        }
        public void Display()
        {
            Console.WriteLine("ID is " + id);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Dept is "  + dept);
        }
    }

    struct Address
    {
        int houseNo;
        string city, state, pincode, mobileNum;
        public void DisplayAddress()
        {
            Console.WriteLine("house no  " + houseNo + " " + city+ " "+ state );
        }
    }
    class Employee
    {
         int id;
         string name;
         Address address;
        public void Display()
        {
            Console.WriteLine("ID" + id);
            Console.WriteLine("Address ");
            address.DisplayAddress();
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int? num = 10;
            if (num.HasValue)
            {
                Console.WriteLine(num.Value);
            }
            else
                Console.WriteLine("num contains null");
            Record rec = new Record(100, "ajay", "accts");
            rec.Display();
            Employee employee = new Employee();
            employee.Display(); 
        }
    }
}
