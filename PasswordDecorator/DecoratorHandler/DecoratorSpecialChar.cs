using PasswordDecorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordDecorator.DecoratorHandler
{
    public class DecoratorSpecialChar : DecoratorError
    {
        public DecoratorSpecialChar(IError error) : base(error)
        {
            _pwdError = "password must contain at least one special character";
        }
    }
}
