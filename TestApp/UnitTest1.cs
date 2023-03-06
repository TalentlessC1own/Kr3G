using Kr3G;

namespace TestApp
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calculator = new Calculator();

        DataHolder<double> test1Data = new DataHolder<double>(1, 5, 1, 3);

        double[] xAnswer1 = { 0.2871380342040011, 0.8644511272761339, 1.7123889803846897, 2.9034725840008657, 4.6655039715657995 };
        double[] yAnswer1 = { 1, 2, 3, 4, 5 };



        DataHolder<double> test2Data = new DataHolder<double>(1, 4, 1, 2);

        double[] xAnswer2 = { 0.3623442948243185, 1.1415926535897931, 2.456739397217514, 6.283185307179586};
        double[] yAnswer2 = { 1, 2, 3, 4 };

        DataHolder<double> test3Data = new DataHolder<double>(1, 3, 1, 5);

        double[] xAnswer3 = { 0.2175055439664213, 0.6364760900080615, 1.2138217086812029};
        double[] yAnswer3 = { 1, 2, 3 };


        [TestMethod]
        public void TestMethod1()
        {
            GraphData graphData =  calculator.GetGraphData(test1Data);
          
            Assert.IsTrue(Enumerable.SequenceEqual(graphData.xs,xAnswer1) && Enumerable.SequenceEqual(graphData.ys, yAnswer1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            GraphData graphData = calculator.GetGraphData(test2Data);

            Assert.IsTrue(Enumerable.SequenceEqual(graphData.xs, xAnswer2) && Enumerable.SequenceEqual(graphData.ys, yAnswer2));
        }

        [TestMethod]
        public void TestMethod3()
        {
            GraphData graphData = calculator.GetGraphData(test3Data);

            Assert.IsTrue(Enumerable.SequenceEqual(graphData.xs, xAnswer3) && Enumerable.SequenceEqual(graphData.ys, yAnswer3));
        }
    }
}