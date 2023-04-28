using PasswordDecorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordDecorator.DecoratorHandler
{
    public class DecoratorLength : DecoratorError
    {
        public DecoratorLength(IError error): base(error) 
        {
            _pwdError = "Password must be at least 8 characters";
        }
    }
}
