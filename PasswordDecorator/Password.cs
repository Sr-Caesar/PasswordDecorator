
namespace PasswordDecorator
{
    internal class Password 
    {
        public int GetLength(string pswd)
        {
            return pswd.Length;
        }

        public bool HasNumbers(string pswd)
        {
            return pswd.All(char.IsDigit);
        }

        public bool HasSpecialChar(string pswd)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (pswd.Contains(item)) return true;
            }
            return false;
        }

        public bool HasUppercase(string pswd)
        {
            return !pswd.ToLower().Equals(pswd);
        }
    }
}
