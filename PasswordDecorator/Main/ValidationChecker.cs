
using PasswordDecorator.DecoratorHandler;
using PasswordDecorator.Interface;

namespace PasswordDecorator.Main
{
    public static class ValidationChecker
    {
        public static IError ValidationTest(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Invalid Argument");
            }
            IError myError;
            myError = new Error();
            LengthError(myError,password);
            CapitalLetterError(myError,password);
            SpecialCharError(myError,password);
            NumberError(myError,password);
            return myError;
        }

        private static void NumberError(IError myError, string password)
        {
            if (password.All(char.IsDigit))
            {
                myError = new DecoratorNumber(myError);
            }
        }
        private static void SpecialCharError(IError myError, string password)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            bool requirement = false;
            foreach (var item in specialChar)
            {
                if (password.Contains(item))
                {
                    requirement = true;
                }
            }
            if (requirement)
            {
                myError = new DecoratorSpecialChar(myError);
            }
        }
        private static void CapitalLetterError(IError myError, string password)
        {
            if (!password.ToLower().Equals(password))
            {
                myError = new DecoratorCapitalLetter(myError);
            }
        }
        private static void LengthError(IError myError, string password)
        {
            if (password.Length < 8)
            {
                myError = new DecoratorLength(myError);
            }
        }
    }
}
