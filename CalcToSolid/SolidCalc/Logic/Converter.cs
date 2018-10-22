using System;
using CalcToSolid.SolidCalc.Interfaces;

namespace CalcToSolid.SolidCalc.Logic
{
    public class Converter : IConverter
    {
        int IConverter.ConvertStringToInt(string value)
        {
            var isConverted = int.TryParse(value, out int intValue);
            return isConverted ? intValue : 0;
        }
    }
}
