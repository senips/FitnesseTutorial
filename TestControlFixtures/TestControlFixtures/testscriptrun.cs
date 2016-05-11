
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testcontrol
{

    [TestClass]
    public class TestRunnerTest
    {
        [TestMethod]
        public void ParseScriptLine()
        {
            var script = new TestScript();
            script.LoadScript("mockscript.txt");
            Assert.AreEqual(12, script.Instructions.Count);

        }


        [TestMethod]
        public void ReadInstruction()
        {
            var instruction = new Instruction("get info \"x\" with \"y\"");
            Assert.AreEqual(2, instruction.Parameters.Count);
            Assert.AreEqual("x", instruction.Parameters[0]);
            Assert.AreEqual("y", instruction.Parameters[1]);

            Assert.AreEqual("get info {0} with {1}", instruction.getSetpName());

        }
    }
}
