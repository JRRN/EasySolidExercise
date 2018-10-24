﻿using CalcToSolid.SolidCalc.Interfaces;
using CalcToSolid.SolidCalc.Logic;
using Xunit;

namespace CalcToSolid.BDD.Test
{
    public class NExpMTest
    {
        private static readonly INExpM _nExpM = new OperationNExpM();

        [Fact]
        public void GivenTwoNumberWhenApplySubThenObtainResult()
        {
            var result = _nExpM.NExpM(2, 3);
            Assert.IsType<int>(result);
            Assert.Equal(8, result);
        }
    }
}