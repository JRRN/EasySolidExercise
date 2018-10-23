using CalcToSolid.SolidCalc.Interfaces;
using CalcToSolid.SolidCalc.Logic;
using Xunit;

namespace CalcToSolid.BDD.Test
{
    public class ConverterTest
    {
        private static readonly IConverter _converter = new Converter();
        [Fact]
        public void GivenStringNumberWhenApplyConverterThenObtainIntResult()
        {
            var result = _converter.ConvertStringToInt("1");
            Assert.IsType<int>(result);
            Assert.Equal(1, result);
        }
    }
}