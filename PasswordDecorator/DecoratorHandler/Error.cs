using PasswordDecorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordDecorator.DecoratorHandler
{
    public class Error : IError
    {
        public string GetError() => "";
    }
}
