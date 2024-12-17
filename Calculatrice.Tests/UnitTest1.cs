using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Calculatrice.Tests
{
    public class Tests
    {
       
        [Test]
        public void Addition_returnSommeCorrecte()
        {
            int result = Program.Addition(5, 7);
            Assert.AreEqual(12,result);
        }
    }
}