namespace Assignment_1
{
    internal class Program
    {
        static void Main()
        {
            
            Employee e1 = new Employee("Amol",132465,10);

            Console.WriteLine(e1.ToString());


        }
        public class Employee
        {
            private int id;
            private static int counter;
            private String Name;
            private int EmpNo;
            private decimal Basic;
            private short DeptNo;

           public Employee(String Name, decimal Basic, short DeptNo )
            {
                this.id = ++counter;
                this.Name = Name;
               // this.EmpNo = EmpNo; 
                this.Basic = Basic; 
                this.DeptNo = DeptNo;
            }
            


           /* public void display() 
            {
                return 
            }*/
        }

    }
}