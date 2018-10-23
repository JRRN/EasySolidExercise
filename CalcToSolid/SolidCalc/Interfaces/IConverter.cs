using System;
namespace CalcToSolid.SolidCalc.Interfaces
{
    public interface IConverter
    {
        int ConvertStringToInt(string value);
        float ConvertStringToFloat(string value); // Open-Close
    }
}
