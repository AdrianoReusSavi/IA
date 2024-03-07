using IA.Domain.Exceptions;

namespace IA.Domain.Validation
{
    public class AssertionConcern
    {
        protected AssertionConcern()
        {

        }

        public static void ErroSeTrue(bool boolValue, string message)
        {
            if (boolValue)
            {
                throw new ValidationException(message);
            }
        }

        public static void ErroSeFalse(bool boolValue, string message)
        {
            if (!boolValue)
            {
                throw new ValidationException(message);
            }
        }

        public static void ErroSeMaior(int value1, int value2, string message)
        {
            if (value1 > value2)
            {
                throw new ValidationException(message);
            }
        }

        public static void ErroSeMaior(double value1, double value2, string message)
        {
            if (value1 > value2)
            {
                throw new ValidationException(message);
            }
        }

        public static void ErroSeMenor(int value1, int value2, string message)
        {
            if (value1 > value2)
            {
                throw new ValidationException(message);
            }
        }

        public static void ErroSeMenor(double value1, double value2, string message)
        {
            if (value1 > value2)
            {
                throw new ValidationException(message);
            }
        }

        public static void ErroSeNulo(object objectValue, string message)
        {
            if (objectValue == null)
            {
                throw new ValidationException(message);
            }
        }
    }
}