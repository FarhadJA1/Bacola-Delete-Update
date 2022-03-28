using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bacola_MVC_Updated_.Exceptions
{
    public class CustomException:Exception
    {
        public CustomException(string message):base(message)
        {

        }
    }
}
