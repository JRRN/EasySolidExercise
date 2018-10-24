using CalcToSolid.SolidCalc.Interfaces;

namespace CalcToSolid.SolidCalc.Logic
{
    public class Converter : IConverter // Open - Close
    {
        int IConverter.ConvertStringToInt(string value) //Single responsibility
        {
            var isConverted = int.TryParse(value, out int intValue);
            return isConverted ? intValue : 0;
        }

        public float ConvertStringToFloat(string value) //  Single responsibility
        {
            var isConverted = float.TryParse(value, out float floatValue);
            return isConverted ? floatValue : 0.0f;
        }
    }
}
