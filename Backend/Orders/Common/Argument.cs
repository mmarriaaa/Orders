namespace Common
{
    public static class Argument
    {
        public static void NotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null)
            {
                var exceptionMessage = string.Format(Resources.ArgumentCanNotBeNull, argumentName);
                throw new ArgumentNullException(exceptionMessage);
            }
        }

        public static void NotNullOrEmpty(string argumentValue, string argumentName)
        {
            if (string.IsNullOrEmpty(argumentValue))
            {
                var exceptionMessage = string.Format(Resources.ArgumentCanNotBeNullOrEmpty, argumentName);
                throw new ArgumentException(exceptionMessage);
            }
        }

        public static void NotZero(float argumentValue, string argumentName)
        {
            if (argumentValue == 0)
            {
                var exceptionMessage = string.Format(Resources.ArgumentCanNotBeEqualToZero, argumentName);
                throw new ArgumentException(exceptionMessage);
            }
        }

        public static void NotLessThanZero(float argumentValue, string argumentName)
        {
            if (argumentValue < 0)
            {
                var exceptionMessage = string.Format(Resources.ArgumentCanNotBeLessThanZero, argumentName);
                throw new ArgumentException(exceptionMessage);
            }
        }

        public static void NotZeroOrLessThanZero(float argumentValue, string argumentName)
        {
            NotZero(argumentValue, argumentName);
            NotLessThanZero(argumentValue, argumentName);        
        }

        public static void NotMoreThen(int argumentValue, string argumentName, int limit)
        {
            if (argumentValue > limit)
            {
                var exceptionMessage = string.Format(Resources.ArgumentCanNotBeMoreThen, argumentName, limit);
                throw new ArgumentOutOfRangeException(exceptionMessage);
            }
        }
    }
}
