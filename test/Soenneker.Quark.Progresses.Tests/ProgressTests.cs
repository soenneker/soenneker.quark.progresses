using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Progresses.Tests;

[Collection("Collection")]
public sealed class ProgressTests : FixturedUnitTest
{
    public ProgressTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
