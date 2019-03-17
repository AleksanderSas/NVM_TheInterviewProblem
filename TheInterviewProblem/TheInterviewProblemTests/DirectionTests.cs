using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TheInterviewProblem.Board;

namespace TheInterviewProblemTests
{
    [TestClass]
    public class DirectionTests
    {
        
        [TestMethod]
        public void TurnLeftFrom_N_Test()
        {
            TurnLeftTest(Direction.N, Direction.W);
        }

        [TestMethod]
        public void TurnLeftFrom_E_Test()
        {
            TurnLeftTest(Direction.W, Direction.S);
        }

        [TestMethod]
        public void TurnLeftFrom_S_Test()
        {
            TurnLeftTest(Direction.S, Direction.E);
        }

        [TestMethod]
        public void TurnLeftFrom_W_Test()
        {
            TurnLeftTest(Direction.E, Direction.N);
        }

        [TestMethod]
        public void TurnRigthFrom_N_Test()
        {
            TurnRigthTest(Direction.N, Direction.E);
        }

        [TestMethod]
        public void TurnRigthFrom_E_Test()
        {
            TurnRigthTest(Direction.E, Direction.S);
        }

        [TestMethod]
        public void TurnRigthFrom_S_Test()
        {
            TurnRigthTest(Direction.S, Direction.W);
        }

        [TestMethod]
        public void TurnRigthFrom_W_Test()
        {
            TurnRigthTest(Direction.W, Direction.N);
        }

        private void TurnLeftTest(Direction start, Direction end)
        {
            start = start.OnLeft();

            Assert.AreEqual(start, end);
        }

        private void TurnRigthTest(Direction start, Direction end)
        {
            start = start.OnRigth();

            Assert.AreEqual(start, end);
        }
    }
}
