using System.Linq;
using Nuke.Common.Tools.Extension.Commands;
using Nuke.Common.Tools.Extension.Settings;
using Xunit;
using Xunit.Extensions.Ordering;
using static Nuke.Common.Tools.Extension.Tasks;

namespace Extension.Nuke.Tests
{
    [Order(1)]
    public class DotNetCommandTest
    {
        [Fact, Order(1)]
        public void Info()
        {
            var result = DotNetTask(_ => new DotNetToolSettings(DotNetCommand.Info));
            Assert.True(result.Any());
        }

        [Fact, Order(2)]
        public void Version()
        {
            var result = DotNetTask(_ => new DotNetToolSettings(DotNetCommand.Version));
            Assert.True(result.Any());
        }

    }
}
