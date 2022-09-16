namespace NhlSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Test plan for person
             * 
             * Test Case                    Test Data             Expected Result/Behavior
             * ---------                    ---------             ------------------------
             * Valid full name              Connor McDavid        FullName = Connor McDavid
             * 
             * Null full name               null                  Argument Null Exception
             * 
             * Empty full name              ""                    Argument Null Exception
             * 
             * Whitespace full name         " "                   Argument Null Exception
             * 
             * Full less than 3 chars       er                    Argument Exception
             * 
             */

            
            Person p = new Person("Connor McDavid");
            Console.WriteLine(p.ToString());

            try
            {
                Person p2 = new Person(null);
            } catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Person p3 = new Person("");
            //Person p4 = new Person(" ");
            //Person p5 = new Person("er");
        }
    }
}