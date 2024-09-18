using Xunit;
using Xunit.Extensions.Ordering;

namespace Extension.Nuke.Tests
{
    [Order(2)]
    public class CmdCommandTest
    {
        [Fact, Order(1)]
        public void Test1()
        {
            Assert.True(true);
        }
        
        [Fact, Order(2)]
        public void Test2()
        {
            Assert.True(true);
        }

    }
}
