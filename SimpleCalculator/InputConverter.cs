namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string textNum)
        {
            double convertedNumber;
            bool isParsed = double.TryParse(textNum, out convertedNumber);
            if (!isParsed)
                throw new ArgumentException("Expected a numeric value");
            return convertedNumber;
                
        }
    }
}