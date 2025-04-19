namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
            double result = calc.Add(2, 3);

            
            Assert.Equal(5, result);
        }
    }
}