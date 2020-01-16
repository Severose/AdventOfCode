using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class Test
    {
        [TestCase(14, 2)]
        [TestCase(1969, 966)]
        [TestCase(100756, 50346)]
        public void Mass_X_Requires_Y_Fuel(int x, int y)
        {
            Assert.AreEqual(y,Program.getRequiredFuel(x));
        }
    }
}