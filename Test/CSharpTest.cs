using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarCubePoc;

namespace Test
{
    [TestClass]
    public class CSharpTest
    {
        [TestMethod]
        public void TestGetDetails()
        {
           
            var csharp = new CSharp();

            csharp.SetDetails("2.0", "Net core");

           var output= csharp.GetDetails();

            Assert.IsNotNull(output);

        }
    }
}
