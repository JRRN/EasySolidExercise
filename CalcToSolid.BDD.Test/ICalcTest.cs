using CalcToSolid.SolidCalc.Interfaces;
using CalcToSolid.SolidCalc.Logic;
using Xunit;

namespace CalcToSolid.BDD.Test
{
    public class ICalcTest
    {
        private readonly ICalc _calc = new SolidCalc.Logic.SolidCalc(); //Interface segregation
        [Fact]
        public void GivenTwoNumberWhenApplyICalcSummatoryOperationThenObtainResult()
        {
            var result = _calc.DoOperation(OperationType.Sum, 1, 3);
            Assert.IsType<int>(result);
            Assert.Equal(4, result);
        }

        [Fact]
        public void GivenTwoNumberWhenApplyICalcSubtractionOperationThenObtainResult()
        {
            var result = _calc.DoOperation(OperationType.Sub, 1, 3);
            Assert.IsType<int>(result);
            Assert.Equal(-2, result);
        }

        [Fact]
        public void GivenTwoNumberWhenApplyICalcMultiplicationOperationThenObtainResult()
        {
            var result = _calc.DoOperation(OperationType.Mul, 1, 3);
            Assert.IsType<int>(result);
            Assert.Equal(3, result);
        }
        [Fact]
        public void GivenTwoNumberWhenApplyICalcDivisionyOperationThenObtainResult()
        {
            var result = _calc.DoOperation(OperationType.Div, 1, 3);
            Assert.IsType<int>(result);
            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenTwoNumberWhenApplyICalcExponentialOperationThenObtainResult()
        {
            var result = _calc.DoOperation(OperationType.NExpM, 2, 3);
            Assert.IsType<int>(result);
            Assert.Equal(8, result);
        }
    }
}