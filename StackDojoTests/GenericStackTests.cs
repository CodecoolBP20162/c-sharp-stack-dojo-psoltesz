using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackDojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDojo.Tests
{
    [TestClass()]
    public class GenericStackTests
    {
        [TestMethod()]
        public void PushTest()
        {
            GenericStack<int> stack = new GenericStack<int>(10);
            stack.Push(422);
            Assert.AreEqual(stack, "422,0,0,0,0,0,0,0,0,0");
        }
    }
}