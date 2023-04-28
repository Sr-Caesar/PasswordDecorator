
using PasswordDecorator.Interface;

namespace PasswordDecorator.DecoratorHandler
{
    public class DecoratorError : IError
    {
        private readonly IError _error;
        protected string? _pwdError;

        public DecoratorError(IError error) { _error = error; }
        public string GetError() => $"{_error.GetError()} {_pwdError}";
    }
}
