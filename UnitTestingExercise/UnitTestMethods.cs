using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int x, int y, int z)
        {
            
            var sum = x + y + z;
            return sum;
        }

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int x, int y)
        {
            var answer = x - y;
            return answer;
        }
        // Create a Multiply method that passes 2 integers
        public int Multiply(int x, int y)
        {
            var answer = x * y;
            return answer;
        }


        // Create a Divide method that passes 2 integers
        public int Divide(int x, int y)
        {
            var answer = x / y;
            return answer;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string Greet()
        {
            var greeting = "Hello";
            return greeting;
        }

        public string Goodbye ()
        {
            var goodbye = "Goodbye";
            return goodbye;
        }
        
    }
}
