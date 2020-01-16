using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class Test
    {
        [TestCase(new int[] {1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50})]
        public void OpCode_1_Values_10_20_30(int opcode)
        {
            Assert.AreEqual(new int[] {3500,9,10,70,2,3,11,0,99,30,40,50},Program.evaluate(opcode));
        }
    }
}