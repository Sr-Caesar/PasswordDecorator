using PasswordDecorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordDecorator.DecoratorHandler
{
    public class DecoratorNumber : DecoratorError
    {
        public DecoratorNumber(IError error) : base(error)
        {
            _pwdError = "The password must contain at least 2 numbers";
        }
    }
}
